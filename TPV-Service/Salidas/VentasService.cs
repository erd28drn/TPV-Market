using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV_Data.Entities;
using TPV_Data;
using System.Data;
using System.Data.Entity;

namespace TPV_Service.Salidas
{
    public class VentasService
    {
        TPVDataModel modelo = new TPVDataModel();
        public decimal TotalPVP(int id)
        {
            return modelo.tblSalidasDets.Sum(v => v.Cantidad ?? 0 * v.PrecioBaseVenta ?? 0 * (1 + v.IVAProducto ?? 0 / 100));
        }
    }
}
