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
            RuleFor(c => c.FullName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
                .MaximumLength(20).WithMessage("Name should have maxium of 20 characters");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty()
                .MinimumLength(8)
                .MaximumLength(20);

            RuleFor(c => c.Role)
                .NotEmpty();

            RuleFor(c => c.Email)
                .NotEmpty();

            RuleFor(c => c.TypeOfEmployment)
                .NotEmpty();
        }
    }
}
