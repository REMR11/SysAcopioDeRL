using SysAcopioDeRL.DTOs.Donaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Proveedor
{
    public class ProveedorWithDonacionesDTO
    {
        public long IdProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public bool Estado { get; set; }

        public List<DonacionDTO> Donaciones { get; set; } = new List<DonacionDTO>();
    }
}
