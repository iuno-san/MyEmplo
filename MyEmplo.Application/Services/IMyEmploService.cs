using MyEmplo.Application.MyEmplo;
using MyEmplo.Domain.Interfaces;
namespace MyEmplo.Application.Services
{
    public interface IMyEmploService
    {
        Task Create(MyEmploDto myEmplo);
    }
}