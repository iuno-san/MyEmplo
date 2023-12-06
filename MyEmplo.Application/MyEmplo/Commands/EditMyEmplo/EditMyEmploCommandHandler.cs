using MyEmplo.Domain.Interfaces;
using MediatR;
using MyEmplo.Application.ApplicationUser;


namespace MyEmplo.Application.MyEmplo.Commands.EditMyEmplo
{
    internal class EditMyEmploCommandHandler : IRequestHandler<EditMyEmploCommand>
    {
        private readonly IMyEmploRepository _repository;
        private readonly IUserContext _userContext;

        public EditMyEmploCommandHandler(IMyEmploRepository repository, IUserContext userContext)
        {
            _repository = repository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(EditMyEmploCommand request, CancellationToken cancellationToken)
        {
            var myEmplo = await _repository.GetByEncodedName(request.EncodedName!);

            var user = _userContext.GetCurrentUser();
            var isEditable = user != null || myEmplo.CreatedById == user.Id;

            if (!isEditable)
            {
                return Unit.Value;
            }

            myEmplo.FullName = request.FullName;
            myEmplo.About = request.About;
            myEmplo.Email = request.Email;
            myEmplo.DateOfEmployment = request.DateOfEmployment;
            myEmplo.TypeOfEmployment = request.TypeOfEmployment;
            myEmplo.Role = request.Role;
            myEmplo.Country = request.Country;
            myEmplo.Address = request.Address;
            myEmplo.PhoneNumber = request.PhoneNumber;
            myEmplo.BankAccountNumber = request.BankAccountNumber;
            myEmplo.Skype = request.Skype;
            myEmplo.Discord = request.Discord;

            await _repository.Commit();

            return Unit.Value;
        }
    }
}
