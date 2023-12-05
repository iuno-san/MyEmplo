using FluentValidation;

namespace MyEmplo.Application.MyEmplo.Commands.EditMyEmplo
{
    public class EditMyEmploCommandValidator : AbstractValidator<EditMyEmploCommand>
    {
        public EditMyEmploCommandValidator()
        {
            RuleFor(c => c.FullName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
                .MaximumLength(20).WithMessage("Name should have maxium of 20 characters");

            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
