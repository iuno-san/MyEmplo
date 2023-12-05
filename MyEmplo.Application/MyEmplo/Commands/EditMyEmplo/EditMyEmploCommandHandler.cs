using MyEmplo.Domain.Interfaces;
using MediatR;


namespace MyEmplo.Application.MyEmplo.Commands.EditMyEmplo
{
    internal class EditMyEmploCommandHandler : IRequestHandler<EditMyEmploCommand>
    {
        private readonly IMyEmploRepository _repository;

        public EditMyEmploCommandHandler(IMyEmploRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(EditMyEmploCommand request, CancellationToken cancellationToken)
        {
            var myEmplo = await _repository.GetByEncodedName(request.EncodedName!);

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
