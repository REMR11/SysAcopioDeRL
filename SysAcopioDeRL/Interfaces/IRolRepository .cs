using SysAcopioDeRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IRolRepository : IGenericRepository<Rol>
    {
        Task<Rol> GetByNombreAsync(string nombre);
        Task<IEnumerable<Rol>> GetRolesActivosAsync();
    }
}
