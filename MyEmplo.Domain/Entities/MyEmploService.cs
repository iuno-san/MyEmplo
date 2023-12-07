using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Domain.Entities
{
    public class MyEmploService
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public int MyEmploId { get; set; } = default!;
        public MyEmplo MyEmplo { get; set; } = default!;


    }
}
