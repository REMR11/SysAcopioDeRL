using SysAcopioDeRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface ITipoRecursoRepository : IGenericRepository<TipoRecurso>
    {
        Task<TipoRecurso> GetByNombreAsync(string nombre);
        Task<IEnumerable<TipoRecurso>> GetWithRecursosAsync();
    }
}
