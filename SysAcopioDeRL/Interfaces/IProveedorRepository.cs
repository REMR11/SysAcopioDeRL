using SysAcopioDeRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IProveedorRepository : IGenericRepository<Proveedor>
    {
        Task<IEnumerable<Proveedor>> GetProveedoresActivosAsync();
        Task<IEnumerable<Donacion>> GetDonacionesByProveedorAsync(long idProveedor);
    }
}
