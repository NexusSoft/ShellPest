namespace ShellPest
{
    partial class Frm_ImportarTxt
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Importar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.text_Ruta = new System.Windows.Forms.TextBox();
            this.label_Ventana = new DevExpress.XtraEditors.LabelControl();
            this.btn_SelArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ventana:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ruta:";
            // 
            // btn_Importar
            // 
            this.btn_Importar.Location = new System.Drawing.Point(153, 89);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(75, 23);
            this.btn_Importar.TabIndex = 3;
            this.btn_Importar.Text = "Importar";
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(243, 89);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // text_Ruta
            // 
            this.text_Ruta.Location = new System.Drawing.Point(46, 37);
            this.text_Ruta.Name = "text_Ruta";
            this.text_Ruta.Size = new System.Drawing.Size(247, 21);
            this.text_Ruta.TabIndex = 5;
            // 
            // label_Ventana
            // 
            this.label_Ventana.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label_Ventana.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.label_Ventana.Appearance.Options.UseFont = true;
            this.label_Ventana.Appearance.Options.UseForeColor = true;
            this.label_Ventana.Location = new System.Drawing.Point(63, 12);
            this.label_Ventana.Name = "label_Ventana";
            this.label_Ventana.Size = new System.Drawing.Size(77, 13);
            this.label_Ventana.TabIndex = 6;
            this.label_Ventana.Text = "Sin identificar";
            // 
            // btn_SelArchivo
            // 
            this.btn_SelArchivo.Location = new System.Drawing.Point(299, 35);
            this.btn_SelArchivo.Name = "btn_SelArchivo";
            this.btn_SelArchivo.Size = new System.Drawing.Size(28, 23);
            this.btn_SelArchivo.TabIndex = 7;
            this.btn_SelArchivo.Text = "...";
            this.btn_SelArchivo.Click += new System.EventHandler(this.btn_SelArchivo_Click);
            // 
            // Frm_ImportarTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 124);
            this.Controls.Add(this.btn_SelArchivo);
            this.Controls.Add(this.label_Ventana);
            this.Controls.Add(this.text_Ruta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Importar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Frm_ImportarTxt";
            this.Text = "ImportarTxt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Importar;
        private DevExpress.XtraEditors.SimpleButton btn_Cancelar;
        private System.Windows.Forms.TextBox text_Ruta;
        private DevExpress.XtraEditors.LabelControl label_Ventana;
        private DevExpress.XtraEditors.SimpleButton btn_SelArchivo;
    }
}