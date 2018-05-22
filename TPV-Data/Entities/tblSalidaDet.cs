namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSalidasDet")]
    public partial class tblSalidaDet: tblGeneric
    {
        [Key]
        public int IdSalidaDet { get; set; }

        public int? IdSalidaCab { get; set; }

        public int? IdProducto { get; set; }

        [StringLength(1000)]
        public string ObservDetalle { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? PrecioBaseVenta { get; set; }

        public decimal? PrecioBaseCosto { get; set; }

        public decimal? IVAProducto { get; set; }

        public decimal? DescuentoProducto { get; set; }

        public virtual tblProducto tblProducto { get; set; }

        public virtual tblSalidaCab tblSalidasCab { get; set; }
    }
}
