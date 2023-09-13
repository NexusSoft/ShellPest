namespace ShellPest
{
    partial class Frm_NombreComercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NombreComercial));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.glue_Empresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_codigo_eps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.dtgControl = new DevExpress.XtraGrid.GridControl();
            this.dtgValControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_codigo_pro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_nombre_pro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_codigo_uni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_intervaloseguridad_pro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_perentrada_pro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValControl)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bIconos});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblProveedor,
            this.btnSalir,
            this.btnSeleccionar});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 65;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeleccionar),
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.Caption = "Seleccionar";
            this.btnSeleccionar.Id = 64;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.LargeImage")));
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeleccionar_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(633, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(633, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(633, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
            // 
            // lblProveedor
            // 
            this.lblProveedor.Caption = "Ciudad:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.glue_Empresa);
            this.panelControl2.Controls.Add(this.labelControl18);
            this.panelControl2.Controls.Add(this.dtgControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(71, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.panelControl2.Size = new System.Drawing.Size(562, 500);
            this.panelControl2.TabIndex = 18;
            // 
            // glue_Empresa
            // 
            this.glue_Empresa.EditValue = "-Seleccionar-";
            this.glue_Empresa.Location = new System.Drawing.Point(62, 7);
            this.glue_Empresa.MenuManager = this.barManager1;
            this.glue_Empresa.Name = "glue_Empresa";
            this.glue_Empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Empresa.Properties.NullText = "-Seleccionar-";
            this.glue_Empresa.Properties.PopupView = this.gridView6;
            this.glue_Empresa.Size = new System.Drawing.Size(195, 20);
            this.glue_Empresa.TabIndex = 84;
            this.glue_Empresa.EditValueChanged += new System.EventHandler(this.glue_Empresa_EditValueChanged);
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_codigo_eps,
            this.gridColumn10,
            this.gridColumn34});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // c_codigo_eps
            // 
            this.c_codigo_eps.Caption = "c_codigo_eps";
            this.c_codigo_eps.FieldName = "c_codigo_eps";
            this.c_codigo_eps.Name = "c_codigo_eps";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Empresa";
            this.gridColumn10.FieldName = "v_nombre_eps";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "BD";
            this.gridColumn34.FieldName = "v_basedatos_coi";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 1;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(15, 10);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(45, 13);
            this.labelControl18.TabIndex = 83;
            this.labelControl18.Text = "Empresa:";
            // 
            // dtgControl
            // 
            this.dtgControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgControl.Location = new System.Drawing.Point(7, 32);
            this.dtgControl.MainView = this.dtgValControl;
            this.dtgControl.MenuManager = this.barManager1;
            this.dtgControl.Name = "dtgControl";
            this.dtgControl.Size = new System.Drawing.Size(548, 461);
            this.dtgControl.TabIndex = 0;
            this.dtgControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValControl});
            this.dtgControl.Click += new System.EventHandler(this.dtgControl_Click);
            this.dtgControl.DoubleClick += new System.EventHandler(this.dtgControl_DoubleClick);
            // 
            // dtgValControl
            // 
            this.dtgValControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_codigo_pro,
            this.v_nombre_pro,
            this.c_codigo_uni,
            this.v_intervaloseguridad_pro,
            this.v_perentrada_pro});
            this.dtgValControl.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dtgValControl.GridControl = this.dtgControl;
            this.dtgValControl.Name = "dtgValControl";
            this.dtgValControl.OptionsBehavior.Editable = false;
            this.dtgValControl.OptionsFind.AlwaysVisible = true;
            this.dtgValControl.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dtgValControl.OptionsView.ShowGroupPanel = false;
            // 
            // c_codigo_pro
            // 
            this.c_codigo_pro.Caption = "Id Nombre Comercial";
            this.c_codigo_pro.FieldName = "c_codigo_pro";
            this.c_codigo_pro.Name = "c_codigo_pro";
            this.c_codigo_pro.OptionsColumn.AllowEdit = false;
            this.c_codigo_pro.Visible = true;
            this.c_codigo_pro.VisibleIndex = 1;
            this.c_codigo_pro.Width = 77;
            // 
            // v_nombre_pro
            // 
            this.v_nombre_pro.Caption = "Nombre comercial";
            this.v_nombre_pro.FieldName = "v_nombre_pro";
            this.v_nombre_pro.Name = "v_nombre_pro";
            this.v_nombre_pro.Visible = true;
            this.v_nombre_pro.VisibleIndex = 0;
            this.v_nombre_pro.Width = 139;
            // 
            // c_codigo_uni
            // 
            this.c_codigo_uni.Caption = "Unidad";
            this.c_codigo_uni.FieldName = "c_codigo_uni";
            this.c_codigo_uni.Name = "c_codigo_uni";
            // 
            // v_intervaloseguridad_pro
            // 
            this.v_intervaloseguridad_pro.Caption = "Intervalo seguridad";
            this.v_intervaloseguridad_pro.FieldName = "v_intervaloseguridad_pro";
            this.v_intervaloseguridad_pro.Name = "v_intervaloseguridad_pro";
            this.v_intervaloseguridad_pro.Visible = true;
            this.v_intervaloseguridad_pro.VisibleIndex = 2;
            this.v_intervaloseguridad_pro.Width = 151;
            // 
            // v_perentrada_pro
            // 
            this.v_perentrada_pro.Caption = "Periodo entrada";
            this.v_perentrada_pro.FieldName = "v_perentrada_pro";
            this.v_perentrada_pro.Name = "v_perentrada_pro";
            this.v_perentrada_pro.Visible = true;
            this.v_perentrada_pro.VisibleIndex = 3;
            this.v_perentrada_pro.Width = 156;
            // 
            // Frm_NombreComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 500);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_NombreComercial";
            this.Text = "Frm_NombreComercial";
            this.Load += new System.EventHandler(this.Frm_NombreComercial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnSeleccionar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValControl;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_pro;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_pro;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_uni;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_eps;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraGrid.Columns.GridColumn v_intervaloseguridad_pro;
        private DevExpress.XtraGrid.Columns.GridColumn v_perentrada_pro;
    }
}