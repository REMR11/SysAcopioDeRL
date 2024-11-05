using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Entities;

[Table("Donacion")]
public partial class Donacion
{
    [Key]
    [Column("id_donacion")]
    public long IdDonacion { get; set; }

    [Column("id_proveedor")]
    public long IdProveedor { get; set; }

    [Column("ubicacion")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ubicacion { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [ForeignKey("IdProveedor")]
    [InverseProperty("Donaciones")]
    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    [InverseProperty("IdDonacionNavigation")]
    public virtual ICollection<RecursoDonacion> RecursoDonaciones { get; } = new List<RecursoDonacion>();
}
