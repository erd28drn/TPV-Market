namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCliente()
        {
            tblSalidasCabs = new HashSet<tblSalidaCab>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCliente { get; set; }

        [StringLength(100)]
        public string NombreCpomercial { get; set; }

        [StringLength(100)]
        public string NombreFiscal { get; set; }

        [StringLength(15)]
        public string NIF { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        public int? idPoblacion { get; set; }

        [StringLength(20)]
        public string FijoCliente { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string MovilCliente { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual tblPoblacion tblPoblacione { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaCab> tblSalidasCabs { get; set; }
    }
}
