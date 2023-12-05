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
                        FullName = "John Doe",
                        Email = "johndoe@gmail.com",
                        DateOfEmployment = "2023-01-01", // Przykładowa data zatrudnienia
                        TypeOfEmployment = "Full-time", // Typ zatrudnienia
                        Role = "Designer", // Rola pracownika
                        Country = "Polska", // Kraj
                        Address = "Kraków, długa 12",
                        PhoneNumber = "123-456-7890", // Numer telefonu
                        BankAccountNumber = "123456789", // Numer konta bankowego
                        Skype = "john.doe.skype", // Nazwa użytkownika na Skype
                        Discord = "john_doe#1234", // Nazwa użytkownika na Discord
                        About = "I deal with various aspects of programming, especially interested in modern web technologies." // opis pracownika
                    };
                    John.EncodeName();

                    _dbContext.Add(John);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
