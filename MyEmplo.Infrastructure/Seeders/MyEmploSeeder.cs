using Microsoft.EntityFrameworkCore;
using MyEmplo.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Infrastructure.Seeders
{
    public class MyEmploSeeder
    {
        private readonly MyEmploDbContext _dbContext;

        public MyEmploSeeder(MyEmploDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.MyEmplos.Any())
                {
                    var John = new Domain.Entities.MyEmplo()
                    {
                        FullName = "Ahmed Khan",
                        Email = "ahmedkhan@gmail.com",
                        DateOfEmployment = "2023-01-01", 
                        TypeOfEmployment = "Full-time", 
                        Role = "Designer", 
                        Country = "Canada",
                        Address = "456 Market Street",
                        PhoneNumber = "+1 (416) 555-7890", 
                        WhatsApp = "+1 (416) 555-1234",
                        Skype = "ahmed.marketing.expert",
                        Messenger = "@ahmed.khan.marketing", 
                        About = "Creative and data-driven marketing specialist with a focus on digital strategies. Proven track record of developing and executing successful marketing campaigns. Skilled in market analysis and trend identification. Enjoys bringing innovative ideas to the table."
                    };
                    John.EncodeName();

                    _dbContext.Add(John);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
