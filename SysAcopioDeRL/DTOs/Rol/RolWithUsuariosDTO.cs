using SysAcopioDeRL.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Rol
{
    public class RolWithUsuariosDTO
    {
        public long IdRol { get; set; }
        public string NombreRol { get; set; } = null!;

        public List<UsuarioDTO> Usuarios { get; set; } = new List<UsuarioDTO>();
    }
}
