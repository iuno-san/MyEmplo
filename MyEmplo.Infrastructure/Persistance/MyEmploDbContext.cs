using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Infrastructure.Persistance
{
    public class MyEmploDbContext : DbContext
    {
        public MyEmploDbContext(DbContextOptions<MyEmploDbContext> options): base(options) 
        {

        }   
        public DbSet<Domain.Entities.MyEmplo> MyEmplos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.MyEmplo>();
        }
    }
}
