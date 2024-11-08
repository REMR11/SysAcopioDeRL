﻿using Microsoft.EntityFrameworkCore;
using SysAcopioDeRL.Entities;
using SysAcopioDeRL.Interfaces;

namespace SysAcopioDeRL.Infrastructure.Repositories
{
    public class SolicitudRepository : GenericRepository<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(DbacopioDeRlContext pContext) : base(pContext)
        {
        }
        public async Task<bool> DeleteLogicAsync(long id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                if (entity == null) return false;
                entity.Estado = false;
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
            
        /// <summary>
        /// Metodo para obtener solicitudes segun su nivel de urgencia
        /// </summary>
        /// <param name="urgencia"></param>
        /// <returns> Lista de solicitudes que coinciden con el nivel de urgencia </returns>
        public async Task<IEnumerable<Solicitud>> GetByUrgenciaAsync(byte urgencia)
        {
            return await dbContext.Solicitudes
                .Include(s => s.RecursoSolicitudes)
                .Where(s => s.Urgencia == urgencia && s.Estado)
                .ToListAsync();
        }
        /// <summary>
        /// Metodo para obtener solicitudes activas asociadas a un recurso especifico
        /// </summary>
        /// <param name="idRecurso"></param>
        /// <returns> Lista de solicitudes activas que coinciden con el id del recurso proporcionado</returns>
        public async Task<IEnumerable<Solicitud>> GetRecursosActivos(long idRecurso)
        {
            return await dbContext.Solicitudes
                .Include(s => s.RecursoSolicitudes)
                .ThenInclude(rs => rs.IdRecurso)
                .Where(s => s.Estado == true && s.RecursoSolicitudes
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
            return await dbContext.RecursoSolicitudes
                .Where(rs => rs.IdSolicitud == idSolicitud)
                .ToListAsync();
        }

        /// <summary>
        /// Metodo para obtener solicitudes en estado activo
        /// </summary>
        /// <returns> Lista de solicitudes activas </returns>
        public async Task<IEnumerable<Solicitud>> GetSolicitudesActivasAsync()
        {
            return await dbContext.Solicitudes
                .Where(s => s.Estado == true)
                .ToListAsync();
        }
    }
}
