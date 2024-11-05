using SysAcopioDeRL.DTOs.Donaciones;
using SysAcopioDeRL.DTOs.Recurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.RecursosDonaciones
{
    public class RecursoDonacionWithDetailsDTO
    {
        public long IdRecursoDonacion { get; set; }

        public DonacionDTO Donacion { get; set; } = null!;

        public RecursoDTO Recurso { get; set; } = null!;

        public int Cantidad { get; set; }
    }
}
