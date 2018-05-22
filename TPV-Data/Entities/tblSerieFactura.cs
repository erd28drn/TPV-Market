namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSerieFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSerieFactura()
        {
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        public int idSerieFactura { get; set; }

        [StringLength(3)]
        public string NomSerieFactura { get; set; }

        [StringLength(30)]
        public string DescSerieFactura { get; set; }

        public bool? Contabiliza { get; set; }

        public bool? Entrada { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }

        public virtual tblSerieFactura tblSeriesFacturas1 { get; set; }

        public virtual tblSerieFactura tblSeriesFactura1 { get; set; }
    }
}
