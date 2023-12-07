using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmploService.Commands
{
    public class CreateMyEmploServiceCommand : MyEmploServiceDto, IRequest
    {
        public string MyEmploEncodedName { get; set; } = default!;
    }
}
