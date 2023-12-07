using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmploService.Commands
{
    public class CreateMyEmploServiceCommandValidator : AbstractValidator<CreateMyEmploServiceCommand>
    {
        public CreateMyEmploServiceCommandValidator()
        {
            RuleFor(s => s.Name).NotEmpty().NotNull();
            RuleFor(s => s.Description).NotEmpty().NotNull();
            RuleFor(s => s.MyEmploEncodedName).NotEmpty().NotNull();
        }
    }
}
