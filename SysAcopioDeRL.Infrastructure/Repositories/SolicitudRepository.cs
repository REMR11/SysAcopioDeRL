using Microsoft.EntityFrameworkCore;
using SysAcopioDeRL.Entities;
using SysAcopioDeRL.Interfaces;

namespace SysAcopioDeRL.Infrastructure.Repositories
{
    public class SolicitudRepository : GenericRepository<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(DbacopioDeRlContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Metodo para obtener solicitudes segun su nivel de urgencia
        /// </summary>
        /// <param name="urgencia"></param>
        /// <returns> Lista de solicitudes que coinciden con el nivel de urgencia </returns>
        public async Task<IEnumerable<Solicitud>> GetByUrgenciaAsync(byte urgencia)
        {
            return await dbContext.Solicituds
                .Include(s => s.RecursoSolicitudes)
                .Where(s => s.Urgencia == urgencia && s.Activo)
                .ToListAsync();
        }
        /// <summary>
        /// Metodo para obtener solicitudes activas asociadas a un recurso especifico
        /// </summary>
        /// <param name="idRecurso"></param>
        /// <returns> Lista de solicitudes activas que coinciden con el id del recurso proporcionado</returns>
        public async Task<IEnumerable<Solicitud>> GetRecursosActivos(long idRecurso)
        {
            return await dbContext.Solicituds
                .Include(s => s.RecursoSolicitudes)
                .ThenInclude(rs => rs.IdRecurso)
                .Where(s => s.Activo == true && s.RecursoSolicitudes
                    .Any(rs => rs.IdRecurso == idRecurso))
                .ToListAsync();
        }

        /// <summary>
        /// Metodo para obtener recursos relacionados a una solicitud
        /// </summary>
        /// <param name="idSolicitud"></param>
        /// <returns> Lista de recursosSolicitud que coinciden con el id proporcionado</returns>
        public async Task<IEnumerable<RecursoSolicitud>> GetRecursosSolicitudAsync(long idSolicitud)
        {
            return await dbContext.RecursoSolicituds
                .Where(rs => rs.IdSolicitud == idSolicitud)
                .ToListAsync();
        }

        /// <summary>
        /// Metodo para obtener solicitudes en estado activo
        /// </summary>
        /// <returns> Lista de solicitudes activas </returns>
        public async Task<IEnumerable<Solicitud>> GetSolicitudesActivasAsync()
        {
            return await dbContext.Solicituds
                .Where(s => s.Activo == true)
                .ToListAsync();
        }
    }
}
