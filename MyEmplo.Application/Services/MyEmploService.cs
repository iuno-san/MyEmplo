using MyEmplo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Application.Services
{
    public class MyEmploService : IMyEmploService
    {
        private readonly IMyEmploRepository _myEmploRepository;

        public MyEmploService(IMyEmploRepository myEmploRepository)
        {
            _myEmploRepository = myEmploRepository;
        }

        public async Task Create(Domain.Entities.MyEmplo myEmplo)
        {
            await _myEmploRepository.Create(myEmplo);
        }
    }
}
