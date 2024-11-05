using SysAcopioDeRL.DTOs.Recurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.TipoRecurso
{
    public class TipoRecursoWithRecursosDTO
    {
        public long IdTipoRecurso { get; set; }
        public string NombreTipo { get; set; } = null!;

        public List<RecursoDTO> Recursos { get; set; } = new List<RecursoDTO>();
    }
}
