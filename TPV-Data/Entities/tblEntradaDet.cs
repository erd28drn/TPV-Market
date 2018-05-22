namespace TPV_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEntradasDet")]
    public partial class tblEntradaDet: tblGeneric
    {
        [Key]
        public int idEntradaDet { get; set; }

        public int? idEntradaCab { get; set; }

        public int? idProducto { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? PrecioCosto { get; set; }

        public decimal? IVAProducto { get; set; }

        public decimal? IRPF { get; set; }

        public decimal? DescuetoProducto { get; set; }

        [StringLength(1000)]
        public string ObservDetalle { get; set; }

        public virtual tblEntradaCab tblEntradasCab { get; set; }

        public virtual tblProducto tblProducto { get; set; }
    }
}
