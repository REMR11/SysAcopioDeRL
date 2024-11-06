using Microsoft.EntityFrameworkCore;
using SysAcopioDeRL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbacopioDeRlContext dbContext;
        protected readonly DbSet<T> dbSetEntity;

        public GenericRepository(DbacopioDeRlContext pContext)
        {
            dbContext = pContext;
            dbSetEntity = pContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity), "Registro no puede ser nulo.");

            try
            {
                await dbSetEntity.AddAsync(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException dbEx) { throw new Exception("Error al agregar el registro.", dbEx); }
            catch (Exception ex) { throw new Exception($"A ocurrido un error inesperado: {ex.Message}", ex); }
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await dbSetEntity.ToListAsync();
            }
            catch (Exception ex) { throw new Exception($"Error al obtener todos los registros: {ex.Message}"); }
        }

        public async Task<T> GetByIdAsync(long id)
        {
            try
            {
                var entity = await dbSetEntity.FindAsync(id);
                if (entity == null) throw new KeyNotFoundException($"Registro con el id {id} no encontrado");
                return entity;
            }
            catch (Exception ex) { throw new Exception($"Error obteniendo registro por id: {ex.Message}"); }
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            try
            {
                await dbSetEntity.AddAsync(entity);
                return await dbContext.SaveChangesAsync();
            }
            catch (Exception ex) { throw new Exception($"Error actualizando registros: {ex.Message}"); }
        }

        public async Task<int> DeleteAsync(long id)
        {
            try {
                var entity = await dbSetEntity.FindAsync(id);
                if (entity == null ) throw new KeyNotFoundException($"Registro con el id {id} no encontrado.");

                dbSetEntity.Remove(entity);
                return await dbContext.SaveChangesAsync();

            }
            catch(Exception ex) { throw new Exception($"Error eliminando el registro: {ex.Message}"); }
        }

        public Task<int> DeleteLogicAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
