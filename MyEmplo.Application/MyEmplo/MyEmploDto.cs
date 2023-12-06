using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyEmplo.Application.MyEmplo
{
    public class MyEmploDto
    {
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
        public string? EncodedName { get; set; }
        public bool IsEditable { get; set; }
    }
}
