using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_NombreComercial : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NombreComercial()
        {
            InitializeComponent();
        }

        public string IdNombreComercial { get; set; }
        public string NombreComercial { get; set; }
        public string IdUnidad { get; set; }
        public string Id_Usuario { get; set; }

        private void Frm_NombreComercial_Load(object sender, EventArgs e)
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                glue_Empresa.Properties.DisplayMember = "v_nombre_eps";
                glue_Empresa.Properties.ValueMember = "c_codigo_eps";
                glue_Empresa.EditValue = null;
                glue_Empresa.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {


                    glue_Empresa.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
            }
            CargarNombreComercial();
        }

        private void CargarNombreComercial()
        {
            dtgControl.DataSource = null;
            CLS_NombreComercial Clase = new CLS_NombreComercial();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarNombreComercial();
                if (Clase.Exito)
                {
                    dtgControl.DataSource = Clase.Datos;
                }
            }

            
        }

        private void dtgControl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValControl.GetSelectedRows())
                {
                    DataRow row = this.dtgValControl.GetDataRow(i);

                    IdNombreComercial = row["c_codigo_pro"].ToString();
                    NombreComercial = row["v_nombre_pro"].ToString();
                    IdUnidad= row["c_codigo_uni"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dtgControl_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarNombreComercial();
        }
    }
}