namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblGrupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGrupo()
        {
            tblProductos = new HashSet<tblProducto>();
            tblProductos1 = new HashSet<tblProducto>();
            tblSubgrupos = new HashSet<tblSubgrupo>();
        }

        [Key]
        public int idGrupo { get; set; }

        public int? idTipoGrupo { get; set; }

        [StringLength(50)]
        public string desGrupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IVAGrupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Margen { get; set; }

        public bool? Venta { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual tblTipoGrupo tblTiposGrupos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubgrupo> tblSubgrupos { get; set; }
    }
}
