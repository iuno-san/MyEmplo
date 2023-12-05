using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.MyEmplo.Queries.GetMyEmploByEncodedName
{
    public class GetMyEmploByEncodedNameQuery : IRequest<MyEmploDto>
    {
        public string EncodedName { get; set; }

        public GetMyEmploByEncodedNameQuery(string encodedName)
        {
            EncodedName = encodedName;
        }


    }
}
