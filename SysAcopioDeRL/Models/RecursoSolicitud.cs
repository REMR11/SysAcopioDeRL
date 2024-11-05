using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Models;

[Table("Recurso_Solicitud")]
public partial class RecursoSolicitud
{
    [Key]
    [Column("id_recurso_solicitud")]
    public long IdRecursoSolicitud { get; set; }

    [Column("id_recurso")]
    public long IdRecurso { get; set; }

    [Column("id_solicitud")]
    public long IdSolicitud { get; set; }

    [Column("cantidad")]
    public int Cantidad { get; set; }

    [ForeignKey("IdRecurso")]
    [InverseProperty("RecursoSolicituds")]
    public virtual Recurso IdRecursoNavigation { get; set; } = null!;

    [ForeignKey("IdSolicitud")]
    [InverseProperty("RecursoSolicituds")]
    public virtual Solicitud IdSolicitudNavigation { get; set; } = null!;
}
