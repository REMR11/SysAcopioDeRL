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
    public class SolicitudRepository : GenericRepository<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(DbacopioDeRlContext pContext) : base(pContext)
        {
        }

        public async Task<IEnumerable<Solicitud>> GetByUrgenciaAsync(byte urgencia)
        {
            return await dbContext.Solicituds
                .Include(s => s.RecursoSolicitudes)
                .ThenInclude(rs => rs.IdRecurso)
                .Where(s => s.Urgencia == urgencia && s.Activo)
                .ToListAsync();
        }

        public async Task<IEnumerable<Solicitud>> GetRecursosActivos(long idRecurso)
        {
            return await dbContext.Solicituds
                .Include(s => s.RecursoSolicitudes)
                .ThenInclude(rs => rs.IdRecurso)
                .Where(s => s.Activo ==true)
                .ToListAsync();
        }

        public Task<IEnumerable<RecursoSolicitud>> GetRecursosSolicitudAsync(long idSolicitud)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Solicitud>> GetSolicitudesActivasAsync()
        {
            throw new NotImplementedException();
        }
    }
}
