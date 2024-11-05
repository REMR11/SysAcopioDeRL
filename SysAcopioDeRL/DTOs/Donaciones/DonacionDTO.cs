using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.Donaciones
{
    public class DonacionDTO
    {
        public long IdDonacion { get; set; }
        public long IdProveedor { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
