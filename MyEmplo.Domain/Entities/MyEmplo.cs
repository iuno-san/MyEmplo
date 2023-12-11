using Microsoft.AspNetCore.Identity;
using System;
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
        public string FullName { get; set; } = default!;
        public string? Email { get; set; }
        public string? About { get; set; }
        public string? DateOfEmployment { get; set; }
        public string? TypeOfEmployment { get; set; }
        public string? Role { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WhatsApp { get; set; }
        public string? Skype { get; set; }
        public string? Messenger { get; set; }
        public string EncodedName { get; set; } = default!;
        public string? CreatedById { get; set; }
        public IdentityUser? CreatedBy { get; set; }
        public List<MyEmploService> Services { get; set; } = new();
        public void EncodeName() => EncodedName = FullName.ToLower().Replace(" ", "-");
    }
}
