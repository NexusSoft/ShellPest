namespace ShellPest
{
    partial class Frm_PuntoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PuntoControl));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtgPuntoControl = new DevExpress.XtraGrid.GridControl();
            this.dtgValPuntoControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Puntocontrol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Puntocontrol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Bloque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Bloque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.n_coordenadaX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.n_coordenadaY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Huerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Bloque = new DevExpress.XtraEditors.SimpleButton();
            this.txtBloque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtY = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtX = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPuntoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValPuntoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBloque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
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
            this.btnGuardar,
            this.btnEliminar,
            this.btnSalir,
            this.btnSeleccionar});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 67;
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
            this.btnSeleccionar.Id = 66;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.LargeImage")));
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeleccionar_ItemClick);
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
            this.lblProveedor.Caption = "Proveedor:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(923, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 457);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(923, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(69, 457);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(923, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 457);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtgPuntoControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(69, 167);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(854, 290);
            this.panelControl2.TabIndex = 19;
            // 
            // dtgPuntoControl
            // 
            this.dtgPuntoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPuntoControl.Location = new System.Drawing.Point(12, 12);
            this.dtgPuntoControl.MainView = this.dtgValPuntoControl;
            this.dtgPuntoControl.MenuManager = this.barManager1;
            this.dtgPuntoControl.Name = "dtgPuntoControl";
            this.dtgPuntoControl.Size = new System.Drawing.Size(830, 266);
            this.dtgPuntoControl.TabIndex = 0;
            this.dtgPuntoControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValPuntoControl});
            this.dtgPuntoControl.Click += new System.EventHandler(this.dtgPuntoControl_Click);
            // 
            // dtgValPuntoControl
            // 
            this.dtgValPuntoControl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Puntocontrol,
            this.Nombre_Puntocontrol,
            this.Id_Bloque,
            this.Nombre_Bloque,
            this.n_coordenadaX,
            this.n_coordenadaY,
            this.Id_Huerta,
            this.Nombre_Huerta});
            this.dtgValPuntoControl.GridControl = this.dtgPuntoControl;
            this.dtgValPuntoControl.Name = "dtgValPuntoControl";
            this.dtgValPuntoControl.OptionsBehavior.Editable = false;
            this.dtgValPuntoControl.OptionsView.ShowGroupPanel = false;
            // 
            // Id_Puntocontrol
            // 
            this.Id_Puntocontrol.Caption = "Id Punto";
            this.Id_Puntocontrol.FieldName = "Id_Puntocontrol";
            this.Id_Puntocontrol.Name = "Id_Puntocontrol";
            this.Id_Puntocontrol.Visible = true;
            this.Id_Puntocontrol.VisibleIndex = 0;
            // 
            // Nombre_Puntocontrol
            // 
            this.Nombre_Puntocontrol.Caption = "Punto";
            this.Nombre_Puntocontrol.FieldName = "Nombre_Puntocontrol";
            this.Nombre_Puntocontrol.Name = "Nombre_Puntocontrol";
            this.Nombre_Puntocontrol.Visible = true;
            this.Nombre_Puntocontrol.VisibleIndex = 1;
            // 
            // Id_Bloque
            // 
            this.Id_Bloque.Caption = "Id_Bloque";
            this.Id_Bloque.FieldName = "Id_Bloque";
            this.Id_Bloque.Name = "Id_Bloque";
            this.Id_Bloque.Visible = true;
            this.Id_Bloque.VisibleIndex = 2;
            // 
            // Nombre_Bloque
            // 
            this.Nombre_Bloque.Caption = "Bloque";
            this.Nombre_Bloque.FieldName = "Nombre_Bloque";
            this.Nombre_Bloque.Name = "Nombre_Bloque";
            this.Nombre_Bloque.Visible = true;
            this.Nombre_Bloque.VisibleIndex = 3;
            // 
            // n_coordenadaX
            // 
            this.n_coordenadaX.Caption = "Cord. X";
            this.n_coordenadaX.FieldName = "n_coordenadaX";
            this.n_coordenadaX.Name = "n_coordenadaX";
            this.n_coordenadaX.Visible = true;
            this.n_coordenadaX.VisibleIndex = 4;
            // 
            // n_coordenadaY
            // 
            this.n_coordenadaY.Caption = "Cord. Y";
            this.n_coordenadaY.FieldName = "n_coordenadaY";
            this.n_coordenadaY.Name = "n_coordenadaY";
            this.n_coordenadaY.Visible = true;
            this.n_coordenadaY.VisibleIndex = 5;
            // 
            // Id_Huerta
            // 
            this.Id_Huerta.Caption = "Id_Huerta";
            this.Id_Huerta.FieldName = "Id_Huerta";
            this.Id_Huerta.Name = "Id_Huerta";
            this.Id_Huerta.Visible = true;
            this.Id_Huerta.VisibleIndex = 6;
            // 
            // Nombre_Huerta
            // 
            this.Nombre_Huerta.Caption = "Huerta";
            this.Nombre_Huerta.FieldName = "Nombre_Huerta";
            this.Nombre_Huerta.Name = "Nombre_Huerta";
            this.Nombre_Huerta.Visible = true;
            this.Nombre_Huerta.VisibleIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(69, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(854, 167);
            this.panelControl1.TabIndex = 18;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Bloque);
            this.groupControl1.Controls.Add(this.txtBloque);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtY);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtX);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textNombre);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(830, 143);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Punto de control";
            // 
            // btn_Bloque
            // 
            this.btn_Bloque.Location = new System.Drawing.Point(62, 79);
            this.btn_Bloque.Name = "btn_Bloque";
            this.btn_Bloque.Size = new System.Drawing.Size(28, 23);
            this.btn_Bloque.TabIndex = 10;
            this.btn_Bloque.Text = "...";
            this.btn_Bloque.Click += new System.EventHandler(this.btn_Bloque_Click);
            // 
            // txtBloque
            // 
            this.txtBloque.Location = new System.Drawing.Point(92, 81);
            this.txtBloque.MenuManager = this.barManager1;
            this.txtBloque.Name = "txtBloque";
            this.txtBloque.Size = new System.Drawing.Size(201, 20);
            this.txtBloque.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Bloque:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(157, 109);
            this.txtY.MenuManager = this.barManager1;
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(58, 20);
            this.txtY.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(143, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(10, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(65, 109);
            this.txtX.MenuManager = this.barManager1;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(58, 20);
            this.txtX.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(10, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "X:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(62, 55);
            this.textNombre.MenuManager = this.barManager1;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(231, 20);
            this.textNombre.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Punto:";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(62, 28);
            this.textId.MenuManager = this.barManager1;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id punto: ";
            // 
            // Frm_PuntoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 484);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PuntoControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntos de Control";
            this.Load += new System.EventHandler(this.Frm_PuntoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPuntoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValPuntoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBloque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
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
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgPuntoControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValPuntoControl;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Puntocontrol;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Puntocontrol;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtY;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtX;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBloque;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Bloque;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Bloque;
        private DevExpress.XtraGrid.Columns.GridColumn n_coordenadaX;
        private DevExpress.XtraGrid.Columns.GridColumn n_coordenadaY;
        private DevExpress.XtraEditors.SimpleButton btn_Bloque;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Huerta;
    }
}