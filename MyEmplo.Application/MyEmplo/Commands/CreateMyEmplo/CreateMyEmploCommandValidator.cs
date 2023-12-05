using FluentValidation;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmplo.Commands.CreateMyEmplo
{
    public class CreateMyEmploCommandValidator : AbstractValidator<CreateMyEmploCommand>
    {
        public CreateMyEmploCommandValidator(IMyEmploRepository repository)
        {
            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
