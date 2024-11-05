using SysAcopioDeRL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByAliasAsync(string alias);
        Task<IEnumerable<Usuario>> GetByRolAsync(long idRol);
        Task<IEnumerable<Usuario>> GetUsuariosActivosAsync();
    }
}
