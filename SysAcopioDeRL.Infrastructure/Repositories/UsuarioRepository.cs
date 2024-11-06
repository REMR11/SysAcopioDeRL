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
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DbacopioDeRlContext pContext) : base(pContext) {}

        public async Task<Usuario> GetByAliasAsync(string alias)
        {
            return await dbContext.Usuarios
                .Include(u => u.AliasUsuario)
                .FirstOrDefaultAsync(u => u.AliasUsuario == alias);
        }

        public async Task<IEnumerable<Usuario>> GetByRolAsync(long idRol)
        {
            return await dbContext.Usuarios
                .Include(u => u.IdRol)
                .Where(r => r.IdRol == idRol)
                .ToListAsync();
        }

        public async Task<IEnumerable<Usuario>> GetUsuariosActivosAsync()
        {
            return await dbContext.Usuarios
                .Include(u => u.Estado)
                .Where(u => u.Estado == true)
                .ToListAsync();
        }
    }
}
