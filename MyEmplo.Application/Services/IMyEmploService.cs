using MyEmplo.Domain.Interfaces;
namespace MyEmplo.Application.Services
{
    public interface IMyEmploService
    {
        Task Create(Domain.Entities.MyEmplo myEmplo);
    }
}