using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Usuario
{
    public class UsuarioDTO
    {
        public long IdUsuario { get; set; }
        public string AliasUsuario { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public long IdRol { get; set; }
        public bool Estado { get; set; }
    }   
}
