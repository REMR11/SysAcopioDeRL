using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Models;

[Table("Usuario")]
[Index("AliasUsuario", Name = "UQ__Usuario__9A6188F521A688EE", IsUnique = true)]
public partial class Usuario
{
    [Key]
    [Column("id_usuario")]
    public long IdUsuario { get; set; }

    [Column("alias_usuario")]
    [StringLength(25)]
    [Unicode(false)]
    public string AliasUsuario { get; set; } = null!;

    [Column("nombre_usuario")]
    [StringLength(150)]
    [Unicode(false)]
    public string NombreUsuario { get; set; } = null!;

    [Column("contrasenia")]
    [StringLength(150)]
    public string Contrasenia { get; set; } = null!;

    [Column("id_rol")]
    public long IdRol { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    [ForeignKey("IdRol")]
    [InverseProperty("Usuarios")]
    public virtual Rol IdRolNavigation { get; set; } = null!;
}
