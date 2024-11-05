using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Models;

[Table("Rol")]
public partial class Rol
{
    [Key]
    [Column("id_rol")]
    public long IdRol { get; set; }

    [Column("nombre_rol")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreRol { get; set; } = null!;

    [InverseProperty("IdRolNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
