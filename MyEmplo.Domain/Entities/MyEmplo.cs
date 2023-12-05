﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Domain.Entities
{
    public class MyEmplo
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? About { get; set; }
        public string? DateOfEmployment { get; set; }
        public string? TypeOfEmployment { get; set; }
        public string? Role { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? Skype { get; set; }
        public string? Discord { get; set; }

    }
}