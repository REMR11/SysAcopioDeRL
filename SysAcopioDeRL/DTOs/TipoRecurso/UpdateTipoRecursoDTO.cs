using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.TipoRecurso
{
    public class UpdateTipoRecursoDTO
    {
        public long IdTipoRecurso { get; set; }
        public string NombreTipo { get; set; } = null!;
    }
}
