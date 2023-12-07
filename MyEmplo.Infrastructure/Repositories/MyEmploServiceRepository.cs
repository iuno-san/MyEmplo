using Microsoft.EntityFrameworkCore;
using MyEmplo.Domain.Entities;
using MyEmplo.Domain.Interfaces;
using MyEmplo.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Infrastructure.Repositories
{
    public class MyEmploServiceRepository : IMyEmploServiceRepository
    {
        private MyEmploDbContext _dbContext { get; }
        public MyEmploServiceRepository(MyEmploDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Create(MyEmploService service)
        {
            _dbContext.Services.Add(service);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<MyEmploService>> GetAllByEncodedName(string encodedName) =>
            await _dbContext.Services
            .Where(s => s.MyEmplo.EncodedName == encodedName)
            .ToListAsync();
    }
}
