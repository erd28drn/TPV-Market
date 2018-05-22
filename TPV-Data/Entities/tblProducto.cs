namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductos")]
    public partial class tblProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProducto()
        {
            tblEntradasDets = new HashSet<tblEntradaDet>();
            tblSalidasDets = new HashSet<tblSalidaDet>();
        }

        [Key]
        public int idProducto { get; set; }

        [StringLength(20)]
        public string eanProducto { get; set; }

        [StringLength(13)]
        public string codProducto { get; set; }

        [Required]
        [StringLength(100)]
        public string desProducto { get; set; }

        [Required]
        [StringLength(25)]
        public string desProductoCorta { get; set; }

        public int? idUMCompra { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? multiplicadorCompraAlmacen { get; set; }

        public int? idUMAlmacen { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? multiplicadorAlmacenVenta { get; set; }

        public int? idUMVenta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? precioCosto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? precioVenta { get; set; }

        public int? idTipoGrupo1 { get; set; }

        public int idGrupo1 { get; set; }

        public int idSubgrupo1 { get; set; }

        public int? idGrupo2 { get; set; }

        public int? idSubgrupo2 { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [StringLength(50)]
        public string Ubicacion { get; set; }

        [StringLength(10)]
        public string X { get; set; }

        [StringLength(10)]
        public string Y { get; set; }

        [StringLength(10)]
        public string Z { get; set; }

        public bool? VentaOnline { get; set; }

        public bool? ActivoProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StockMin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StockMax { get; set; }

        [StringLength(256)]
        public string FotoProducto { get; set; }

        [StringLength(1000)]
        public string ObservProducto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Inventario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradaDet> tblEntradasDets { get; set; }

        public virtual tblGrupo tblGrupos { get; set; }

        public virtual tblGrupo tblGrupos1 { get; set; }

        public virtual tblSubgrupo tblSubgrupos { get; set; }

        public virtual tblSubgrupo tblSubgrupos1 { get; set; }

        public virtual tblTipoGrupo tblTiposGrupos { get; set; }

        public virtual tblUmedida tblUmedida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaDet> tblSalidasDets { get; set; }
    }
}
