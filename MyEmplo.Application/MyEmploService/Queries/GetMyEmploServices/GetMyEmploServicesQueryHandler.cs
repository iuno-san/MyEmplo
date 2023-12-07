using AutoMapper;
using MediatR;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmploService.Queries.GetMyEmploServices
{
	public class GetMyEmploServicesQueryHandler : IRequestHandler<GetMyEmploServicesQuery, IEnumerable<MyEmploServiceDto>>
	{
		private readonly IMapper _mapper;
		private readonly IMyEmploServiceRepository _myEmploService;

		public GetMyEmploServicesQueryHandler(IMapper mapper, IMyEmploServiceRepository myEmploService)
        {
			_mapper = mapper;
			_myEmploService = myEmploService;
		}

        public async Task<IEnumerable<MyEmploServiceDto>> Handle(GetMyEmploServicesQuery request, CancellationToken cancellationToken)
		{
			var result = await _myEmploService.GetAllByEncodedName(request.EncodedName);

			var dtos = _mapper.Map<IEnumerable<MyEmploServiceDto>>(result);

			return dtos;
		}
	}
}
