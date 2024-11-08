﻿using SysAcopioDeRL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>, IMetodosNOOC<Usuario>
    {
        Task<bool> CheckPassword(string password);
        Task<Usuario> GetByAliasAsync(string alias);
        Task<IEnumerable<Usuario>> GetByRolAsync(long idRol);
        Task<IEnumerable<Usuario>> GetUsuariosActivosAsync();
        Task<IEnumerable<Rol>> GetRolesAsync();
    }
}
