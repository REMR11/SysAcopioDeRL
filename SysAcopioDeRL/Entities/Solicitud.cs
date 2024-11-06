using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Entities;

[Table("Solicitud")]
public partial class Solicitud
{
    [Key]
    [Column("id_solicitud")]
    public long IdSolicitud { get; set; }

    [Column("ubicacion")]
    [StringLength(150)]
    [Unicode(false)]
    public string Ubicacion { get; set; } = null!;

    [Column("fecha", TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    [Column("nombre_solicitante")]
    [StringLength(150)]
    [Unicode(false)]
    public string NombreSolicitante { get; set; } = null!;

    [Column("urgencia")]
    public byte Urgencia { get; set; }

    [Column("motivo")]
    [StringLength(300)]
    [Unicode(false)]
    public string Motivo { get; set; } = null!;

    [InverseProperty("IdSolicitudNavigation")]
    public virtual ICollection<RecursoSolicitud> RecursoSolicitudes { get; } = new List<RecursoSolicitud>();
}
