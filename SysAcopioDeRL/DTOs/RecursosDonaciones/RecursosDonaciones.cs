using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.RecursosDonaciones
{
    public class RecursoDonacionDTO
    {
        public long IdRecursoDonacion { get; set; }
        public long IdDonacion { get; set; }
        public long IdRecurso { get; set; }
        public int Cantidad { get; set; }
    }
}
