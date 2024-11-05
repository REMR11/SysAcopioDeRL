using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Entities;

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
    public virtual ICollection<Donacion> Donaciones { get; } = new List<Donacion>();
}

/*
  // Crear un objeto DataTable para almacenar los resultados
 DataTable resultados = new DataTable();

 // Instancia de la clase de conexión
 cConexion conectar = new cConexion();
 SqlConnection conn = conectar.ConexionServer();

 // Crear un comando SQL
 SqlCommand cmd = new SqlCommand(sql, conn);

 // Agregar los parámetros a la consulta
 if (parametros != null)
 {
     foreach (SqlParameter parametro in parametros)
     {
         cmd.Parameters.Add(parametro);
     }
 }

 SqlDataReader mydr = null;
 try
 {
     conn.Open();
     mydr = cmd.ExecuteReader();

     // Cargar los resultados en el DataTable
     resultados.Load(mydr);
Contraer
tiene menú contextual 

 */
