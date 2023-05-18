using ApiDotNet.Application.DTOs;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper) 
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO)
        {
            if(productDTO == null)
            {
                return ResultService.Fail<ProductDTO>("Objeto deve ser informado");
            }

            var result = new ProductDTOValidator().Validate(productDTO);
            if(!result.IsValid)
            {
                return ResultService.RequestError<ProductDTO>("Problemas de validação!", result);
            }

            var product = _mapper.Map<Product>(productDTO);

            var productCreated = await _productRepository.createAsync(product);

            return ResultService.Ok<ProductDTO>(_mapper.Map<ProductDTO>(productCreated));

        }

        public async Task<ResultService<ProductDTO>> DeleteAsync(int id)
        {
            var product = await _productRepository.getByIdAsync(id);
            if(product == null)
            {
                return ResultService.Fail<ProductDTO>("Produto não encontrado");
            }
            await _productRepository.deleteAsync(product);
            return ResultService.Ok(_mapper.Map<ProductDTO>(product));  
        }

        public Task<ResultService<IEnumerable<ProductDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultService<ProductDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultService<ProductDTO>> UpdateAsync(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
