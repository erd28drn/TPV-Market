namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCuenta()
        {
            tblEntradasCabs = new HashSet<tblEntradaCab>();
            tblFormasPagoes = new HashSet<tblFormaPago>();
            tblProveedores = new HashSet<tblProveedo>();
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        public int IdCuenta { get; set; }

        [StringLength(50)]
        public string DesCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string NumCuenta { get; set; }

        public int IdBanco { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual tblBanco tblBanco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradaCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFormaPago> tblFormasPagoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedo> tblProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }
    }
}
