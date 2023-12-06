using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Infrastructure.Persistance
{
    public class MyEmploDbContext : IdentityDbContext
    {
        public MyEmploDbContext(DbContextOptions<MyEmploDbContext> options): base(options) 
        {

        }   
        public DbSet<Domain.Entities.MyEmplo> MyEmplos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.MyEmplo>();
        }
    }
}
