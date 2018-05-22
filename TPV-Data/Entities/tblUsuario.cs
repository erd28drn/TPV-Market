namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuario()
        {
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(20)]
        public string NombreUsuario { get; set; }

        [StringLength(50)]
        public string NombreCompletoUsuario { get; set; }

        [StringLength(24)]
        public string ClaveUsuario { get; set; }

        public bool? AdminUsuario { get; set; }

        public bool? ActivoUsuario { get; set; }

        public string ConfiguracionUsuario { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }
    }
}
