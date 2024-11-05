using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Recurso
{
    public class CreateRecursoDTO
    {
        public string NombreRecurso { get; set; } = null!;
        public int Cantidad { get; set; }
        public long IdTipoRecurso { get; set; }
    }
}
