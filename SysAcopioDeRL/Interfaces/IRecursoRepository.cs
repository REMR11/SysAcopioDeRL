using SysAcopioDeRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IRecursoRepository : IGenericRepository<Recurso>
    {
        Task<IEnumerable<Recurso>> GetByTipoRecursoAsync(long idTipoRecurso);
        Task<IEnumerable<Recurso>> GetBajoStockAsync(int cantidadMinima);
        Task<bool> ActualizarStockAsync(long idRecurso, int cantidad);
    }
}
