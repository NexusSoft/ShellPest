namespace ShellPest
{
    partial class Frm_Deteccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Deteccion));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblDeteccion = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtgDeteccion = new DevExpress.XtraGrid.GridControl();
            this.dtgValDeteccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id_Deteccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre_Deteccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Crea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Creador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Usuario_Mod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeteccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValDeteccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
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
            this.lblDeteccion,
            this.btnLimpiar,
            this.btnGuardar,
            this.btnEliminar,
            this.btnSalir,
            this.btnSeleccionar});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 65;
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
            this.btnSeleccionar.Id = 64;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.lblDeteccion)});
            this.bEstado.OptionsBar.AllowQuickCustomization = false;
            this.bEstado.OptionsBar.DrawDragBorder = false;
            this.bEstado.OptionsBar.UseWholeRow = true;
            this.bEstado.Text = "Barra de estado";
            // 
            // lblDeteccion
            // 
            this.lblDeteccion.Caption = "Detección:";
            this.lblDeteccion.Id = 48;
            this.lblDeteccion.Name = "lblDeteccion";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(643, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(643, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(71, 407);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(643, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtgDeteccion);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(71, 106);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(572, 301);
            this.panelControl2.TabIndex = 9;
            // 
            // dtgDeteccion
            // 
            this.dtgDeteccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDeteccion.Location = new System.Drawing.Point(12, 12);
            this.dtgDeteccion.MainView = this.dtgValDeteccion;
            this.dtgDeteccion.MenuManager = this.barManager1;
            this.dtgDeteccion.Name = "dtgDeteccion";
            this.dtgDeteccion.Size = new System.Drawing.Size(548, 277);
            this.dtgDeteccion.TabIndex = 0;
            this.dtgDeteccion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValDeteccion});
            this.dtgDeteccion.Click += new System.EventHandler(this.dtgDeteccion_Click);
            // 
            // dtgValDeteccion
            // 
            this.dtgValDeteccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id_Deteccion,
            this.Nombre_Deteccion,
            this.Id_Usuario_Crea,
            this.Creador,
            this.Id_Usuario_Mod,
            this.Modificador});
            this.dtgValDeteccion.GridControl = this.dtgDeteccion;
            this.dtgValDeteccion.Name = "dtgValDeteccion";
            this.dtgValDeteccion.OptionsBehavior.Editable = false;
            this.dtgValDeteccion.OptionsFind.AlwaysVisible = true;
            this.dtgValDeteccion.OptionsView.ShowGroupPanel = false;
            this.dtgValDeteccion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dtgValDeteccion.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // Id_Deteccion
            // 
            this.Id_Deteccion.Caption = "Id Deteccion";
            this.Id_Deteccion.FieldName = "Id_Deteccion";
            this.Id_Deteccion.Name = "Id_Deteccion";
            this.Id_Deteccion.OptionsColumn.AllowEdit = false;
            this.Id_Deteccion.Visible = true;
            this.Id_Deteccion.VisibleIndex = 0;
            // 
            // Nombre_Deteccion
            // 
            this.Nombre_Deteccion.Caption = "Nombre Deteccion";
            this.Nombre_Deteccion.FieldName = "Nombre_Deteccion";
            this.Nombre_Deteccion.Name = "Nombre_Deteccion";
            this.Nombre_Deteccion.Visible = true;
            this.Nombre_Deteccion.VisibleIndex = 1;
            // 
            // Id_Usuario_Crea
            // 
            this.Id_Usuario_Crea.Caption = "Id Creador";
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
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(71, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(572, 106);
            this.panelControl1.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(548, 82);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Detección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 54);
            this.txtNombre.MenuManager = this.barManager1;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre Detección:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(113, 28);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id Detección: ";
            // 
            // Frm_Deteccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 432);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Deteccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detección";
            this.Load += new System.EventHandler(this.Frm_Deteccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeteccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValDeteccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarStaticItem lblDeteccion;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgDeteccion;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValDeteccion;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Deteccion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre_Deteccion;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Crea;
        private DevExpress.XtraGrid.Columns.GridColumn Creador;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Usuario_Mod;
        private DevExpress.XtraGrid.Columns.GridColumn Modificador;
    }
}