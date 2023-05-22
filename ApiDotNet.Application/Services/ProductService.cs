using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using AutoMapper;

namespace ApiDotNet.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return ResultService.Fail<ProductDTO>("Objeto deve ser informado");
            }

            var result = new ProductDTOValidator().Validate(productDTO);
            if (!result.IsValid)
            {
                return ResultService.RequestError<ProductDTO>("Problemas de validação!", result);
            }

            var product = _mapper.Map<Product>(productDTO);

            var productCreated = await _productRepository.CreateAsync(product);

            return ResultService.Ok<ProductDTO>(_mapper.Map<ProductDTO>(productCreated));
        }

        public async Task<ResultService<ProductDTO>> DeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return ResultService.Fail<ProductDTO>("Produto não encontrado");
            }
            await _productRepository.DeleteAsync(product);
            return ResultService.Ok(_mapper.Map<ProductDTO>(product));
        }

        public async Task<ResultService<ICollection<ProductDTO>>> GetAllAsync()
        {
            var products = await _productRepository.GetProductsAsync();
            return ResultService.Ok<ICollection<ProductDTO>>(_mapper.Map<ICollection<ProductDTO>>(products));
        }

        public async Task<ResultService<ProductDTO>> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return ResultService.Fail<ProductDTO>("Produto não encontrado");
            }
            return ResultService.Ok(_mapper.Map<ProductDTO>(product));
        }

        public async Task<ResultService<ProductDTO>> UpdateAsync(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return ResultService.Fail<ProductDTO>("Objeto deve ser informado");
            }

            var result = new ProductDTOValidator().Validate(productDTO);
            if (!result.IsValid)
            {
                return ResultService.RequestError<ProductDTO>("Problemas de validação!", result);
            }

            var product = await _productRepository.GetByIdAsync(productDTO.Id);
            if (product == null)
            {
                return ResultService.Fail<ProductDTO>("Produto não encontrado");
            }

            product = _mapper.Map<ProductDTO, Product>(productDTO, product);
            await _productRepository.UpdateAsync(product);
            return ResultService.Ok(_mapper.Map<ProductDTO>(product));
        }
    }
}