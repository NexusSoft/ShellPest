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
    public partial class Frm_Valvulas_Riego : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Valvulas_Riego()
        {
            InitializeComponent();
        }
        public String Id_Usuario;

        private static Frm_Valvulas_Riego m_FormDefInstance;
        public static Frm_Valvulas_Riego DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Valvulas_Riego();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Valvulas_Riego_Load(object sender, EventArgs e)
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
                
                CargarHuertas();
                
                
            }
            
        }


        private void CargarHuertas()
        {
            glue_Huerta.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarHuerta();
                if (Clase.Exito)
                {
                    glue_Huerta.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarBloques()
        {
            glue_Bloque.Properties.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            if (glue_Empresa.EditValue != null)
            {
                Clase.Id_Huerta = glue_Huerta.EditValue.ToString();
                Clase.TipoBloque = "R";
                Clase.MtdSeleccionarBloquesHuerta();
                if (Clase.Exito)
                {
                    glue_Bloque.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarGrid()
        {
            gridControl1.DataSource = null;
            if (textValvula.Text.Trim().Length > 0 && glue_Bloque.EditValue!=null)
            {
                CLS_Valvulas Clase = new CLS_Valvulas();

                Clase.N_Valvula = int.Parse(textValvula.Text);
                Clase.Id_Bloque = glue_Bloque.EditValue.ToString().Trim();

                Clase.MtdSeleccionarValvulasDet();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
            }

        }

        private void glue_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void textValvula_EditValueChanged(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS_Valvulas Clase = new CLS_Valvulas();
           
            Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
            Clase.N_Valvula= int.Parse(textValvula.Text);
            Clase.N_Arboles = int.Parse(text_Arboles.Text);
            Clase.N_Replantes = int.Parse(text_Replantes.Text);
            Clase.N_Morras = int.Parse(text_Morras.Text);
            Clase.N_Micros = int.Parse(text_Micros.Text);
            Clase.N_Caudales = Decimal.Parse(text_Caudal.Text);
            Clase.M3 = Decimal.Parse(text_M3.Text);
           
            Clase.MtdInsertarValvulas();
            if (Clase.Exito)
            {
                CargarGrid();
            }
        }
    }
}