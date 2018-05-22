namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSubgrupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSubgrupo()
        {
            tblProductos = new HashSet<tblProducto>();
            tblProductos1 = new HashSet<tblProducto>();
        }

        [Key]
        public int idSubgrupo { get; set; }

        public int? idGrupo { get; set; }

        [StringLength(50)]
        public string desSubgrupo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Margen { get; set; }

        public bool? Venta { get; set; }

        public bool? ControlaStock { get; set; }

        public int? idColumna { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual tblColumnaLibroGasto tblColumnasLibroGasto { get; set; }

        public virtual tblGrupo tblGrupos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProducto> tblProductos1 { get; set; }
    }
}
