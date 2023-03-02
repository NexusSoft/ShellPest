namespace ShellPest
{
    partial class Frm_Actividad_Campo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Actividad_Campo));
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_codigo_actG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_nombre_actG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_codigo_camG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_nombre_camG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_UnidadG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AbreviaturaG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Quitar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Agregar = new DevExpress.XtraEditors.SimpleButton();
            this.glue_Unidades = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glue_Actividades = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glue_Campos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.v_nombre_cam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_codigo_cam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Unidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Actividades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Campos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 53;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Inhabilitar";
            this.btnEliminar.Id = 57;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 63;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Caption = "Seleccionar";
            this.btnSeleccionar.Id = 64;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.LargeImage")));
            this.btnSeleccionar.Name = "btnSeleccionar";
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
            this.lblProveedor.Caption = "Cultivo:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(824, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 448);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(824, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(69, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(824, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(69, 79);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(755, 369);
            this.panelControl2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(7, 7);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 355);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_codigo_actG,
            this.v_nombre_actG,
            this.c_codigo_camG,
            this.v_nombre_camG,
            this.Id_UnidadG,
            this.AbreviaturaG});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // c_codigo_actG
            // 
            this.c_codigo_actG.Caption = "c_codigo_act";
            this.c_codigo_actG.FieldName = "c_codigo_act";
            this.c_codigo_actG.Name = "c_codigo_actG";
            this.c_codigo_actG.OptionsColumn.AllowEdit = false;
            this.c_codigo_actG.Visible = true;
            this.c_codigo_actG.VisibleIndex = 0;
            // 
            // v_nombre_actG
            // 
            this.v_nombre_actG.Caption = "Actividad";
            this.v_nombre_actG.FieldName = "v_nombre_act";
            this.v_nombre_actG.Name = "v_nombre_actG";
            this.v_nombre_actG.OptionsColumn.AllowEdit = false;
            this.v_nombre_actG.Visible = true;
            this.v_nombre_actG.VisibleIndex = 1;
            // 
            // c_codigo_camG
            // 
            this.c_codigo_camG.Caption = "c_codigo_cam";
            this.c_codigo_camG.FieldName = "c_codigo_cam";
            this.c_codigo_camG.Name = "c_codigo_camG";
            this.c_codigo_camG.Visible = true;
            this.c_codigo_camG.VisibleIndex = 2;
            // 
            // v_nombre_camG
            // 
            this.v_nombre_camG.Caption = "Campo";
            this.v_nombre_camG.FieldName = "v_nombre_cam";
            this.v_nombre_camG.Name = "v_nombre_camG";
            this.v_nombre_camG.Visible = true;
            this.v_nombre_camG.VisibleIndex = 3;
            // 
            // Id_UnidadG
            // 
            this.Id_UnidadG.Caption = "Id_Unidad";
            this.Id_UnidadG.FieldName = "Id_Unidad";
            this.Id_UnidadG.Name = "Id_UnidadG";
            this.Id_UnidadG.Visible = true;
            this.Id_UnidadG.VisibleIndex = 4;
            // 
            // AbreviaturaG
            // 
            this.AbreviaturaG.Caption = "Unidad";
            this.AbreviaturaG.FieldName = "Abreviatura";
            this.AbreviaturaG.Name = "AbreviaturaG";
            this.AbreviaturaG.Visible = true;
            this.AbreviaturaG.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Quitar);
            this.panelControl1.Controls.Add(this.btn_Agregar);
            this.panelControl1.Controls.Add(this.glue_Unidades);
            this.panelControl1.Controls.Add(this.glue_Actividades);
            this.panelControl1.Controls.Add(this.glue_Campos);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(69, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(755, 79);
            this.panelControl1.TabIndex = 8;
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quitar.ImageOptions.Image")));
            this.btn_Quitar.Location = new System.Drawing.Point(59, 37);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(38, 34);
            this.btn_Quitar.TabIndex = 64;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.ImageOptions.Image")));
            this.btn_Agregar.Location = new System.Drawing.Point(15, 37);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(38, 34);
            this.btn_Agregar.TabIndex = 63;
            // 
            // glue_Unidades
            // 
            this.glue_Unidades.EditValue = "-Seleccionar-";
            this.glue_Unidades.Location = new System.Drawing.Point(556, 13);
            this.glue_Unidades.Name = "glue_Unidades";
            this.glue_Unidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Unidades.Properties.DisplayMember = "Nombre_Unidad";
            this.glue_Unidades.Properties.NullText = "-Seleccionar-";
            this.glue_Unidades.Properties.PopupView = this.gridView4;
            this.glue_Unidades.Properties.ValueMember = "Id_Unidad";
            this.glue_Unidades.Size = new System.Drawing.Size(193, 20);
            this.glue_Unidades.TabIndex = 7;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Unidad";
            this.gridColumn3.FieldName = "Nombre_Unidad";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Codigo";
            this.gridColumn4.FieldName = "Id_Unidad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // glue_Actividades
            // 
            this.glue_Actividades.EditValue = "-Seleccionar-";
            this.glue_Actividades.Location = new System.Drawing.Point(309, 13);
            this.glue_Actividades.Name = "glue_Actividades";
            this.glue_Actividades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Actividades.Properties.DisplayMember = "v_nombre_act";
            this.glue_Actividades.Properties.NullText = "-Seleccionar-";
            this.glue_Actividades.Properties.PopupView = this.gridView2;
            this.glue_Actividades.Properties.ValueMember = "c_codigo_act";
            this.glue_Actividades.Size = new System.Drawing.Size(193, 20);
            this.glue_Actividades.TabIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Actividad";
            this.gridColumn1.FieldName = "v_nombre_act";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Codigo";
            this.gridColumn2.FieldName = "c_codigo_act";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // glue_Campos
            // 
            this.glue_Campos.EditValue = "-Seleccionar-";
            this.glue_Campos.Location = new System.Drawing.Point(52, 11);
            this.glue_Campos.Name = "glue_Campos";
            this.glue_Campos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Campos.Properties.DisplayMember = "v_nombre_cam";
            this.glue_Campos.Properties.NullText = "-Seleccionar-";
            this.glue_Campos.Properties.PopupView = this.gridView3;
            this.glue_Campos.Properties.ValueMember = "c_codigo_cam";
            this.glue_Campos.Size = new System.Drawing.Size(193, 20);
            this.glue_Campos.TabIndex = 5;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.v_nombre_cam,
            this.c_codigo_cam});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // v_nombre_cam
            // 
            this.v_nombre_cam.Caption = "Huerta";
            this.v_nombre_cam.FieldName = "v_nombre_cam";
            this.v_nombre_cam.Name = "v_nombre_cam";
            this.v_nombre_cam.Visible = true;
            this.v_nombre_cam.VisibleIndex = 0;
            // 
            // c_codigo_cam
            // 
            this.c_codigo_cam.Caption = "Codigo";
            this.c_codigo_cam.FieldName = "c_codigo_cam";
            this.c_codigo_cam.Name = "c_codigo_cam";
            this.c_codigo_cam.Visible = true;
            this.c_codigo_cam.VisibleIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(513, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Unidad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(262, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Actividad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Campo:";
            // 
            // Frm_Actividad_Campo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Actividad_Campo";
            this.Text = "Actividad - Campo";
            this.Load += new System.EventHandler(this.Frm_Actividad_Campo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Unidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Actividades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Campos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_actG;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_actG;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Unidades;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Actividades;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Campos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_cam;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_cam;
        private DevExpress.XtraEditors.SimpleButton btn_Quitar;
        private DevExpress.XtraEditors.SimpleButton btn_Agregar;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_camG;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_camG;
        private DevExpress.XtraGrid.Columns.GridColumn Id_UnidadG;
        private DevExpress.XtraGrid.Columns.GridColumn AbreviaturaG;
    }
}