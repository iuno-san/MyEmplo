using AutoMapper;
using MediatR;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmplo.Queries.GetMyEmploByEncodedName
{
    public class GetMyEmploByEncodedNameQueryHandler : IRequestHandler<GetMyEmploByEncodedNameQuery, MyEmploDto>
    {
        private readonly IMyEmploRepository _myEmploRepository;
        private readonly IMapper _mapper;

        public GetMyEmploByEncodedNameQueryHandler(IMyEmploRepository myEmploRepository, IMapper mapper)
        {
            _myEmploRepository = myEmploRepository;
            _mapper = mapper;
        }

        public async Task<MyEmploDto> Handle(GetMyEmploByEncodedNameQuery request, CancellationToken cancellationToken)
        {
            var myEmplo = await _myEmploRepository.GetByEncodedName(request.EncodedName);

            var dtos = _mapper.Map<MyEmploDto>(myEmplo);

            return dtos;
        }
    }
}
