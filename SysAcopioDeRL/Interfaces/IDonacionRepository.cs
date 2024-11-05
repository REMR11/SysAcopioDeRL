using SysAcopioDeRL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IDonacionRepository
    {
        Task<IEnumerable<Donacion>> GetByProveedorAsync(long idProveedor);
        Task<IEnumerable<Donacion>> GetByFechasAsync(DateTime fechaInicio, DateTime fechaFin);
        Task<IEnumerable<RecursoDonacion>> GetRecursosDonacionAsync(long idDonacion);
    }
}
