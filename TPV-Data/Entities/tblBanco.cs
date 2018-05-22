namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBancos")]
    public partial class tblBanco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBanco()
        {
            tblCuentas = new HashSet<tblCuenta>();
        }

        [Key]
        public int IdBanco { get; set; }

        [Required]
        [StringLength(50)]
        public string DesBanco { get; set; }

        public bool? ActivoBanco { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCuenta> tblCuentas { get; set; }
    }
}
