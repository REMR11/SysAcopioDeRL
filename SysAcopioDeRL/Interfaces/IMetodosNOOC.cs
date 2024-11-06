using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.Interfaces
{
    public interface IMetodosNOOC<T> where T : class
    {
        Task<bool> DeleteLogicAsync(long id);
    }
}
