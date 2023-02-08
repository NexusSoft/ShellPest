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

namespace ShellPest.Control
{
    public partial class Frm_Combustibles : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Combustibles()
        {
            InitializeComponent();
        }

        private void Frm_Combustibles_Load(object sender, EventArgs e)
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            //Clase.Id_Usuario = Id_Usuario;

            rg_IoS.EditValue = "S";
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
                
                //CargarGridPodas(false);
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

        private void rg_IoS_EditValueChanged(object sender, EventArgs e)
        {
            if (rg_IoS.EditValue.ToString() == "S")
            {
                
                label_Activo.Visible = true;
                glue_Activos.Visible = true;
                label_Bloque.Visible = true;
                glue_Bloques.Visible = true;
                label_Actividad.Visible = true;
                glue_Actividades.Visible = true;
                CargarActividades();
            }
            else
            {
                label_Activo.Visible = false;
                glue_Activos.Visible = false;
                label_Bloque.Visible = false;
                glue_Bloques.Visible = false;
                label_Actividad.Visible = false;
                glue_Actividades.Visible = false;
            }
        }

        private void CargarActividades()
        {
            glue_Actividades.Properties.DataSource = null;
            WS_Catalogos_cosactividad Clase = new WS_Catalogos_cosactividad();

            if (glue_Empresas.EditValue != null)
            {
                Clase.MtdSeleccionarActividad();
                if (Clase.Exito)
                {
                    glue_Actividades.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void glue_Huertas_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void glue_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            CargarHuertas();
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