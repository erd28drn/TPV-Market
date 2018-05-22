namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPoblacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPoblacion()
        {
            tblClientes = new HashSet<tblCliente>();
            tblProveedores = new HashSet<tblProveedo>();
            tblProveedores1 = new HashSet<tblProveedo>();
        }

        [Key]
        public int IdPoblacion { get; set; }

        public int IdProvincia { get; set; }

        [Required]
        [StringLength(30)]
        public string poblacion { get; set; }

        [Required]
        [StringLength(5)]
        public string postal { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCliente> tblClientes { get; set; }

        public virtual tblProvincia tblProvincia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedo> tblProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProveedo> tblProveedores1 { get; set; }
    }
}
