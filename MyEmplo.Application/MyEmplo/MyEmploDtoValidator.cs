using FluentValidation;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmplo
{
    public class MyEmploDtoValidator : AbstractValidator<MyEmploDto>
    {
        public MyEmploDtoValidator(IMyEmploRepository repository)
        {

            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
