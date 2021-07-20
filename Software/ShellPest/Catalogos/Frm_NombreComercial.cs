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

        private void Frm_NombreComercial_Load(object sender, EventArgs e)
        {
            CargarNombreComercial();
        }

        private void CargarNombreComercial()
        {
            dtgControl.DataSource = null;
            CLS_NombreComercial Clase = new CLS_NombreComercial();

            Clase.MtdSeleccionarNombreComercial();
            if (Clase.Exito)
            {
                dtgControl.DataSource = Clase.Datos;
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
    }
}