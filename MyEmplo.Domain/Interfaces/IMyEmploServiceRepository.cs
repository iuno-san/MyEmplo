using MyEmplo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Domain.Interfaces
{
    public interface IMyEmploServiceRepository
    {
        Task Create(MyEmploService service);

        Task<IEnumerable<MyEmploService>> GetAllByEncodedName(string encodedName);
    }
}
