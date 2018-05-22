namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCaja: tblGeneric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCaja()
        {
            tblEntradasCabs = new HashSet<tblEntradaCab>();
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        public int idCaja { get; set; }

        [StringLength(3)]
        public string NumCaja { get; set; }

        [StringLength(50)]
        public string DesCaja { get; set; }

        [StringLength(50)]
        public string ImpresoraTickets { get; set; }

        [StringLength(50)]
        public string ImpresoraEtiquetas { get; set; }

        [StringLength(50)]
        public string ImpresoraFacturas { get; set; }

        [StringLength(50)]
        public string ImpresoraReportes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntradaCab> tblEntradasCabs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }
    }
}
