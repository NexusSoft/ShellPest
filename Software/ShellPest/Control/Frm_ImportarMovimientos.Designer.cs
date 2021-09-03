namespace ShellPest
{
    partial class Frm_ImportarMovimientos
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.glue_Empresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_codigo_eps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Aceptar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.glue_Empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(190, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Pulsa el boton de aceptar para importar";
            // 
            // glue_Empresa
            // 
            this.glue_Empresa.EditValue = "-Seleccionar-";
            this.glue_Empresa.Location = new System.Drawing.Point(63, 13);
            this.glue_Empresa.Name = "glue_Empresa";
            this.glue_Empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_Empresa.Properties.NullText = "-Seleccionar-";
            this.glue_Empresa.Properties.PopupView = this.gridView6;
            this.glue_Empresa.Size = new System.Drawing.Size(195, 20);
            this.glue_Empresa.TabIndex = 48;
            
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
            this.labelControl18.Location = new System.Drawing.Point(16, 16);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(45, 13);
            this.labelControl18.TabIndex = 47;
            this.labelControl18.Text = "Empresa:";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(101, 84);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 49;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Frm_ImportarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.glue_Empresa);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.labelControl2);
            this.Name = "Frm_ImportarMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Movimientos";
            this.Load += new System.EventHandler(this.Frm_ImportarMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glue_Empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit glue_Empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn c_codigo_eps;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.SimpleButton btn_Aceptar;
    }
}