namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblConceptos")]
    public partial class tblConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblConcepto()
        {
            tblEntradasCabs = new HashSet<tblEntradaCab>();
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        public int idConcepto { get; set; }

        [StringLength(50)]
        public string DesConcepto { get; set; }

        public bool? Entrada { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradaCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }
    }
}
