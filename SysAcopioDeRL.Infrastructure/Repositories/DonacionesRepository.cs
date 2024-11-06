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
    public class DonacionesRepository : GenericRepository<Donacion>, IDonacionRepository
    {
        public DonacionesRepository(DbacopioDeRlContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Metodo para encontrar donaciones realizadas en una fecha especifica
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns> Lista de donaciones que coincidan con la fecha proporcionada</returns>
        public async Task<IEnumerable<Donacion>> GetByFechasAsync(DateTime fecha)
        {
            return await dbContext.Donaciones
                .Where(d => d.Fecha == fecha)
                .ToListAsync();
        }

        /// <summary>
        /// Metodo para obtener donaciones mediante el id de un proveedor
        /// </summary>
        /// <param name="idProveedor"></param>
        /// <returns>Lista de donaciones realizadas por un proveedor</returns>
        public async Task<IEnumerable<Donacion>> GetByProveedorAsync(long idProveedor)
        {
            return await dbContext.Donaciones
                .Include(p => p.IdProveedor)
                .Where(p => p.IdProveedor == idProveedor)
                .ToListAsync();
        }


        /// <summary>
        /// Metodo para obtener un listado de recursos segun el id de la donacion
        /// </summary>
        /// <param name="idDonacion"></param>
        /// <returns> Listado de recursos que coinciden con el id proporcionado</returns>
        public async Task<IEnumerable<RecursoDonacion>> GetRecursosDonacionAsync(long idDonacion)
        {
            return await dbContext.RecursoDonaciones
                .Include(d => d.IdRecurso)
                .Where(d => d.IdRecurso == idDonacion)
                .ToListAsync();
        }
    }
}
