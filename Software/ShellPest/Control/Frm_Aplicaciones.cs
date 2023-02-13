using CapaDeDatos;
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

namespace ShellPest
{
    public partial class Frm_Aplicaciones : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Usuario { get; set; }
        public Frm_Aplicaciones()
        {
            InitializeComponent();
        }
        private static Frm_Aplicaciones m_FormDefInstance;
        public static Frm_Aplicaciones DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Aplicaciones();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Aplicaciones_Shown(object sender, EventArgs e)
        {
            CargarEmpresa();
        }

        private void CargarEmpresa()
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                cmb_Empresas.Properties.DisplayMember = "v_nombre_usuemp";
                cmb_Empresas.Properties.ValueMember = "c_codigo_eps";
                cmb_Empresas.EditValue = null;
                cmb_Empresas.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {
                    cmb_Empresas.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
            }
        }
    }
}