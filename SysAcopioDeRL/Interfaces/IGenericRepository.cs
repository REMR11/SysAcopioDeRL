using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(long id);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(long id);
        Task<int> DeleteLogicAsync(long id);
    }
}
