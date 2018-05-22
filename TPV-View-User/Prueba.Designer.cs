namespace TPV_View_User
{
    partial class Prueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.tblCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCajaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCajaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblCajaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpresoraTickets = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpresoraEtiquetas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpresoraFacturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpresoraReportes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCrea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModifica = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCajaBindingNavigator)).BeginInit();
            this.tblCajaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCajaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCajaBindingSource
            // 
            this.tblCajaBindingSource.DataSource = typeof(TPV_Data.Entities.tblCaja);
            // 
            // tblCajaBindingNavigator
            // 
            this.tblCajaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCajaBindingNavigator.BindingSource = this.tblCajaBindingSource;
            this.tblCajaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCajaBindingNavigator.DeleteItem = null;
            this.tblCajaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblCajaBindingNavigatorSaveItem});
            this.tblCajaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCajaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCajaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCajaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCajaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCajaBindingNavigator.Name = "tblCajaBindingNavigator";
            this.tblCajaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCajaBindingNavigator.Size = new System.Drawing.Size(956, 25);
            this.tblCajaBindingNavigator.TabIndex = 0;
            this.tblCajaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblCajaBindingNavigatorSaveItem
            // 
            this.tblCajaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCajaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCajaBindingNavigatorSaveItem.Image")));
            this.tblCajaBindingNavigatorSaveItem.Name = "tblCajaBindingNavigatorSaveItem";
            this.tblCajaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblCajaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tblCajaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCajaBindingNavigatorSaveItem_Click);
            // 
            // tblCajaGridControl
            // 
            this.tblCajaGridControl.DataSource = this.tblCajaBindingSource;
            this.tblCajaGridControl.Location = new System.Drawing.Point(0, 55);
            this.tblCajaGridControl.MainView = this.gridView1;
            this.tblCajaGridControl.Name = "tblCajaGridControl";
            this.tblCajaGridControl.Size = new System.Drawing.Size(913, 301);
            this.tblCajaGridControl.TabIndex = 1;
            this.tblCajaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCaja,
            this.colNumCaja,
            this.colDesCaja,
            this.colImpresoraTickets,
            this.colImpresoraEtiquetas,
            this.colImpresoraFacturas,
            this.colImpresoraReportes,
            this.colFechaCrea,
            this.colFechaModifica});
            this.gridView1.GridControl = this.tblCajaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colidCaja
            // 
            this.colidCaja.FieldName = "idCaja";
            this.colidCaja.Name = "colidCaja";
            this.colidCaja.Visible = true;
            this.colidCaja.VisibleIndex = 0;
            // 
            // colNumCaja
            // 
            this.colNumCaja.FieldName = "NumCaja";
            this.colNumCaja.Name = "colNumCaja";
            this.colNumCaja.Visible = true;
            this.colNumCaja.VisibleIndex = 1;
            // 
            // colDesCaja
            // 
            this.colDesCaja.FieldName = "DesCaja";
            this.colDesCaja.Name = "colDesCaja";
            this.colDesCaja.Visible = true;
            this.colDesCaja.VisibleIndex = 2;
            // 
            // colImpresoraTickets
            // 
            this.colImpresoraTickets.FieldName = "ImpresoraTickets";
            this.colImpresoraTickets.Name = "colImpresoraTickets";
            this.colImpresoraTickets.Visible = true;
            this.colImpresoraTickets.VisibleIndex = 3;
            // 
            // colImpresoraEtiquetas
            // 
            this.colImpresoraEtiquetas.FieldName = "ImpresoraEtiquetas";
            this.colImpresoraEtiquetas.Name = "colImpresoraEtiquetas";
            this.colImpresoraEtiquetas.Visible = true;
            this.colImpresoraEtiquetas.VisibleIndex = 4;
            // 
            // colImpresoraFacturas
            // 
            this.colImpresoraFacturas.FieldName = "ImpresoraFacturas";
            this.colImpresoraFacturas.Name = "colImpresoraFacturas";
            this.colImpresoraFacturas.Visible = true;
            this.colImpresoraFacturas.VisibleIndex = 5;
            // 
            // colImpresoraReportes
            // 
            this.colImpresoraReportes.FieldName = "ImpresoraReportes";
            this.colImpresoraReportes.Name = "colImpresoraReportes";
            this.colImpresoraReportes.Visible = true;
            this.colImpresoraReportes.VisibleIndex = 6;
            // 
            // colFechaCrea
            // 
            this.colFechaCrea.FieldName = "FechaCrea";
            this.colFechaCrea.Name = "colFechaCrea";
            this.colFechaCrea.Visible = true;
            this.colFechaCrea.VisibleIndex = 7;
            // 
            // colFechaModifica
            // 
            this.colFechaModifica.FieldName = "FechaModifica";
            this.colFechaModifica.Name = "colFechaModifica";
            this.colFechaModifica.Visible = true;
            this.colFechaModifica.VisibleIndex = 8;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.tblCajaGridControl);
            this.Controls.Add(this.tblCajaBindingNavigator);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCajaBindingNavigator)).EndInit();
            this.tblCajaBindingNavigator.ResumeLayout(false);
            this.tblCajaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCajaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblCajaBindingSource;
        private System.Windows.Forms.BindingNavigator tblCajaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblCajaBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl tblCajaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colDesCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colImpresoraTickets;
        private DevExpress.XtraGrid.Columns.GridColumn colImpresoraEtiquetas;
        private DevExpress.XtraGrid.Columns.GridColumn colImpresoraFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colImpresoraReportes;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCrea;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModifica;
    }
}