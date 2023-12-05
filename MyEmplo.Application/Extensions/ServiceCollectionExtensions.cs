using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyEmplo.Application.Mappings;
using MyEmplo.Application.MyEmplo;
using MyEmplo.Application.MyEmplo.Commands.CreateMyEmplo;
using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateMyEmploCommand));

            services.AddAutoMapper(typeof(MyEmploMappingProfile));

            services.AddValidatorsFromAssemblyContaining<MyEmploDtoValidator>()
                   .AddFluentValidationAutoValidation()
                   .AddFluentValidationClientsideAdapters();
        }
    }
}
