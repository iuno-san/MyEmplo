using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmploService.Queries.GetMyEmploServices
{
	public class GetMyEmploServicesQuery : IRequest<IEnumerable<MyEmploServiceDto>>
	{
		public string EncodedName { get; set; } = default!;
	}
}
