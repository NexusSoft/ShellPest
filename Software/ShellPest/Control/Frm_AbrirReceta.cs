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
    public partial class Frm_AbrirReceta : DevExpress.XtraEditors.XtraForm
    {
        public Frm_AbrirReceta()
        {
            InitializeComponent();
        }

        public string vId_Receta { get; set; }
        public string vFecha_Receta { get; set; }
        public string vId_AsesorTecnico { get; set; }
        public string vNombre_AsesorTecnico { get; set; }
        public string vId_MonitoreoPE { get; set; }
        public string vId_Cultivo { get; set; }
        public string vNombre_Cultivo { get; set; }
        public string vId_TipoAplicacion { get; set; }
        public string vNombre_TipoAplicacion { get; set; }
        public string vId_Presentacion { get; set; }
        public string vNombre_Presentacion { get; set; }
        public string vId_Unidad { get; set; }
        public string vv_nombre_uni { get; set; }
        public string vObservaciones { get; set; }
        public string vIntervalo_Seguridad { get; set; }
        public string vIntervalo_Reingreso { get; set; }
        public Boolean vActivo { get; set; }

        private void Frm_AbrirReceta_Load(object sender, EventArgs e)
        {
            CargarReceta();
        }

        private void CargarReceta()
        {
            dtgControl.DataSource = null;
            CLS_Receta Clase = new CLS_Receta();
            Clase.MtdSeleccionarReceta();
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

                    vId_Receta = row["Id_Receta"].ToString();
                    vFecha_Receta = row["Fecha_Receta"].ToString();
                    vId_AsesorTecnico = row["Id_AsesorTecnico"].ToString();
                    vNombre_AsesorTecnico = row["Nombre_AsesorTecnico"].ToString();
                    vId_MonitoreoPE = row["Id_MonitoreoPE"].ToString();
                    vId_Cultivo = row["Id_Cultivo"].ToString();
                    vNombre_Cultivo = row["Nombre_Cultivo"].ToString();
                    vId_TipoAplicacion = row["Id_TipoAplicacion"].ToString();
                    vNombre_TipoAplicacion = row["Nombre_TipoAplicacion"].ToString();
                    vId_Presentacion = row["Id_Presentacion"].ToString();
                    vNombre_Presentacion = row["Nombre_Presentacion"].ToString();
                    vId_Unidad = row["Id_Unidad"].ToString();
                    vv_nombre_uni = row["v_nombre_uni"].ToString();
                    vObservaciones = row["Observaciones"].ToString();
                    vIntervalo_Seguridad = row["Intervalo_Seguridad"].ToString();
                    vIntervalo_Reingreso = row["Intervalo_Reingreso"].ToString();
                    vActivo= Convert.ToBoolean(row["Activo"]);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_Receta == null)
            {
                vId_Receta = "";
            }
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_Receta == null)
            {
                vId_Receta = "";
            }
            this.Close();
        }

        private void dtgControl_DoubleClick(object sender, EventArgs e)
        {
            if (vId_Receta == null)
            {
                vId_Receta = "";
            }
            this.Close();
        }
    }
}