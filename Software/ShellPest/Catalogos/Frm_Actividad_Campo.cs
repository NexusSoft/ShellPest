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
    public partial class Frm_Actividad_Campo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Actividad_Campo()
        {
            InitializeComponent();
        }


        private static Frm_Actividad_Campo m_FormDefInstance;
        public static Frm_Actividad_Campo DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Actividad_Campo();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void CargarGrid()
        {
            gridControl1.DataSource = null;
            CLS_Actividad_Campo Clase = new CLS_Actividad_Campo();

                Clase.MtdSeleccionarActividadCampo();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
            }

        private void Frm_Actividad_Campo_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    
    }
}