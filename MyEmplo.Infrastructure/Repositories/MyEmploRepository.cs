using Microsoft.EntityFrameworkCore;
using MyEmplo.Domain.Interfaces;
using MyEmplo.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Infrastructure.Repositories
{
    internal class MyEmploRepository : IMyEmploRepository
    {
        private readonly MyEmploDbContext _dbContext;

        public MyEmploRepository(MyEmploDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Domain.Entities.MyEmplo myEmplo)
        {
            _dbContext.Add(myEmplo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.MyEmplo>> GetAll()
        => await _dbContext.MyEmplos.ToListAsync();
    }
}
