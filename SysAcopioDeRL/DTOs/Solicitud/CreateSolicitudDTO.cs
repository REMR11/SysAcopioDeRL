using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Solicitud
{
    public class CreateSolicitudDTO
    {
        public string Ubicacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public string NombreSolicitante { get; set; } = null!;
        public byte Urgencia { get; set; }
        public string Motivo { get; set; } = null!;
    }
}
