namespace ShellPest
{
    partial class Frm_ImportarEstacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImportarEstacion));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnBuscarServicios = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnExaminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnImportar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnParametros = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pgbProgreso = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.dtgEstacion = new DevExpress.XtraGrid.GridControl();
            this.dtgValEstacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TimeOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Rain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.OpenDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValEstacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bIconos,
            this.bEstado});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblProveedor,
            this.btnLimpiar,
            this.btnImportar,
            this.btnParametros,
            this.btnSalir,
            this.btnExaminar,
            this.btnBuscarServicios});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 80;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bEstado;
            // 
            // bIconos
            // 
            this.bIconos.BarName = "Menú principal";
            this.bIconos.DockCol = 0;
            this.bIconos.DockRow = 0;
            this.bIconos.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bIconos.FloatLocation = new System.Drawing.Point(42, 184);
            this.bIconos.FloatSize = new System.Drawing.Size(1106, 535);
            this.bIconos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLimpiar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBuscarServicios),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExaminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImportar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnParametros),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.bIconos.OptionsBar.AllowCollapse = true;
            this.bIconos.OptionsBar.AllowQuickCustomization = false;
            this.bIconos.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bIconos.OptionsBar.DisableClose = true;
            this.bIconos.OptionsBar.DisableCustomization = true;
            this.bIconos.OptionsBar.DrawBorder = false;
            this.bIconos.OptionsBar.DrawDragBorder = false;
            this.bIconos.OptionsBar.RotateWhenVertical = false;
            this.bIconos.OptionsBar.UseWholeRow = true;
            this.bIconos.Text = "Menú principal";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Caption = "Limpiar";
            this.btnLimpiar.Id = 50;
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.Image")));
            this.btnLimpiar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.LargeImage")));
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLimpiar_ItemClick);
            // 
            // btnBuscarServicios
            // 
            this.btnBuscarServicios.Caption = "  Buscar \r\nServicios";
            this.btnBuscarServicios.Id = 79;
            this.btnBuscarServicios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarServicios.ImageOptions.Image")));
            this.btnBuscarServicios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarServicios.ImageOptions.LargeImage")));
            this.btnBuscarServicios.Name = "btnBuscarServicios";
            this.btnBuscarServicios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscarServicios_ItemClick);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Caption = "Examinar";
            this.btnExaminar.Id = 67;
            this.btnExaminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExaminar.ImageOptions.Image")));
            this.btnExaminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExaminar.ImageOptions.LargeImage")));
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExaminar_ItemClick);
            // 
            // btnImportar
            // 
            this.btnImportar.Caption = "Importar";
            this.btnImportar.Id = 53;
            this.btnImportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.ImageOptions.Image")));
            this.btnImportar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImportar.ImageOptions.LargeImage")));
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportar_ItemClick);
            // 
            // btnParametros
            // 
            this.btnParametros.Caption = "Parametros";
            this.btnParametros.Id = 57;
            this.btnParametros.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParametros.ImageOptions.Image")));
            this.btnParametros.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnParametros.ImageOptions.LargeImage")));
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnParametros_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 63;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // bEstado
            // 
            this.bEstado.BarName = "Barra de estado";
            this.bEstado.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bEstado.DockCol = 0;
            this.bEstado.DockRow = 0;
            this.bEstado.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bEstado.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblProveedor)});
            this.bEstado.OptionsBar.AllowQuickCustomization = false;
            this.bEstado.OptionsBar.DrawDragBorder = false;
            this.bEstado.OptionsBar.UseWholeRow = true;
            this.bEstado.Text = "Barra de estado";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Caption = "Servicios de Corte:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1065, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1065, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(72, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1065, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pgbProgreso);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtRutaArchivo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(72, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 72);
            this.panelControl1.TabIndex = 4;
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Location = new System.Drawing.Point(111, 40);
            this.pgbProgreso.MenuManager = this.barManager1;
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Properties.ShowTitle = true;
            this.pgbProgreso.Size = new System.Drawing.Size(463, 18);
            this.pgbProgreso.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "% Importado";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Enabled = false;
            this.txtRutaArchivo.Location = new System.Drawing.Point(30, 14);
            this.txtRutaArchivo.MenuManager = this.barManager1;
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(544, 20);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.listBoxControl1);
            this.panelControl2.Controls.Add(this.dtgEstacion);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(72, 72);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(993, 449);
            this.panelControl2.TabIndex = 5;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(798, -66);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(120, 22);
            this.listBoxControl1.TabIndex = 8;
            // 
            // dtgEstacion
            // 
            this.dtgEstacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEstacion.Location = new System.Drawing.Point(7, 7);
            this.dtgEstacion.MainView = this.dtgValEstacion;
            this.dtgEstacion.MenuManager = this.barManager1;
            this.dtgEstacion.Name = "dtgEstacion";
            this.dtgEstacion.Size = new System.Drawing.Size(979, 435);
            this.dtgEstacion.TabIndex = 0;
            this.dtgEstacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValEstacion});
            // 
            // dtgValEstacion
            // 
            this.dtgValEstacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Fecha,
            this.col_TimeOut,
            this.col_ET,
            this.col_Rain,
            this.gridColumn2});
            this.dtgValEstacion.GridControl = this.dtgEstacion;
            this.dtgValEstacion.Name = "dtgValEstacion";
            this.dtgValEstacion.OptionsView.ShowFooter = true;
            this.dtgValEstacion.OptionsView.ShowGroupPanel = false;
            // 
            // col_Fecha
            // 
            this.col_Fecha.Caption = "Fecha";
            this.col_Fecha.FieldName = "F_Estacion";
            this.col_Fecha.Name = "col_Fecha";
            this.col_Fecha.OptionsColumn.AllowEdit = false;
            this.col_Fecha.Visible = true;
            this.col_Fecha.VisibleIndex = 0;
            // 
            // col_TimeOut
            // 
            this.col_TimeOut.Caption = "Temp_Out";
            this.col_TimeOut.FieldName = "Temp_Out_Estacion";
            this.col_TimeOut.Name = "col_TimeOut";
            this.col_TimeOut.OptionsColumn.AllowEdit = false;
            this.col_TimeOut.Visible = true;
            this.col_TimeOut.VisibleIndex = 2;
            // 
            // col_ET
            // 
            this.col_ET.Caption = "ET";
            this.col_ET.FieldName = "ET_Estacion";
            this.col_ET.Name = "col_ET";
            this.col_ET.OptionsColumn.AllowEdit = false;
            this.col_ET.Visible = true;
            this.col_ET.VisibleIndex = 3;
            // 
            // col_Rain
            // 
            this.col_Rain.Caption = "Rain";
            this.col_Rain.FieldName = "Rain_Estacion";
            this.col_Rain.Name = "col_Rain";
            this.col_Rain.OptionsColumn.AllowEdit = false;
            this.col_Rain.Visible = true;
            this.col_Rain.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Time";
            this.gridColumn2.FieldName = "T_Estacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "xtraOpenFileDialog1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Frm_ImportarEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 546);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_ImportarEstacion";
            this.Text = "Importar Estacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Frm_ImportarODC_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgbProgreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValEstacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnLimpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btnImportar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ProgressBarControl pgbProgreso;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private DevExpress.XtraBars.BarLargeButtonItem btnParametros;
        private DevExpress.XtraBars.BarLargeButtonItem btnExaminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController spreadsheetBarController1;
        private DevExpress.XtraEditors.XtraOpenFileDialog OpenDialog;
        private DevExpress.XtraGrid.GridControl dtgEstacion;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValEstacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn col_TimeOut;
        private DevExpress.XtraGrid.Columns.GridColumn col_ET;
        private DevExpress.XtraGrid.Columns.GridColumn col_Rain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarLargeButtonItem btnBuscarServicios;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}