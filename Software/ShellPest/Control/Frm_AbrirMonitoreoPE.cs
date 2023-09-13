using System;

using System.Data;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_AbrirMonitoreoPE : DevExpress.XtraEditors.XtraForm
    {
        public Frm_AbrirMonitoreoPE()
        {
            InitializeComponent();
        }

        public string vId_PuntoControl { get; set; }
        public DateTime vFecha { get; set; }
        

        private void Frm_AbrirMonitoreoPE_Load(object sender, EventArgs e)
        {
            CargarMonitoreoPE();
        }

        private void CargarMonitoreoPE()
        {
            dtgControl.DataSource = null;
            CLS_Monitoreo Clase = new CLS_Monitoreo();
            Clase.MtdSeleccionarMonitoreoPE();
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

                    vId_PuntoControl = row["Id_Huerta"].ToString();
                    vFecha = Convert.ToDateTime(row["Fecha"]);
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_PuntoControl == null)
            {
                vId_PuntoControl = "";
            }
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_PuntoControl == null)
            {
                vId_PuntoControl = "";
            }
            this.Close();
        }

        private void dtgControl_DoubleClick(object sender, EventArgs e)
        {
            if (vId_PuntoControl == null)
            {
                vId_PuntoControl = "";
            }
            this.Close();
        }
    }
}