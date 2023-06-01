using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using AutoMapper;

namespace ApiDotNet.Application.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PurchaseService(IProductRepository productRepository, IPersonRepository personRepository, IPurchaseRepository purchaseRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _personRepository = personRepository;
            _purchaseRepository = purchaseRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultService<PurchaseDTO>> CreateAsync(PurchaseDTO purchaseDTO)
        {
            if (purchaseDTO == null)
            {
                return ResultService.Fail<PurchaseDTO>("Objeto deve ser informado");
            }
            var validate = new PurchaseDTOValidator().Validate(purchaseDTO);
            if (!validate.IsValid)
            {
                return ResultService.RequestError<PurchaseDTO>("Problemas de validação!", validate);
            }

            try
            {
                await _unitOfWork.BeginTransaction();
                var productId = await _productRepository.GetIdByCodErpAsync(purchaseDTO.CodErp);
                if (productId == 0)
                {
                    var product = new Product(purchaseDTO.ProductName, purchaseDTO.CodErp, purchaseDTO.Price ?? 0);
                    await _productRepository.CreateAsync(product);
                    productId = product.Id;
                }
                var personId = await _personRepository.GetIdByDocumentAsync(purchaseDTO.Document);

                var purchase = new Purchase(productId, personId);

                var data = await _purchaseRepository.CreateAsync(purchase);
                purchaseDTO.Id = data.Id;
                await _unitOfWork.Commit();
                return ResultService.Ok<PurchaseDTO>(purchaseDTO);
            }
            catch (Exception ex)
            {
                await _unitOfWork.Rollback();
                return ResultService.Fail<PurchaseDTO>($"Erro ao salvar compra: {ex.Message}");
            }
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);
            if (purchase == null)
            {
                return ResultService.Fail<PurchaseDTO>("Compra não encontrada");
            }
            await _purchaseRepository.DeleteAsync(purchase);
            return ResultService.Ok(_mapper.Map<ProductDTO>(purchase));
        }

        public async Task<ResultService<ICollection<PurchaseDetailDTO>>> GetAllAsync()
        {
            var purchases = await _purchaseRepository.GetAllAsync();
            return ResultService.Ok<ICollection<PurchaseDetailDTO>>(_mapper.Map<ICollection<PurchaseDetailDTO>>(purchases));
        }

        public async Task<ResultService<PurchaseDetailDTO>> GetByIdAsync(int id)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(id);
            if (purchase == null)
            {
                return ResultService.Fail<PurchaseDetailDTO>("Compra não encontrada");
            }
            return ResultService.Ok<PurchaseDetailDTO>(_mapper.Map<Purchase, PurchaseDetailDTO>(purchase));
        }

        public async Task<ResultService<ICollection<PurchaseDetailDTO>>> GetByPersonIdAsync(int personId)
        {
            var purchases = await _purchaseRepository.GetByPersonIdAsync(personId);
            return ResultService.Ok<ICollection<PurchaseDetailDTO>>(_mapper.Map<ICollection<PurchaseDetailDTO>>(purchases));
        }

        public async Task<ResultService<ICollection<PurchaseDetailDTO>>> GetByProductIdAsync(int productId)
        {
            var purchases = await _purchaseRepository.GetByProductIdAsync(productId);
            return ResultService.Ok<ICollection<PurchaseDetailDTO>>(_mapper.Map<ICollection<PurchaseDetailDTO>>(purchases));
        }

        public async Task<ResultService> UpdateAsync(PurchaseDTO purchaseDTO)
        {
            if (purchaseDTO == null)
            {
                return ResultService.Fail<PurchaseDTO>("Objeto deve ser informado");
            }

            var validate = new PurchaseDTOValidator().Validate(purchaseDTO);
            if (!validate.IsValid)
            {
                return ResultService.RequestError<PurchaseDTO>("Problemas de validação!", validate);
            }

            var purchaseToUpdate = await _purchaseRepository.GetByIdAsync(purchaseDTO.Id);
            if (purchaseToUpdate == null)
            {
                return ResultService.Fail<PurchaseDTO>("Compra não encontrada");
            }

            var productId = await _productRepository.GetIdByCodErpAsync(purchaseDTO.CodErp);
            var personId = await _personRepository.GetIdByDocumentAsync(purchaseDTO.Document);

            purchaseToUpdate.Edit(purchaseToUpdate.Id, productId, personId);
            await _purchaseRepository.UpdateAsync(purchaseToUpdate);
            return ResultService.Ok(_mapper.Map<PurchaseDTO>(purchaseToUpdate));
        }
    }
}