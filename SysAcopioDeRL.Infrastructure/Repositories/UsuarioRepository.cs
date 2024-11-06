using Microsoft.EntityFrameworkCore;
using SysAcopioDeRL.Entities;
using SysAcopioDeRL.Interfaces;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace SysAcopioDeRL.Infrastructure.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DbacopioDeRlContext pContext) : base(pContext) { }

        public Task<bool> CheckPassword(string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteLogicAsync(long id)
        {
            try 
            { 
                var entity = await GetByIdAsync(id);
                if(entity == null) return false;
                entity.Estado = false;
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }    
        }

        /// <summary>
        /// Metodo para obtener un usuario segun su alias
        /// </summary>
        /// <param name="alias"></param>
        /// <returns> usuario que coincida con el alias proporcionado</returns>
        public async Task<Usuario> GetByAliasAsync(string alias)
        {
            return await dbContext.Usuarios
                .Include(u => u.AliasUsuario)
                .FirstOrDefaultAsync(u => u.AliasUsuario == alias);
        }

        /// <summary>
        /// Metodo para obtener lista de usuarios segun su rol
        /// </summary>
        /// <param name="idRol"></param>
        /// <returns> Lista de Usuarios que coincidan con el rol pasado por parametro</returns>
        public async Task<IEnumerable<Usuario>> GetByRolAsync(long idRol)
        {
            return await dbContext.Usuarios
                .Include(u => u.IdRol)
                .Where(r => r.IdRol == idRol)
                .ToListAsync();
        }

        /// <summary>
        /// Metodo para obtener Usuarios activos en sistema
        /// </summary>
        /// <returns>Lista de usuarios activos</returns>
        public async Task<IEnumerable<Usuario>> GetUsuariosActivosAsync()
        {
            return await dbContext.Usuarios
                .Include(u => u.Estado)
                .Where(u => u.Estado == true)
                .ToListAsync();
        }
    }
}
