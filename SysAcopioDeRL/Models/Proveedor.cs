using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Models;

[Table("Proveedor")]
public partial class Proveedor
{
    [Key]
    [Column("id_proveedor")]
    public long IdProveedor { get; set; }

    [Column("nombre_proveedor")]
    [StringLength(150)]
    [Unicode(false)]
    public string? NombreProveedor { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<Donacion> Donacions { get; } = new List<Donacion>();
}
