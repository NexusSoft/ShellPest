namespace ShellPest
{
    partial class Frm_Lugar_Campo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Lugar_Campo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_codigo_lug = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_nombre_lug = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_codigo_cam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_nombre_cam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.glue_Campo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.v_nombre_camL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_codigo_camL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Quitar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Agregar = new DevExpress.XtraEditors.SimpleButton();
            this.label_BloquesView = new DevExpress.XtraEditors.LabelControl();
            this.label_Bloque = new DevExpress.XtraEditors.LabelControl();
            this.glue_Lugar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.v_nombre_lugL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_codigo_lugL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label_Huerta = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Campo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Lugar.Properties)).BeginInit();
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
            this.btnSeleccionar.Id = 66;
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
            this.bEstado.OptionsBar.AllowQuickCustomization = false;
            this.bEstado.OptionsBar.DrawDragBorder = false;
            this.bEstado.OptionsBar.UseWholeRow = true;
            this.bEstado.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(586, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 345);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(586, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(69, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(586, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(69, 104);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(517, 241);
            this.panelControl2.TabIndex = 21;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(7, 7);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(503, 227);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_codigo_lug,
            this.v_nombre_lug,
            this.c_codigo_cam,
            this.v_nombre_cam});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // c_codigo_lug
            // 
            this.c_codigo_lug.Caption = "c_codigo_lug";
            this.c_codigo_lug.FieldName = "c_codigo_lug";
            this.c_codigo_lug.Name = "c_codigo_lug";
            // 
            // v_nombre_lug
            // 
            this.v_nombre_lug.Caption = "Lugar";
            this.v_nombre_lug.FieldName = "v_nombre_lug";
            this.v_nombre_lug.Name = "v_nombre_lug";
            this.v_nombre_lug.Visible = true;
            this.v_nombre_lug.VisibleIndex = 0;
            // 
            // c_codigo_cam
            // 
            this.c_codigo_cam.Caption = "c_codigo_cam";
            this.c_codigo_cam.FieldName = "c_codigo_cam";
            this.c_codigo_cam.Name = "c_codigo_cam";
            // 
            // v_nombre_cam
            // 
            this.v_nombre_cam.Caption = "Campo";
            this.v_nombre_cam.FieldName = "v_nombre_cam";
            this.v_nombre_cam.Name = "v_nombre_cam";
            this.v_nombre_cam.Visible = true;
            this.v_nombre_cam.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(69, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(6);
            this.panelControl1.Size = new System.Drawing.Size(517, 104);
            this.panelControl1.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.glue_Campo);
            this.groupControl1.Controls.Add(this.btn_Quitar);
            this.groupControl1.Controls.Add(this.btn_Agregar);
            this.groupControl1.Controls.Add(this.label_BloquesView);
            this.groupControl1.Controls.Add(this.label_Bloque);
            this.groupControl1.Controls.Add(this.glue_Lugar);
            this.groupControl1.Controls.Add(this.label_Huerta);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 88);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Riego";
            // 
            // glue_Campo
            // 
            this.glue_Campo.EditValue = "-Seleccionar-";
            this.glue_Campo.Location = new System.Drawing.Point(300, 24);
            this.glue_Campo.Name = "glue_Campo";
            this.glue_Campo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Campo.Properties.DisplayMember = "v_nombre_cam";
            this.glue_Campo.Properties.NullText = "-Seleccionar-";
            this.glue_Campo.Properties.PopupView = this.gridView2;
            this.glue_Campo.Properties.ValueMember = "c_codigo_cam";
            this.glue_Campo.Size = new System.Drawing.Size(193, 20);
            this.glue_Campo.TabIndex = 84;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.v_nombre_camL,
            this.c_codigo_camL});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // v_nombre_camL
            // 
            this.v_nombre_camL.Caption = "Campo";
            this.v_nombre_camL.FieldName = "v_nombre_cam";
            this.v_nombre_camL.Name = "v_nombre_camL";
            this.v_nombre_camL.Visible = true;
            this.v_nombre_camL.VisibleIndex = 0;
            // 
            // c_codigo_camL
            // 
            this.c_codigo_camL.Caption = "Codigo";
            this.c_codigo_camL.FieldName = "c_codigo_cam";
            this.c_codigo_camL.Name = "c_codigo_camL";
            this.c_codigo_camL.Visible = true;
            this.c_codigo_camL.VisibleIndex = 1;
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Quitar.ImageOptions.Image")));
            this.btn_Quitar.Location = new System.Drawing.Point(455, 50);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(38, 34);
            this.btn_Quitar.TabIndex = 83;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.ImageOptions.Image")));
            this.btn_Agregar.Location = new System.Drawing.Point(411, 50);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(38, 34);
            this.btn_Agregar.TabIndex = 82;
            // 
            // label_BloquesView
            // 
            this.label_BloquesView.Location = new System.Drawing.Point(308, 27);
            this.label_BloquesView.Name = "label_BloquesView";
            this.label_BloquesView.Size = new System.Drawing.Size(0, 13);
            this.label_BloquesView.TabIndex = 69;
            // 
            // label_Bloque
            // 
            this.label_Bloque.Location = new System.Drawing.Point(259, 27);
            this.label_Bloque.Name = "label_Bloque";
            this.label_Bloque.Size = new System.Drawing.Size(37, 13);
            this.label_Bloque.TabIndex = 67;
            this.label_Bloque.Text = "Campo:";
            // 
            // glue_Lugar
            // 
            this.glue_Lugar.EditValue = "-Seleccionar-";
            this.glue_Lugar.Location = new System.Drawing.Point(48, 24);
            this.glue_Lugar.Name = "glue_Lugar";
            this.glue_Lugar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Lugar.Properties.DisplayMember = "v_nombre_lug";
            this.glue_Lugar.Properties.NullText = "-Seleccionar-";
            this.glue_Lugar.Properties.PopupView = this.gridView3;
            this.glue_Lugar.Properties.ValueMember = "c_codigo_lug";
            this.glue_Lugar.Size = new System.Drawing.Size(193, 20);
            this.glue_Lugar.TabIndex = 50;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.v_nombre_lugL,
            this.c_codigo_lugL});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // v_nombre_lugL
            // 
            this.v_nombre_lugL.Caption = "Lugar";
            this.v_nombre_lugL.FieldName = "v_nombre_lug";
            this.v_nombre_lugL.Name = "v_nombre_lugL";
            this.v_nombre_lugL.Visible = true;
            this.v_nombre_lugL.VisibleIndex = 0;
            // 
            // c_codigo_lugL
            // 
            this.c_codigo_lugL.Caption = "Codigo";
            this.c_codigo_lugL.FieldName = "c_codigo_lug";
            this.c_codigo_lugL.Name = "c_codigo_lugL";
            this.c_codigo_lugL.Visible = true;
            this.c_codigo_lugL.VisibleIndex = 1;
            // 
            // label_Huerta
            // 
            this.label_Huerta.Location = new System.Drawing.Point(7, 27);
            this.label_Huerta.Name = "label_Huerta";
            this.label_Huerta.Size = new System.Drawing.Size(31, 13);
            this.label_Huerta.TabIndex = 49;
            this.label_Huerta.Text = "Lugar:";
            // 
            // Frm_Lugar_Campo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 367);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Lugar_Campo";
            this.Text = "Frm_Lugar_Campo";
            this.Load += new System.EventHandler(this.Frm_Lugar_Campo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Campo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Lugar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.BarLargeButtonItem btnSeleccionar;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_lug;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_lug;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Quitar;
        private DevExpress.XtraEditors.SimpleButton btn_Agregar;
        private DevExpress.XtraEditors.LabelControl label_BloquesView;
        private DevExpress.XtraEditors.LabelControl label_Bloque;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Lugar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_lugL;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_lugL;
        private DevExpress.XtraEditors.LabelControl label_Huerta;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_cam;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_cam;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Campo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn v_nombre_camL;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_camL;
    }
}