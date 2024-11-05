using SysAcopioDeRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IRecursoSolicitudRepository : IGenericRepository<RecursoSolicitud>
    {
        Task<IEnumerable<RecursoSolicitud>> GetBySolicitudAsync(long idSolicitud);
        Task<IEnumerable<RecursoSolicitud>> GetByRecursoAsync(long idRecurso);
    }
}
