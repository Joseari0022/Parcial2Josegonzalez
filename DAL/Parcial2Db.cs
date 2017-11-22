using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace DAL
{
    public class Parcial2Db : DbContext
    {
        public Parcial2Db() : base("ConStr")
        {
                
        }

        public virtual DbSet<Presupuestos> Presupuesto { get; set; }
        public virtual DbSet<PresupuestoDetalle> PresupuestoDetalle { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Productos>()
        //        .HasMany(p => p.facturaList)
        //        .WithMany(f => f.ProductoLista)
        //        .Map(empleadoRetencion =>
        //        {
        //            empleadoRetencion.MapLeftKey("ProductoId");
        //            empleadoRetencion.MapRightKey("FacturaId");
        //            empleadoRetencion.ToTable("FacturasProductos");
        //        });
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Facturas>()
        //        .HasMany<Productos>(g => g.producto)
        //        .WithMany(e => e.Factura)
        //        .Map(ge =>
        //        {
        //            ge.MapLeftKey("ProductoId");
        //            ge.MapRightKey("FacturaId");
        //            ge.ToTable("ProductoFactura");
        //        });
        //}
    }
}
