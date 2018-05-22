using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPV_Data.Entities;
using TPV_Data.Repository;

namespace TPV_View_User
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        tblCaja cajaSeleccionada = null;
        List<tblCaja> cajas = null;
        tblCajaRepository cajaRepository = new tblCajaRepository();
        int idCaja = 0;
        List<int> idsCaja = new List<int>();


        private void Prueba_Load(object sender, EventArgs e)
        {
            cajas = cajaRepository.GetCajas();
            tblCajaBindingSource.DataSource = cajas;
        }

        private void tblCajaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            tblCajaBindingSource.EndEdit();
            cajaRepository.UpdateInsertCaja(cajaSeleccionada);
            cajaRepository.RemoveCajas(idsCaja);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            idCaja = (int)gridView1.GetFocusedRowCellValue(colidCaja);
            cajaSeleccionada = cajas.FirstOrDefault(c=> c.idCaja== idCaja);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            idsCaja.Add(idCaja);
            tblCajaBindingSource.RemoveCurrent();
        }
    }
}
