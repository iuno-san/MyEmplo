using MediatR;
using MyEmplo.Application.ApplicationUser;
using MyEmplo.Domain.Entities;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmploService.Commands
{
    public class CreateMyEmploServiceCommandHandler : IRequestHandler<CreateMyEmploServiceCommand>
    {
        private readonly IUserContext _userContext;
        private readonly IMyEmploRepository _emploRepository;
        private readonly IMyEmploServiceRepository _emploServiceRepository;

        public CreateMyEmploServiceCommandHandler(IUserContext userContext, IMyEmploRepository emploRepository, IMyEmploServiceRepository emploServiceRepository)
        {
            _userContext = userContext;
            _emploRepository = emploRepository;
            _emploServiceRepository = emploServiceRepository;
        }

        public async Task<Unit> Handle(CreateMyEmploServiceCommand request, CancellationToken cancellationToken)
        {
            var myEmplo = await _emploRepository.GetByEncodedName(request.MyEmploEncodedName!);

            var user = _userContext.GetCurrentUser();
            var isEdibable = user != null && (myEmplo.CreatedById == user.Id);

            if (!isEdibable)
            {
                return Unit.Value;
            }

            var myEmploService = new Domain.Entities.MyEmploService()
            {
                Name = request.Name,
                Description = request.Description,
                MyEmploId = myEmplo.Id,
            };

            await _emploServiceRepository.Create(myEmploService);

            return Unit.Value;
        }
    }
}
