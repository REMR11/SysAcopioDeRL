using SysAcopioDeRL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SysAcopioDeRL.Interfaces
{
    public interface ISolicitudRepository : IGenericRepository<Solicitud>
    {
        Task<IEnumerable<Solicitud>> GetRecursosActivos(long idRecurso);
        Task<IEnumerable<Solicitud>> GetSolicitudesActivasAsync();
        Task<IEnumerable<Solicitud>> GetByUrgenciaAsync(byte urgencia);
        Task<IEnumerable<RecursoSolicitud>> GetRecursosSolicitudAsync(long idSolicitud);
    }
}
