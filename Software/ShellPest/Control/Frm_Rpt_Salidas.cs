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
    public partial class Frm_Rpt_Salidas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Rpt_Salidas()
        {
            InitializeComponent();
        }
        public string Id_Usuario { get; set; }

        private static Frm_Rpt_Salidas m_FormDefInstance;
        public static Frm_Rpt_Salidas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Rpt_Salidas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Rpt_Salidas_Load(object sender, EventArgs e)
        {
            btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            radioGroup1.EditValue = "S";
            date_Fin.EditValue = DateTime.Today;
            date_Ini.EditValue = DateTime.Today.AddDays(-7);

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
            CargarAlmacen();
         
        }

        private void CargarAlmacen()
        {
            glue_Almacen.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarAlmacen();
                if (Clase.Exito)
                {
                    glue_Almacen.Properties.DataSource = Clase.Datos;
                }
            }

           
        }

        private void CargarSalidas()
        {
            gridControl1.DataSource = null;
            CLS_Movimientos Clase = new CLS_Movimientos();
            if (checkEdit1.Checked)
            {
                Clase.Almacen = "";
            }
            else
            {
                Clase.Almacen = glue_Almacen.EditValue.ToString().Trim();
            }
           
            DateTime Fecha = Convert.ToDateTime(date_Ini.EditValue.ToString());
            Clase.Fini = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Fecha = Convert.ToDateTime(date_Fin.EditValue.ToString());
            Clase.Ffin= Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarSalidas();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
            }

            
        }

        private string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarSalidas();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                glue_Almacen.Enabled = false;
            }
            else
            {
                glue_Almacen.Enabled = true;
            }
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarAlmacen();
            

            CargarSalidas();
            
        }

        
    }
}