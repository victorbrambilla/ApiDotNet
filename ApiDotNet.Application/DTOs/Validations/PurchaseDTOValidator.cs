using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs.Validations
{
    public class PurchaseDTOValidator : AbstractValidator<PurchaseDTO>
    {
        public PurchaseDTOValidator()
        {
            RuleFor(p => p.CodErp)
                .NotEmpty().NotNull().WithMessage("O código ERP deve ser informado");
            RuleFor(p => p.Document)
                .NotEmpty().NotNull().WithMessage("O documento deve ser informado");
        }
    }
}
