using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Usuario
{
    public class UpdateUsuarioDTO
    {
        public long IdUsuario { get; set; }
        public string AliasUsuario { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public long IdRol { get; set; }
        public bool Estado { get; set; }

        // Puedes incluir la contraseña si es necesario para la actualización
        // pero generalmente se recomienda manejarla de manera separada.
        public string? Contrasenia { get; set; }
    }
}
