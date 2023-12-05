using AutoMapper;
using MyEmplo.Application.MyEmplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.Mappings
{
    public class MyEmploMappingProfile : Profile
    {
        public MyEmploMappingProfile()
        {
            CreateMap<MyEmploDto, Domain.Entities.MyEmplo>();

            CreateMap<Domain.Entities.MyEmplo, MyEmploDto>();
        }
    }
}
