using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_Riego : DevExpress.XtraEditors.XtraForm
    {

        public string Id_Usuario { get; set; }
        public Frm_Riego()
        {
            InitializeComponent();
        }

        private static Frm_Riego m_FormDefInstance;
        public static Frm_Riego DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Riego();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        private void Frm_Riego_Load(object sender, EventArgs e)
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;


            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                glue_Empresas.Properties.DisplayMember = "v_nombre_eps";
                glue_Empresas.Properties.ValueMember = "c_codigo_eps";
                glue_Empresas.EditValue = null;
                glue_Empresas.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {


                    glue_Empresas.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
                de_Fecha.EditValue = DateTime.Today;
                CargarHuertas();

                
            }
        }

        private void CargarHuertas()
        {
            glue_Huertas.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

            if (glue_Empresas.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresas.EditValue.ToString();
                Clase.MtdSeleccionarHuerta();
                if (Clase.Exito)
                {
                    glue_Huertas.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void glue_Huertas_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void CargarBloques()
        {
            glue_Bloques.Properties.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            if (glue_Empresas.EditValue != null)
            {
                Clase.Id_Huerta = glue_Huertas.EditValue.ToString();
                Clase.TipoBloque = "B";
                Clase.MtdSeleccionarBloquesHuerta();
                if (Clase.Exito)
                {
                    glue_Bloques.Properties.DataSource = Clase.Datos;
                }
            }
        }

    }
}