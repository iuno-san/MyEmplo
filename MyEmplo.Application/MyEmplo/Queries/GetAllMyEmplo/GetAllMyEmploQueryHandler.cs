using AutoMapper;
using MediatR;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmplo.Queries.GetAllMyEmplo
{
    public class GetAllMyEmploQueryHandler : IRequestHandler<GetAllMyEmploQuery, IEnumerable<MyEmploDto>>
    {
        private readonly IMapper _mapper;
        private readonly IMyEmploRepository _myEmploRepository;
        public GetAllMyEmploQueryHandler( IMapper mapper, IMyEmploRepository myEmploRepository)
        {
            _mapper = mapper;
            _myEmploRepository = myEmploRepository;
        }
        public async Task<IEnumerable<MyEmploDto>> Handle(GetAllMyEmploQuery request, CancellationToken cancellationToken)
        {
            var myEmplos = await _myEmploRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<MyEmploDto>>(myEmplos);

            return dtos;
        }
    }
}
