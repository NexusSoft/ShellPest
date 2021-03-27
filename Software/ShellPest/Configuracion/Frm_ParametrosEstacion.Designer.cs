namespace ShellPest.Configuracion
{
    partial class Frm_ParametrosEstacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParametrosEstacion));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.spFilaInicio = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.spRain = new DevExpress.XtraEditors.SpinEdit();
            this.spET = new DevExpress.XtraEditors.SpinEdit();
            this.spTempOut = new DevExpress.XtraEditors.SpinEdit();
            this.spFecha = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spFilaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTempOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFecha.Properties)).BeginInit();
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
            this.btnGuardar,
            this.btnSalir});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bEstado;
            // 
            // bIconos
            // 
            this.bIconos.BarName = "Menú principal";
            this.bIconos.DockCol = 0;
            this.bIconos.DockRow = 0;
            this.bIconos.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bIconos.FloatLocation = new System.Drawing.Point(42, 184);
            this.bIconos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar),
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
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 1;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 5;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
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
            this.barDockControlTop.Size = new System.Drawing.Size(567, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 222);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(567, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(54, 222);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(567, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 222);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(54, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(513, 222);
            this.panelControl1.TabIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(489, 198);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.spFilaInicio);
            this.xtraTabPage1.Controls.Add(this.labelControl15);
            this.xtraTabPage1.Controls.Add(this.spRain);
            this.xtraTabPage1.Controls.Add(this.spET);
            this.xtraTabPage1.Controls.Add(this.spTempOut);
            this.xtraTabPage1.Controls.Add(this.spFecha);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(483, 170);
            this.xtraTabPage1.Text = "Carga Excel Estacion M.";
            // 
            // spFilaInicio
            // 
            this.spFilaInicio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spFilaInicio.Location = new System.Drawing.Point(199, 12);
            this.spFilaInicio.Name = "spFilaInicio";
            this.spFilaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spFilaInicio.Properties.MaxValue = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.spFilaInicio.Size = new System.Drawing.Size(51, 20);
            this.spFilaInicio.TabIndex = 40;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(24, 16);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(63, 13);
            this.labelControl15.TabIndex = 39;
            this.labelControl15.Text = "Fila de Inicio:";
            // 
            // spRain
            // 
            this.spRain.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spRain.Location = new System.Drawing.Point(199, 125);
            this.spRain.Name = "spRain";
            this.spRain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spRain.Properties.MaxValue = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.spRain.Size = new System.Drawing.Size(51, 20);
            this.spRain.TabIndex = 23;
            // 
            // spET
            // 
            this.spET.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spET.Location = new System.Drawing.Point(199, 99);
            this.spET.Name = "spET";
            this.spET.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spET.Properties.MaxValue = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.spET.Size = new System.Drawing.Size(51, 20);
            this.spET.TabIndex = 22;
            // 
            // spTempOut
            // 
            this.spTempOut.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spTempOut.Location = new System.Drawing.Point(199, 73);
            this.spTempOut.Name = "spTempOut";
            this.spTempOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spTempOut.Properties.MaxValue = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.spTempOut.Size = new System.Drawing.Size(51, 20);
            this.spTempOut.TabIndex = 21;
            // 
            // spFecha
            // 
            this.spFecha.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spFecha.Location = new System.Drawing.Point(199, 47);
            this.spFecha.Name = "spFecha";
            this.spFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spFecha.Properties.MaxValue = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.spFecha.Size = new System.Drawing.Size(51, 20);
            this.spFecha.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Columna Excel Rain:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Columna Excel ET:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Columna Excel Temp Out:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Columna Excel Fecha:";
            // 
            // Frm_ParametrosEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 249);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ParametrosEstacion";
            this.Text = "Parametros Excel Estacion";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spFilaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTempOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnGuardar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SpinEdit spFilaInicio;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SpinEdit spRain;
        private DevExpress.XtraEditors.SpinEdit spET;
        private DevExpress.XtraEditors.SpinEdit spTempOut;
        private DevExpress.XtraEditors.SpinEdit spFecha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}