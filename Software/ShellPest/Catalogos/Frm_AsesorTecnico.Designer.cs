namespace ShellPest
{
    partial class Frm_AsesorTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsesorTecnico));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.check_Activo = new DevExpress.XtraEditors.CheckEdit();
            this.dtgAsesor = new DevExpress.XtraGrid.GridControl();
            this.dtgValAsesor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_AsesorTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_AsesorTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Crea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.F_Usuario_Crea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Mod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.F_Usuario_Mod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.glue_Empresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_codigo_eps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_Activo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValAsesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
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
            this.btnLimpiar,
            this.btnGuardar,
            this.btnEliminar,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLimpiar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSeleccionar)});
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
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 53;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Inhabilitar";
            this.btnEliminar.Id = 57;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.Caption = "Seleccionar";
            this.btnSeleccionar.Id = 64;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.LargeImage")));
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeleccionar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(540, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(540, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(69, 416);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(540, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 416);
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
            this.panelControl2.Controls.Add(this.check_Activo);
            this.panelControl2.Controls.Add(this.dtgAsesor);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(69, 73);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.panelControl2.Size = new System.Drawing.Size(471, 343);
            this.panelControl2.TabIndex = 19;
            // 
            // check_Activo
            // 
            this.check_Activo.Location = new System.Drawing.Point(21, 1);
            this.check_Activo.MenuManager = this.barManager1;
            this.check_Activo.Name = "check_Activo";
            this.check_Activo.Properties.Caption = "Inactivos";
            this.check_Activo.Size = new System.Drawing.Size(75, 19);
            this.check_Activo.TabIndex = 1;
            this.check_Activo.CheckedChanged += new System.EventHandler(this.check_Activo_CheckedChanged);
            // 
            // dtgAsesor
            // 
            this.dtgAsesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAsesor.Location = new System.Drawing.Point(7, 22);
            this.dtgAsesor.MainView = this.dtgValAsesor;
            this.dtgAsesor.MenuManager = this.barManager1;
            this.dtgAsesor.Name = "dtgAsesor";
            this.dtgAsesor.Size = new System.Drawing.Size(457, 314);
            this.dtgAsesor.TabIndex = 0;
            this.dtgAsesor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValAsesor});
            this.dtgAsesor.Click += new System.EventHandler(this.dtgAsesor_Click);
            // 
            // dtgValAsesor
            // 
            this.dtgValAsesor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_AsesorTecnico,
            this.Nombre_AsesorTecnico,
            this.Id_Usuario_Crea,
            this.F_Usuario_Crea,
            this.Id_Usuario_Mod,
            this.F_Usuario_Mod});
            this.dtgValAsesor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dtgValAsesor.GridControl = this.dtgAsesor;
            this.dtgValAsesor.Name = "dtgValAsesor";
            this.dtgValAsesor.OptionsBehavior.Editable = false;
            this.dtgValAsesor.OptionsFind.AlwaysVisible = true;
            this.dtgValAsesor.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dtgValAsesor.OptionsView.ShowGroupPanel = false;
            // 
            // Id_AsesorTecnico
            // 
            this.Id_AsesorTecnico.Caption = "Id Asesor";
            this.Id_AsesorTecnico.FieldName = "Id_AsesorTecnico";
            this.Id_AsesorTecnico.Name = "Id_AsesorTecnico";
            this.Id_AsesorTecnico.OptionsColumn.AllowEdit = false;
            this.Id_AsesorTecnico.Visible = true;
            this.Id_AsesorTecnico.VisibleIndex = 0;
            // 
            // Nombre_AsesorTecnico
            // 
            this.Nombre_AsesorTecnico.Caption = "Asesor Tecnico";
            this.Nombre_AsesorTecnico.FieldName = "Nombre_AsesorTecnico";
            this.Nombre_AsesorTecnico.Name = "Nombre_AsesorTecnico";
            this.Nombre_AsesorTecnico.Visible = true;
            this.Nombre_AsesorTecnico.VisibleIndex = 1;
            // 
            // Id_Usuario_Crea
            // 
            this.Id_Usuario_Crea.Caption = "Id Creador";
            this.Id_Usuario_Crea.FieldName = "Id_Usuario_Crea";
            this.Id_Usuario_Crea.Name = "Id_Usuario_Crea";
            // 
            // F_Usuario_Crea
            // 
            this.F_Usuario_Crea.Caption = "F. Creación";
            this.F_Usuario_Crea.FieldName = "F_Usuario_Crea";
            this.F_Usuario_Crea.Name = "F_Usuario_Crea";
            // 
            // Id_Usuario_Mod
            // 
            this.Id_Usuario_Mod.Caption = "Id Modificador";
            this.Id_Usuario_Mod.FieldName = "Id_Usuario_Mod";
            this.Id_Usuario_Mod.Name = "Id_Usuario_Mod";
            // 
            // F_Usuario_Mod
            // 
            this.F_Usuario_Mod.Caption = "F. Modificación";
            this.F_Usuario_Mod.FieldName = "F_Usuario_Mod";
            this.F_Usuario_Mod.Name = "F_Usuario_Mod";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.glue_Empresa);
            this.panelControl1.Controls.Add(this.labelControl18);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtId);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(69, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(471, 73);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id Asesor: ";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(76, 12);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 26);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre \r\nAsesor:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 42);
            this.txtNombre.MenuManager = this.barManager1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // glue_Empresa
            // 
            this.glue_Empresa.EditValue = "-Seleccionar-";
            this.glue_Empresa.Location = new System.Drawing.Point(253, 12);
            this.glue_Empresa.MenuManager = this.barManager1;
            this.glue_Empresa.Name = "glue_Empresa";
            this.glue_Empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Empresa.Properties.NullText = "-Seleccionar-";
            this.glue_Empresa.Properties.PopupView = this.gridView6;
            this.glue_Empresa.Size = new System.Drawing.Size(195, 20);
            this.glue_Empresa.TabIndex = 48;
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
            this.labelControl18.Location = new System.Drawing.Point(206, 16);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(45, 13);
            this.labelControl18.TabIndex = 47;
            this.labelControl18.Text = "Empresa:";
            // 
            // Frm_AsesorTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 416);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_AsesorTecnico";
            this.Text = "Frm_AsesorTecnico";
            this.Load += new System.EventHandler(this.Frm_AsesorTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_Activo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValAsesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnLimpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btnGuardar;
        private DevExpress.XtraBars.BarLargeButtonItem btnEliminar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.BarLargeButtonItem btnSeleccionar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgAsesor;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValAsesor;
        private DevExpress.XtraGrid.Columns.GridColumn Id_AsesorTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_AsesorTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Crea;
        private DevExpress.XtraGrid.Columns.GridColumn F_Usuario_Crea;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Mod;
        private DevExpress.XtraGrid.Columns.GridColumn F_Usuario_Mod;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.CheckEdit check_Activo;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_eps;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraEditors.LabelControl labelControl18;
    }
}