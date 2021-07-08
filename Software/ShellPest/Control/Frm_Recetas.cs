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
    public partial class Frm_Recetas : DevExpress.XtraEditors.XtraForm
    {

        public string IdBloque { get; set; }
        public string Bloque { get; set; }
        public string Id_Usuario { get; set; }

        public Frm_Recetas()
        {
            InitializeComponent();
        }

        private static Frm_Recetas m_FormDefInstance;
        public static Frm_Recetas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Recetas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Boolean PaSel { get; set; }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {
            txt_Monitoreo.Visible = false;
            CargarAsesor();
            CargarCultivo();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void check_Monitoreo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Monitoreo.Checked)
            {
                txt_Monitoreo.Visible = true;
            }
            else
            {
                txt_Monitoreo.Text = "";
                txt_Monitoreo.Visible = false;
            }
        }

        private void btn_Asesor_Click(object sender, EventArgs e)
        {
            Frm_AsesorTecnico Frm = new Frm_AsesorTecnico();
            Frm.PaSel = false;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            CargarAsesor();
        }

        private void CargarAsesor()
        {
            glue_Asesor.EditValue = null;
            glue_Asesor.Properties.DisplayMember = "Nombre_AsesorTecnico";
            glue_Asesor.Properties.ValueMember = "Id_AsesorTecnico";
            CLS_Asesor_Tecnico Clase = new CLS_Asesor_Tecnico();
            Clase.Activo = "1";
            Clase.MtdSeleccionarAsesor();
            if (Clase.Exito)
            {
                glue_Asesor.Properties.DataSource = Clase.Datos;
            }
        }

        private void btn_Cultivo_Click(object sender, EventArgs e)
        {
            Frm_Cultivo Frm = new Frm_Cultivo();
            Frm.PaSel = false;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            CargarCultivo();
        }

        private void CargarCultivo()
        {
            glue_Cultivo.EditValue = null;
            glue_Cultivo.Properties.DisplayMember = "Nombre_Cultivo";
            glue_Cultivo.Properties.ValueMember = "Id_Cultivo";
            CLS_Cultivo Clase = new CLS_Cultivo();
            Clase.Activo = "1";
            Clase.MtdSeleccionarCultivo();
            if (Clase.Exito)
            {
                glue_Cultivo.Properties.DataSource = Clase.Datos;
            }
        }

        private void btn_Tipo_Click(object sender, EventArgs e)
        {
            Frm_TipoAplicacion Frm = new Frm_TipoAplicacion();
            Frm.PaSel = false;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            CargarTipo();
        }

        private void CargarTipo()
        {
            glue_Tipo.EditValue = null;
            glue_Tipo.Properties.DisplayMember = "Nombre_TipoAplicacion";
            glue_Tipo.Properties.ValueMember = "Id_TipoAplicacion";
            CLS_TipoAplicacion Clase = new CLS_TipoAplicacion();
            Clase.Activo = "1";
            Clase.MtdSeleccionarTipo();
            if (Clase.Exito)
            {
                glue_Tipo.Properties.DataSource = Clase.Datos;
            }
        }

        private void btn_Presentacion_Click(object sender, EventArgs e)
        {
            Frm_Presentacion Frm = new Frm_Presentacion();
            Frm.PaSel = true;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            text_Presentacion.Tag = Frm.IdPresentacion;
            text_Presentacion.Text = Frm.Presentacion;
        }

       
    }
}