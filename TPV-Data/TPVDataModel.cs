using TPV_Data.Entities;
namespace TPV_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TPVDataModel : DbContext
    {
        public TPVDataModel()
            : base("name=TPVDataModel")
        {
        }

        public virtual DbSet<tblBanco> tblBancos { get; set; }
        public virtual DbSet<tblCaja> tblCajas { get; set; }
        public virtual DbSet<tblCliente> tblClientes { get; set; }
        public virtual DbSet<tblColumnaLibroGasto> tblColumnasLibroGastos { get; set; }
        public virtual DbSet<tblConcepto> tblConceptos { get; set; }
        public virtual DbSet<tblCuenta> tblCuentas { get; set; }
        public virtual DbSet<tblEmpresa> tblEmpresas { get; set; }
        public virtual DbSet<tblEntradaCab> tblEntradasCabs { get; set; }
        public virtual DbSet<tblEntradaDet> tblEntradasDets { get; set; }
        public virtual DbSet<tblFormaPago> tblFormasPagoes { get; set; }
        public virtual DbSet<tblGrupo> tblGrupos { get; set; }
        public virtual DbSet<tblPoblacion> tblPoblaciones { get; set; }
        public virtual DbSet<tblProducto> tblProductos { get; set; }
        public virtual DbSet<tblProveedo> tblProveedores { get; set; }
        public virtual DbSet<tblProvincia> tblProvincias { get; set; }
        public virtual DbSet<tblSalidaCab> tblSalidasCabs { get; set; }
        public virtual DbSet<tblSalidaDet> tblSalidasDets { get; set; }
        public virtual DbSet<tblSerieFactura> tblSeriesFacturas { get; set; }
        public virtual DbSet<tblSubgrupo> tblSubgrupos { get; set; }
        public virtual DbSet<tblTipoGrupo> tblTiposGrupos { get; set; }
        public virtual DbSet<tblUmedida> tblUmedidas { get; set; }
        public virtual DbSet<tblUsuario> tblUsuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblBanco>()
                .Property(e => e.DesBanco)
                .IsUnicode(false);

            modelBuilder.Entity<tblBanco>()
                .HasMany(e => e.tblCuentas)
                .WithRequired(e => e.tblBanco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.NumCaja)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.DesCaja)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraTickets)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraEtiquetas)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraFacturas)
                .IsUnicode(false);

            modelBuilder.Entity<tblCaja>()
                .Property(e => e.ImpresoraReportes)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.NombreCpomercial)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.NombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.NIF)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.FijoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.MovilCliente)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tblCliente>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<tblColumnaLibroGasto>()
                .Property(e => e.NombreColumna)
                .IsUnicode(false);

            modelBuilder.Entity<tblConcepto>()
                .Property(e => e.DesConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<tblCuenta>()
                .Property(e => e.DesCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tblCuenta>()
                .Property(e => e.NumCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.NIFEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.NomComercial)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DesEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DirEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.TelEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.CelEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.FaxEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.EmailEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.WebEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DirImagEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmpresa>()
                .Property(e => e.DirCopiaTickets)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradaCab>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradaCab>()
                .Property(e => e.CopiaFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradaCab>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tblEntradaCab>()
                .HasMany(e => e.tblEntradasDets)
                .WithOptional(e => e.tblEntradasCab)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblEntradaDet>()
                .Property(e => e.Cantidad)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblEntradaDet>()
                .Property(e => e.PrecioCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblEntradaDet>()
                .Property(e => e.IVAProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblEntradaDet>()
                .Property(e => e.IRPF)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tblEntradaDet>()
                .Property(e => e.DescuetoProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblEntradaDet>()
                .Property(e => e.ObservDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormaPago>()
                .Property(e => e.DesFormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<tblGrupo>()
                .Property(e => e.desGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<tblGrupo>()
                .Property(e => e.IVAGrupo)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblGrupo>()
                .Property(e => e.Margen)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblGrupo>()
                .HasMany(e => e.tblProductos)
                .WithRequired(e => e.tblGrupos)
                .HasForeignKey(e => e.idGrupo1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblGrupo>()
                .HasMany(e => e.tblProductos1)
                .WithOptional(e => e.tblGrupos1)
                .HasForeignKey(e => e.idGrupo2);

            modelBuilder.Entity<tblGrupo>()
                .HasMany(e => e.tblSubgrupos)
                .WithOptional(e => e.tblGrupos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblPoblacion>()
                .Property(e => e.poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblPoblacion>()
                .Property(e => e.postal)
                .IsUnicode(false);

            modelBuilder.Entity<tblPoblacion>()
                .HasMany(e => e.tblProveedores)
                .WithOptional(e => e.tblPoblacione)
                .HasForeignKey(e => e.IdPoblacion);

            modelBuilder.Entity<tblPoblacion>()
                .HasMany(e => e.tblProveedores1)
                .WithOptional(e => e.tblPoblacione1)
                .HasForeignKey(e => e.IdPobFiscal);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.eanProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.desProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.desProductoCorta)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.multiplicadorCompraAlmacen)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.multiplicadorAlmacenVenta)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.precioCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.precioVenta)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.X)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Y)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Z)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.StockMin)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.StockMax)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.FotoProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.ObservProducto)
                .IsUnicode(false);

            modelBuilder.Entity<tblProducto>()
                .Property(e => e.Inventario)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblProveedo>()
                .Property(e => e.DesProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProveedo>()
                .Property(e => e.DirProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProveedo>()
                .Property(e => e.DirFiscalProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProveedo>()
                .Property(e => e.WebProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblProvincia>()
                .Property(e => e.provincia)
                .IsUnicode(false);

            modelBuilder.Entity<tblProvincia>()
                .Property(e => e.provincia3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidaCab>()
                .Property(e => e.CopiaFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidaCab>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidaCab>()
                .Property(e => e.ObservInterna)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidaCab>()
                .Property(e => e.DescuentoPorciento)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSalidaCab>()
                .Property(e => e.DescuentoValor)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidaCab>()
                .Property(e => e.ImporteRecibido)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidaCab>()
                .HasMany(e => e.tblSalidasDets)
                .WithOptional(e => e.tblSalidasCab)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblSalidaDet>()
                .Property(e => e.ObservDetalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblSalidaDet>()
                .Property(e => e.Cantidad)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidaDet>()
                .Property(e => e.PrecioBaseVenta)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblSalidaDet>()
                .Property(e => e.PrecioBaseCosto)
                .HasPrecision(12, 6);

            modelBuilder.Entity<tblSalidaDet>()
                .Property(e => e.IVAProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSalidaDet>()
                .Property(e => e.DescuentoProducto)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSerieFactura>()
                .Property(e => e.NomSerieFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblSerieFactura>()
                .Property(e => e.DescSerieFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tblSerieFactura>()
                .HasOptional(e => e.tblSeriesFacturas1)
                .WithRequired(e => e.tblSeriesFactura1);

            modelBuilder.Entity<tblSubgrupo>()
                .Property(e => e.desSubgrupo)
                .IsUnicode(false);

            modelBuilder.Entity<tblSubgrupo>()
                .Property(e => e.Margen)
                .HasPrecision(4, 2);

            modelBuilder.Entity<tblSubgrupo>()
                .HasMany(e => e.tblProductos)
                .WithRequired(e => e.tblSubgrupos)
                .HasForeignKey(e => e.idSubgrupo1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSubgrupo>()
                .HasMany(e => e.tblProductos1)
                .WithOptional(e => e.tblSubgrupos1)
                .HasForeignKey(e => e.idSubgrupo2);

            modelBuilder.Entity<tblTipoGrupo>()
                .Property(e => e.DesTipoGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<tblTipoGrupo>()
                .HasMany(e => e.tblGrupos)
                .WithOptional(e => e.tblTiposGrupos)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tblTipoGrupo>()
                .HasMany(e => e.tblProductos)
                .WithOptional(e => e.tblTiposGrupos)
                .HasForeignKey(e => e.idTipoGrupo1);

            modelBuilder.Entity<tblUmedida>()
                .Property(e => e.codUmedida)
                .IsUnicode(false);

            modelBuilder.Entity<tblUmedida>()
                .Property(e => e.desUmedida)
                .IsUnicode(false);

            modelBuilder.Entity<tblUmedida>()
                .HasMany(e => e.tblProductos)
                .WithOptional(e => e.tblUmedida)
                .HasForeignKey(e => e.idUMAlmacen);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.NombreCompletoUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.ClaveUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsuario>()
                .Property(e => e.ConfiguracionUsuario)
                .IsUnicode(false);
        }
    }
}
