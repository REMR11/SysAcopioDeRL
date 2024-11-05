using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Entities;

[Table("Tipo_Recurso")]
public partial class TipoRecurso
{
    [Key]
    [Column("id_tipo_recurso")]
    public long IdTipoRecurso { get; set; }

    [Column("nombre_tipo")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreTipo { get; set; } = null!;

    [InverseProperty("IdTipoRecursoNavigation")]
    public virtual ICollection<Recurso> Recursos { get; } = new List<Recurso>();
}
