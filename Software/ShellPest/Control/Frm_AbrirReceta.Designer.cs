namespace ShellPest
{
    partial class Frm_AbrirReceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AbrirReceta));
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
            this.dtgControl = new DevExpress.XtraGrid.GridControl();
            this.dtgValControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Activo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Id_Receta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Receta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_AsesorTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_AsesorTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_MonitoreoPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Cultivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Cultivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_TipoAplicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_TipoAplicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_abrevia_uni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Intervalo_Seguridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Intervalo_Reingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Crea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Mod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modificador = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(642, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 452);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(642, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 452);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(642, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
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
            this.panelControl2.Controls.Add(this.dtgControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(71, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(571, 452);
            this.panelControl2.TabIndex = 19;
            // 
            // dtgControl
            // 
            this.dtgControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgControl.Location = new System.Drawing.Point(12, 12);
            this.dtgControl.MainView = this.dtgValControl;
            this.dtgControl.MenuManager = this.barManager1;
            this.dtgControl.Name = "dtgControl";
            this.dtgControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtgControl.Size = new System.Drawing.Size(547, 428);
            this.dtgControl.TabIndex = 0;
            this.dtgControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValControl});
            this.dtgControl.Click += new System.EventHandler(this.dtgControl_Click);
            this.dtgControl.DoubleClick += new System.EventHandler(this.dtgControl_DoubleClick);
            // 
            // dtgValControl
            // 
            this.dtgValControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Activo,
            this.Id_Receta,
            this.Fecha_Receta,
            this.Id_AsesorTecnico,
            this.Nombre_AsesorTecnico,
            this.Id_MonitoreoPE,
            this.Id_Cultivo,
            this.Nombre_Cultivo,
            this.Id_TipoAplicacion,
            this.Nombre_TipoAplicacion,
            this.Id_Presentacion,
            this.Nombre_Presentacion,
            this.Id_Unidad,
            this.v_abrevia_uni,
            this.Observaciones,
            this.Intervalo_Seguridad,
            this.Intervalo_Reingreso,
            this.Id_Usuario_Crea,
            this.Creador,
            this.Id_Usuario_Mod,
            this.Modificador});
            this.dtgValControl.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dtgValControl.GridControl = this.dtgControl;
            this.dtgValControl.Name = "dtgValControl";
            this.dtgValControl.OptionsBehavior.Editable = false;
            this.dtgValControl.OptionsFind.AlwaysVisible = true;
            this.dtgValControl.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dtgValControl.OptionsView.ShowGroupPanel = false;
            // 
            // Activo
            // 
            this.Activo.Caption = "Activo";
            this.Activo.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Activo.FieldName = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.Visible = true;
            this.Activo.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Id_Receta
            // 
            this.Id_Receta.Caption = "Id";
            this.Id_Receta.FieldName = "Id_Receta";
            this.Id_Receta.Name = "Id_Receta";
            this.Id_Receta.Visible = true;
            this.Id_Receta.VisibleIndex = 1;
            // 
            // Fecha_Receta
            // 
            this.Fecha_Receta.Caption = "Fecha";
            this.Fecha_Receta.FieldName = "Fecha_Receta";
            this.Fecha_Receta.Name = "Fecha_Receta";
            this.Fecha_Receta.Visible = true;
            this.Fecha_Receta.VisibleIndex = 2;
            // 
            // Id_AsesorTecnico
            // 
            this.Id_AsesorTecnico.Caption = "Id_AsesorTecnico";
            this.Id_AsesorTecnico.FieldName = "Id_AsesorTecnico";
            this.Id_AsesorTecnico.Name = "Id_AsesorTecnico";
            // 
            // Nombre_AsesorTecnico
            // 
            this.Nombre_AsesorTecnico.Caption = "Asesor Tecnico";
            this.Nombre_AsesorTecnico.FieldName = "Nombre_AsesorTecnico";
            this.Nombre_AsesorTecnico.Name = "Nombre_AsesorTecnico";
            this.Nombre_AsesorTecnico.Visible = true;
            this.Nombre_AsesorTecnico.VisibleIndex = 3;
            // 
            // Id_MonitoreoPE
            // 
            this.Id_MonitoreoPE.Caption = "Id_MonitoreoPE";
            this.Id_MonitoreoPE.FieldName = "Id_MonitoreoPE";
            this.Id_MonitoreoPE.Name = "Id_MonitoreoPE";
            this.Id_MonitoreoPE.Visible = true;
            this.Id_MonitoreoPE.VisibleIndex = 4;
            // 
            // Id_Cultivo
            // 
            this.Id_Cultivo.Caption = "Id_Cultivo";
            this.Id_Cultivo.FieldName = "Id_Cultivo";
            this.Id_Cultivo.Name = "Id_Cultivo";
            // 
            // Nombre_Cultivo
            // 
            this.Nombre_Cultivo.Caption = "Cultivo";
            this.Nombre_Cultivo.FieldName = "Nombre_Cultivo";
            this.Nombre_Cultivo.Name = "Nombre_Cultivo";
            this.Nombre_Cultivo.Visible = true;
            this.Nombre_Cultivo.VisibleIndex = 5;
            // 
            // Id_TipoAplicacion
            // 
            this.Id_TipoAplicacion.Caption = "Id_TipoAplicacion";
            this.Id_TipoAplicacion.FieldName = "Id_TipoAplicacion";
            this.Id_TipoAplicacion.Name = "Id_TipoAplicacion";
            // 
            // Nombre_TipoAplicacion
            // 
            this.Nombre_TipoAplicacion.Caption = "Tipo de Aplicacion";
            this.Nombre_TipoAplicacion.FieldName = "Nombre_TipoAplicacion";
            this.Nombre_TipoAplicacion.Name = "Nombre_TipoAplicacion";
            this.Nombre_TipoAplicacion.Visible = true;
            this.Nombre_TipoAplicacion.VisibleIndex = 6;
            // 
            // Id_Presentacion
            // 
            this.Id_Presentacion.Caption = "Id_Presentacion";
            this.Id_Presentacion.FieldName = "Id_Presentacion";
            this.Id_Presentacion.Name = "Id_Presentacion";
            // 
            // Nombre_Presentacion
            // 
            this.Nombre_Presentacion.Caption = "Presentación";
            this.Nombre_Presentacion.FieldName = "Nombre_Presentacion";
            this.Nombre_Presentacion.Name = "Nombre_Presentacion";
            this.Nombre_Presentacion.Visible = true;
            this.Nombre_Presentacion.VisibleIndex = 7;
            // 
            // Id_Unidad
            // 
            this.Id_Unidad.Caption = "Id_Unidad";
            this.Id_Unidad.FieldName = "Id_Unidad";
            this.Id_Unidad.Name = "Id_Unidad";
            // 
            // v_abrevia_uni
            // 
            this.v_abrevia_uni.Caption = "Unidad";
            this.v_abrevia_uni.FieldName = "v_abrevia_uni";
            this.v_abrevia_uni.Name = "v_abrevia_uni";
            this.v_abrevia_uni.Visible = true;
            this.v_abrevia_uni.VisibleIndex = 8;
            // 
            // Observaciones
            // 
            this.Observaciones.Caption = "Observaciones";
            this.Observaciones.FieldName = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Visible = true;
            this.Observaciones.VisibleIndex = 9;
            // 
            // Intervalo_Seguridad
            // 
            this.Intervalo_Seguridad.Caption = "Intervalo_Seguridad";
            this.Intervalo_Seguridad.FieldName = "Intervalo_Seguridad";
            this.Intervalo_Seguridad.Name = "Intervalo_Seguridad";
            this.Intervalo_Seguridad.Visible = true;
            this.Intervalo_Seguridad.VisibleIndex = 10;
            // 
            // Intervalo_Reingreso
            // 
            this.Intervalo_Reingreso.Caption = "Intervalo_Reingreso";
            this.Intervalo_Reingreso.FieldName = "Intervalo_Reingreso";
            this.Intervalo_Reingreso.Name = "Intervalo_Reingreso";
            this.Intervalo_Reingreso.Visible = true;
            this.Intervalo_Reingreso.VisibleIndex = 11;
            // 
            // Id_Usuario_Crea
            // 
            this.Id_Usuario_Crea.Caption = "Id_Usuario_Crea";
            this.Id_Usuario_Crea.FieldName = "Id_Usuario_Crea";
            this.Id_Usuario_Crea.Name = "Id_Usuario_Crea";
            // 
            // Creador
            // 
            this.Creador.Caption = "Creador";
            this.Creador.FieldName = "Creador";
            this.Creador.Name = "Creador";
            // 
            // Id_Usuario_Mod
            // 
            this.Id_Usuario_Mod.Caption = "Id_Usuario_Mod";
            this.Id_Usuario_Mod.FieldName = "Id_Usuario_Mod";
            this.Id_Usuario_Mod.Name = "Id_Usuario_Mod";
            // 
            // Modificador
            // 
            this.Modificador.Caption = "Modificador";
            this.Modificador.FieldName = "Modificador";
            this.Modificador.Name = "Modificador";
            // 
            // Frm_AbrirReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 452);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_AbrirReceta";
            this.Text = "Frm_AbrirReceta";
            this.Load += new System.EventHandler(this.Frm_AbrirReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn Id_Receta;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Receta;
        private DevExpress.XtraGrid.Columns.GridColumn Id_AsesorTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_AsesorTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn Id_MonitoreoPE;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Cultivo;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Cultivo;
        private DevExpress.XtraGrid.Columns.GridColumn Id_TipoAplicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_TipoAplicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn Observaciones;
        private DevExpress.XtraGrid.Columns.GridColumn Intervalo_Seguridad;
        private DevExpress.XtraGrid.Columns.GridColumn Intervalo_Reingreso;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Crea;
        private DevExpress.XtraGrid.Columns.GridColumn Creador;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Mod;
        private DevExpress.XtraGrid.Columns.GridColumn Modificador;
        private DevExpress.XtraGrid.Columns.GridColumn v_abrevia_uni;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Unidad;
        private DevExpress.XtraGrid.Columns.GridColumn Activo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}