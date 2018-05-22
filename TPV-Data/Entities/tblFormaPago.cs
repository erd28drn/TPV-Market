namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFormasPago")]
    public partial class tblFormaPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFormaPago()
        {
            tblEntradasCabs = new HashSet<tblEntradaCab>();
            tblProveedores = new HashSet<tblProveedo>();
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        public int IdFormaPago { get; set; }

        [Required]
        [StringLength(30)]
        public string DesFormaPago { get; set; }

        public bool? UsarEnCaja { get; set; }

        public bool? PredetCaja { get; set; }

        public bool? ActivaFormaPago { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImgActivo { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImgInactivo { get; set; }

        public bool? Efectivo { get; set; }

        public int? IdCuenta { get; set; }

        public bool? CtaEnFactura { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual tblCuenta tblCuenta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradaCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedo> tblProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }
    }
}
