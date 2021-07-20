namespace ShellPest
{
    partial class Frm_Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Presentacion));
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
            this.dtgPresentacion = new DevExpress.XtraGrid.GridControl();
            this.dtgVal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_TipoAplicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_TipoAplicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Crea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Mod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.glue_Unidad = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_UnidadL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_UnidadL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Tipo = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.text_Tipo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_Activo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Unidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
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
            this.btnEliminar.Caption = "Eliminar";
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
            this.barDockControlTop.Size = new System.Drawing.Size(574, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(574, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(574, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
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
            this.panelControl2.Controls.Add(this.dtgPresentacion);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(71, 73);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.panelControl2.Size = new System.Drawing.Size(503, 388);
            this.panelControl2.TabIndex = 15;
            // 
            // check_Activo
            // 
            this.check_Activo.Location = new System.Drawing.Point(21, 3);
            this.check_Activo.MenuManager = this.barManager1;
            this.check_Activo.Name = "check_Activo";
            this.check_Activo.Properties.Caption = "Inactivos";
            this.check_Activo.Size = new System.Drawing.Size(75, 19);
            this.check_Activo.TabIndex = 2;
            // 
            // dtgPresentacion
            // 
            this.dtgPresentacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPresentacion.Location = new System.Drawing.Point(7, 22);
            this.dtgPresentacion.MainView = this.dtgVal;
            this.dtgPresentacion.MenuManager = this.barManager1;
            this.dtgPresentacion.Name = "dtgPresentacion";
            this.dtgPresentacion.Size = new System.Drawing.Size(489, 359);
            this.dtgPresentacion.TabIndex = 0;
            this.dtgPresentacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVal});
            this.dtgPresentacion.Click += new System.EventHandler(this.dtgPresentacion_Click);
            // 
            // dtgVal
            // 
            this.dtgVal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Presentacion,
            this.Nombre_Presentacion,
            this.Id_TipoAplicacion,
            this.Nombre_TipoAplicacion,
            this.Id_Unidad,
            this.Nombre_Unidad,
            this.Id_Usuario_Crea,
            this.Creador,
            this.Id_Usuario_Mod,
            this.Modificador});
            this.dtgVal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dtgVal.GridControl = this.dtgPresentacion;
            this.dtgVal.Name = "dtgVal";
            this.dtgVal.OptionsBehavior.Editable = false;
            this.dtgVal.OptionsFind.AlwaysVisible = true;
            this.dtgVal.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dtgVal.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Presentacion
            // 
            this.Id_Presentacion.Caption = "Id Presentacion";
            this.Id_Presentacion.FieldName = "Id_Presentacion";
            this.Id_Presentacion.Name = "Id_Presentacion";
            this.Id_Presentacion.OptionsColumn.AllowEdit = false;
            this.Id_Presentacion.Visible = true;
            this.Id_Presentacion.VisibleIndex = 0;
            // 
            // Nombre_Presentacion
            // 
            this.Nombre_Presentacion.Caption = "Presentacion";
            this.Nombre_Presentacion.FieldName = "Nombre_Presentacion";
            this.Nombre_Presentacion.Name = "Nombre_Presentacion";
            this.Nombre_Presentacion.Visible = true;
            this.Nombre_Presentacion.VisibleIndex = 1;
            // 
            // Id_TipoAplicacion
            // 
            this.Id_TipoAplicacion.Caption = "Id_TipoAplicacion";
            this.Id_TipoAplicacion.FieldName = "Id_TipoAplicacion";
            this.Id_TipoAplicacion.Name = "Id_TipoAplicacion";
            // 
            // Nombre_TipoAplicacion
            // 
            this.Nombre_TipoAplicacion.Caption = "Tipo Aplicacion";
            this.Nombre_TipoAplicacion.FieldName = "Nombre_TipoAplicacion";
            this.Nombre_TipoAplicacion.Name = "Nombre_TipoAplicacion";
            this.Nombre_TipoAplicacion.Visible = true;
            this.Nombre_TipoAplicacion.VisibleIndex = 3;
            // 
            // Id_Unidad
            // 
            this.Id_Unidad.Caption = "Id Unidad";
            this.Id_Unidad.FieldName = "Id_Unidad";
            this.Id_Unidad.Name = "Id_Unidad";
            // 
            // Nombre_Unidad
            // 
            this.Nombre_Unidad.Caption = "Unidad";
            this.Nombre_Unidad.FieldName = "Nombre_Unidad";
            this.Nombre_Unidad.Name = "Nombre_Unidad";
            this.Nombre_Unidad.Visible = true;
            this.Nombre_Unidad.VisibleIndex = 2;
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
            this.Id_Usuario_Mod.Caption = "Id Modificador";
            this.Id_Usuario_Mod.FieldName = "Id_Usuario_Mod";
            this.Id_Usuario_Mod.Name = "Id_Usuario_Mod";
            // 
            // Modificador
            // 
            this.Modificador.Caption = "Modificador";
            this.Modificador.FieldName = "Modificador";
            this.Modificador.Name = "Modificador";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.glue_Unidad);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Tipo);
            this.panelControl1.Controls.Add(this.txtId);
            this.panelControl1.Controls.Add(this.text_Tipo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtNombre);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(71, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(503, 73);
            this.panelControl1.TabIndex = 14;
            // 
            // glue_Unidad
            // 
            this.glue_Unidad.EditValue = "-Seleccionar-";
            this.glue_Unidad.Location = new System.Drawing.Point(291, 42);
            this.glue_Unidad.MenuManager = this.barManager1;
            this.glue_Unidad.Name = "glue_Unidad";
            this.glue_Unidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Unidad.Properties.NullText = "-Seleccionar-";
            this.glue_Unidad.Properties.PopupView = this.gridView2;
            this.glue_Unidad.Size = new System.Drawing.Size(163, 20);
            this.glue_Unidad.TabIndex = 52;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_UnidadL,
            this.Nombre_UnidadL});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Id_UnidadL
            // 
            this.Id_UnidadL.Caption = "Id Unidad";
            this.Id_UnidadL.FieldName = "Id_Unidad";
            this.Id_UnidadL.Name = "Id_UnidadL";
            this.Id_UnidadL.Visible = true;
            this.Id_UnidadL.VisibleIndex = 0;
            // 
            // Nombre_UnidadL
            // 
            this.Nombre_UnidadL.Caption = "Unidad";
            this.Nombre_UnidadL.FieldName = "Nombre_Unidad";
            this.Nombre_UnidadL.Name = "Nombre_UnidadL";
            this.Nombre_UnidadL.Visible = true;
            this.Nombre_UnidadL.VisibleIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(248, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Unidad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id Presentación: ";
            // 
            // btn_Tipo
            // 
            this.btn_Tipo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tipo.ImageOptions.Image")));
            this.btn_Tipo.Location = new System.Drawing.Point(430, 9);
            this.btn_Tipo.Name = "btn_Tipo";
            this.btn_Tipo.Size = new System.Drawing.Size(24, 23);
            this.btn_Tipo.TabIndex = 32;
            this.btn_Tipo.Click += new System.EventHandler(this.btn_Tipo_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(104, 12);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // text_Tipo
            // 
            this.text_Tipo.Enabled = false;
            this.text_Tipo.Location = new System.Drawing.Point(324, 11);
            this.text_Tipo.MenuManager = this.barManager1;
            this.text_Tipo.Name = "text_Tipo";
            this.text_Tipo.Size = new System.Drawing.Size(102, 20);
            this.text_Tipo.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Presentación:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(248, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tipo Aplicación:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 42);
            this.txtNombre.MenuManager = this.barManager1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // Frm_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 461);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Presentacion";
            this.Text = "Presentación";
            this.Load += new System.EventHandler(this.Frm_Presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_Activo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Unidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVal;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn Id_TipoAplicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_TipoAplicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Crea;
        private DevExpress.XtraGrid.Columns.GridColumn Creador;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Mod;
        private DevExpress.XtraGrid.Columns.GridColumn Modificador;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit text_Tipo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_Tipo;
        private DevExpress.XtraEditors.CheckEdit check_Activo;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Unidad;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Unidad;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Unidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Id_UnidadL;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_UnidadL;
    }
}