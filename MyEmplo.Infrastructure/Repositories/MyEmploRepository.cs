using Microsoft.EntityFrameworkCore;
using MyEmplo.Domain.Interfaces;
using MyEmplo.Infrastructure.Persistance;

namespace MyEmplo.Infrastructure.Repositories
{
    internal class MyEmploRepository : IMyEmploRepository
    {
        private readonly MyEmploDbContext _dbContext;

        public MyEmploRepository(MyEmploDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Commit()
        => _dbContext.SaveChangesAsync();

        public async Task Create(Domain.Entities.MyEmplo myEmplo)
        {
            _dbContext.Add(myEmplo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.MyEmplo>> GetAll()
        => await _dbContext.MyEmplos.ToListAsync();

        public async Task<Domain.Entities.MyEmplo> GetByEncodedName(string encodedName)
        => await _dbContext.MyEmplos.FirstAsync(c => c.EncodedName == encodedName);
    }
}
