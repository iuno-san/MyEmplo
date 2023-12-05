using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmplo.Domain.Interfaces
{
    public interface IMyEmploRepository
    {
        Task Create(Domain.Entities.MyEmplo myEmplo);
        Task<IEnumerable<Domain.Entities.MyEmplo>> GetAll();
    }
}
