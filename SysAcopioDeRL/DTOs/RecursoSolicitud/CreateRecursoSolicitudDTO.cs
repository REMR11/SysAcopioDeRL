﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAcopioDeRL.DTOs.RecursoSolicitud
{
    public class CreateRecursoSolicitudDTO
    {
        public long IdRecurso { get; set; }
        public long IdSolicitud { get; set; }
        public int Cantidad { get; set; }
    }
}
