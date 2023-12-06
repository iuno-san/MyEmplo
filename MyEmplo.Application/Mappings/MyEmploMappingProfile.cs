using MyEmplo.Application.MyEmplo.Commands.EditMyEmplo;
using AutoMapper;
using MyEmplo.Application.MyEmplo;
using MyEmplo.Application.ApplicationUser;

namespace MyEmplo.Application.Mappings
{
    public class MyEmploMappingProfile : Profile
    {
        public MyEmploMappingProfile(IUserContext userContext)
        {
            var user = userContext.GetCurrentUser();

            CreateMap<MyEmploDto, Domain.Entities.MyEmplo>();

            CreateMap<Domain.Entities.MyEmplo, MyEmploDto>()
                .ForMember(dto => dto.IsEditable, opt => 
                opt.MapFrom(src => user != null && src.CreatedById == user.Id));

            CreateMap<MyEmploDto, EditMyEmploCommand>();
        }
    }
}
