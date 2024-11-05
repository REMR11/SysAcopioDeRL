using SysAcopioDeRL.DTOs.Recurso;
using SysAcopioDeRL.DTOs.Solicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.RecursoSolicitud
{
    public class RecursoSolicitudWithDetailsDTO
    {
        public long IdRecursoSolicitud { get; set; }

        public RecursoDTO Recurso { get; set; } = null!;

        public SolicitudDTO Solicitud { get; set; } = null!;

        public int Cantidad { get; set; }
    }
}
