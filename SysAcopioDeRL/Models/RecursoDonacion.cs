using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Models;

[Table("Recurso_Donacion")]
public partial class RecursoDonacion
{
    [Key]
    [Column("id_recurso_donacion")]
    public long IdRecursoDonacion { get; set; }

    [Column("id_donacion")]
    public long IdDonacion { get; set; }

    [Column("id_recurso")]
    public long IdRecurso { get; set; }

    [Column("cantidad")]
    public int Cantidad { get; set; }

    [ForeignKey("IdDonacion")]
    [InverseProperty("RecursoDonacions")]
    public virtual Donacion IdDonacionNavigation { get; set; } = null!;

    [ForeignKey("IdRecurso")]
    [InverseProperty("RecursoDonacions")]
    public virtual Recurso IdRecursoNavigation { get; set; } = null!;
}
