using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Proveedor
{
    public class UpdateProveedorDTO
    {
        public long IdProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public bool Estado { get; set; }
    }
}
