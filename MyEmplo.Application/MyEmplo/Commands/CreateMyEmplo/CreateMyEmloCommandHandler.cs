using MyEmplo.Application.ApplicationUser;
using AutoMapper;
using MediatR;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmplo.Commands.CreateMyEmplo
{
    public class CreateMyEmloCommandHandler : IRequestHandler<CreateMyEmploCommand>
    {
        private readonly IMapper _mapper;
        private readonly IMyEmploRepository _myEmploRepository;
        private readonly IUserContext _userContext;

        public CreateMyEmloCommandHandler(IMapper mapper, IMyEmploRepository myEmploRepository, IUserContext userContext)
        {
            _mapper = mapper;
            _myEmploRepository = myEmploRepository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(CreateMyEmploCommand request, CancellationToken cancellationToken)
        {
            var myEmplo = _mapper.Map<Domain.Entities.MyEmplo>(request);
            myEmplo.EncodeName();

            myEmplo.CreatedById = _userContext.GetCurrentUser().Id;

            await _myEmploRepository.Create(myEmplo);

            return Unit.Value;
        }
    }
}
