using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV_Data;
using TPV_Data.Entities;

namespace TPV_Data.Repository
{
    public class tblCajaRepository
    {
        TPVDataModel modelo = new TPVDataModel();
        public tblCaja GetCaja (int id)
        {
            return modelo.tblCajas.FirstOrDefault(c => c.idCaja == id);
        }
        public List<tblCaja> GetCajas()
        {
            return modelo.tblCajas.ToList();
        }

        public tblCaja UpdateInsertCaja(tblCaja caja)
        {
            caja.FechaModifica = DateTime.Now;
            caja.FechaCrea = caja.FechaCrea ?? DateTime.Now;
            tblCaja cajaEntity = GetCaja(caja.idCaja);
            if (cajaEntity != null)
            {
                cajaEntity = caja;
            }
            else
            {
                modelo.tblCajas.Add(caja);
            }
            modelo.SaveChanges();
            return GetCaja(caja.idCaja);
        }

        public bool RemoveCajas (List<int> ids)
        {
            var cajas= modelo.tblCajas.Where(c => ids.Contains(c.idCaja));
            modelo.tblCajas.RemoveRange(cajas);
            return true;
        }
    }
}
