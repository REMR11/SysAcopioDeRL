using SysAcopioDeRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IRecursoDonacionRepository : IGenericRepository<RecursoDonacion>
    {
        Task<IEnumerable<RecursoDonacion>> GetByDonacionAsync(long idDonacion);
        Task<IEnumerable<RecursoDonacion>> GetByRecursoAsync(long idRecurso);
    }
}
