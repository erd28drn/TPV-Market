namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblColumnasLibroGastos")]
    public partial class tblColumnaLibroGasto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblColumnaLibroGasto()
        {
            tblSubgrupos = new HashSet<tblSubgrupo>();
        }

        [Key]
        public int idColumna { get; set; }

        [StringLength(50)]
        public string NombreColumna { get; set; }

        public int? PosicionColumna { get; set; }

        public bool? Inversion { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubgrupo> tblSubgrupos { get; set; }
    }
}
