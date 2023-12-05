using MyEmplo.Application.MyEmplo.Commands.EditMyEmplo;
using AutoMapper;
using MyEmplo.Application.MyEmplo;

namespace MyEmplo.Application.Mappings
{
    public class MyEmploMappingProfile : Profile
    {
        public MyEmploMappingProfile()
        {
            CreateMap<MyEmploDto, Domain.Entities.MyEmplo>();

            CreateMap<Domain.Entities.MyEmplo, MyEmploDto>();

            CreateMap<MyEmploDto, EditMyEmploCommand>();
        }
    }
}
