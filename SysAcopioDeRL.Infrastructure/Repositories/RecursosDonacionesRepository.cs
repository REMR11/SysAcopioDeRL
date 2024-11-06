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
    public class RecursosDonacionesRepository : GenericRepository<RecursoDonacion>, IRecursoDonacionRepository
    {
        public RecursosDonacionesRepository(DbacopioDeRlContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Metodo para obtener un listado de recursos segun el Id de las donaciones
        /// </summary>
        /// <param name="idDonacion"></param>
        /// <returns> Listado de recurso que coinciden con el id de las donaciones</returns>
        public async Task<IEnumerable<RecursoDonacion>> GetByDonacionAsync(long idDonacion)
        {
            return await dbContext.RecursoDonaciones
                .Include(r => r.IdRecurso)
                .Where(r => r.IdDonacion == idDonacion)
                .ToListAsync();
        }

        public async Task<IEnumerable<RecursoDonacion>> GetByRecursoAsync(long idRecurso)
        {
            return await dbContext.RecursoDonaciones
                .Include(r => r.IdDonacion)
                .Where(r => r.IdRecurso == idRecurso)
                .ToListAsync();
        }
    }
}
