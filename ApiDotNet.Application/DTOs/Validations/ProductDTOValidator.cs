using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs.Validations
{
    internal class ProductDTOValidator : AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(x => x.CodErp)
                .NotEmpty().NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(x => x.Price)
               .GreaterThan(0)
                .WithMessage("O campo {PropertyName} precisa ser maior que 0");

        }
    }  
    
}
