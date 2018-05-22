namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSalidasCab")]
    public partial class tblSalidaCab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSalidaCab()
        {
            tblSalidasDets = new HashSet<tblSalidaDet>();
        }

        [Key]
        public int idSalidaCab { get; set; }

        public int? idUsuario { get; set; }

        public int? idCaja { get; set; }

        public byte? Cuenta { get; set; }

        public int? idConcepto { get; set; }

        public bool? Devolucion { get; set; }

        public int? idSalidaDevuelta { get; set; }

        public int? NumeroTicket { get; set; }

        public DateTime? FechaTicket { get; set; }

        public int? idCliente { get; set; }

        public int? idDirCliente { get; set; }

        public int? NumeroFactura { get; set; }

        public int? idSerieFactura { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaFactura { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaVcto { get; set; }

        public int? idFormaPago { get; set; }

        public int? idCuenta { get; set; }

        [StringLength(256)]
        public string CopiaFactura { get; set; }

        [StringLength(1000)]
        public string Observaciones { get; set; }

        [StringLength(1000)]
        public string ObservInterna { get; set; }

        public bool? ImpresoTicket { get; set; }

        public bool? ImpresaFactura { get; set; }

        public bool? Cobrado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DescuentoPorciento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DescuentoValor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ImporteRecibido { get; set; }

        public DateTime? FechaCrea { get; set; }

        public DateTime? FechaModifica { get; set; }

        public virtual tblCaja tblCaja { get; set; }

        public virtual tblCliente tblCliente { get; set; }

        public virtual tblConcepto tblConcepto { get; set; }

        public virtual tblCuenta tblCuenta { get; set; }

        public virtual tblFormaPago tblFormasPago { get; set; }

        public virtual tblSerieFactura tblSeriesFactura { get; set; }

        public virtual tblUsuario tblUsuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalidaDet> tblSalidasDets { get; set; }
    }
}
