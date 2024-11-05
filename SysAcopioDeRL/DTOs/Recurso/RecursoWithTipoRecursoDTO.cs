using SysAcopioDeRL.DTOs.TipoRecurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Recurso
{
    public class RecursoWithTipoRecursoDTO
    {
        public long IdRecurso { get; set; }
        public string NombreRecurso { get; set; } = null!;
        public int Cantidad { get; set; }

        public TipoRecursoDTO TipoRecurso { get; set; } = null!;
    }
}
