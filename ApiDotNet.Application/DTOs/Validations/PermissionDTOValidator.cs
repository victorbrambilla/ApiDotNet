using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.DTOs.Validations
{
    internal class PermissionDTOValidator : AbstractValidator<PermissionDTO>
    {
        public PermissionDTOValidator()
        {
            RuleFor(x => x.VisualName)
                .NotNull()
                .WithMessage("VisualName precisa ser fornecido");
            RuleFor(x => x.PermissionName)
                .NotNull()
                .WithMessage("PermissionName precisa ser fornecido");
        }
    }
}