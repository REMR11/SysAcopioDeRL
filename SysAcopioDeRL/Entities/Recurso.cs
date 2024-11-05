using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Entities;

[Table("Recurso")]
public partial class Recurso
{
    [Key]
    [Column("id_recurso")]
    public long IdRecurso { get; set; }

    [Column("nombre_recurso")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreRecurso { get; set; } = null!;

    [Column("cantidad")]
    public int Cantidad { get; set; }

    [Column("id_tipo_recurso")]
    public long IdTipoRecurso { get; set; }

    [ForeignKey("IdTipoRecurso")]
    [InverseProperty("Recursos")]
    public virtual TipoRecurso IdTipoRecursoNavigation { get; set; } = null!;

    [InverseProperty("IdRecursoNavigation")]
    public virtual ICollection<RecursoDonacion> RecursoDonaciones { get; } = new List<RecursoDonacion>();

    [InverseProperty("IdRecursoNavigation")]
    public virtual ICollection<RecursoSolicitud> RecursoSolicitudes { get; } = new List<RecursoSolicitud>();
}
