using Microsoft.EntityFrameworkCore;
using SysAcopioDeRL.Entities;
using SysAcopioDeRL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Infrastructure.Repositories
{
    public class RecursoSolicitudRepository : GenericRepository<RecursoSolicitud>, IRecursoSolicitudRepository
    {
        public RecursoSolicitudRepository(DbacopioDeRlContext pContext) : base(pContext)
        {
        }
        /// <summary>
        /// Metodo para obtener un listado de recursos por Id
        /// </summary>
        /// <param name="idRecurso"></param>
        /// <returns> Listado de recursos que coincidan con el Id</returns>
        public async Task<IEnumerable<RecursoSolicitud>> GetByRecursoAsync(long idRecurso)
        {
            return await dbContext.RecursoSolicitudes
                .Include(rs => rs.IdRecurso)
                .Include(rs => rs.IdSolicitud)
                .Where(rs => rs.IdRecurso == idRecurso)
                .ToListAsync();

        }

        /// <summary>
        /// Metodo para obtener un listado de solicitudes por Id
        /// </summary>
        /// <param name="idSolicitud"></param>
        /// <returns> Listado de solicitudes que coinciden con el Id</returns>
        public async Task<IEnumerable<RecursoSolicitud>> GetBySolicitudAsync(long idSolicitud)
        {
            return await dbContext.RecursoSolicitudes
                .Include(rs => rs.IdRecurso)
                .Include(rs => rs.IdSolicitud)
                .Where(rs => rs.IdSolicitud == idSolicitud)
                .ToListAsync();

        }
    }
}
