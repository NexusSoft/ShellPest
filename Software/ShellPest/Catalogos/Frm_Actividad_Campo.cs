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

        private void CargarCampos()
        {
            glue_Campos.Properties.DataSource = null;
            CLS_Inventum Clase = new CLS_Inventum();
            Clase.c_codigo_eps = "01";
            Clase.MtdCosCampoSelect();
            if (Clase.Exito)
            {
                glue_Campos.Properties.DataSource = Clase.Datos;
            }

        }

        private void CargarActividades()
        {
            glue_Actividades.Properties.DataSource = null;
            CLS_Inventum Clase = new CLS_Inventum();
            Clase.c_codigo_eps = "01";
            Clase.MtdCosActividadSelect();
            if (Clase.Exito)
            {
                glue_Actividades.Properties.DataSource = Clase.Datos;
            }

        }

        private void CargarUnidades()
        {
            glue_Unidades.Properties.DataSource = null;
            CLS_UnidadesMedida Clase = new CLS_UnidadesMedida();
            
            Clase.MtdSeleccionarUnidadesLocalShell();
            if (Clase.Exito)
            {
                glue_Unidades.Properties.DataSource = Clase.Datos;
            }

        }

        private void Frm_Actividad_Campo_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCampos();
            CargarActividades();
            CargarUnidades();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            CLS_Actividad_Campo Clase = new CLS_Actividad_Campo();
               
            Clase.c_codigo_cam = glue_Campos.EditValue.ToString().Trim();
            Clase.c_codigo_act = glue_Actividades.EditValue.ToString().Trim();
            Clase.Id_Unidad = glue_Unidades.EditValue.ToString().Trim();

            Clase.MtdInsertarActividadCampo();

            CargarGrid();
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            CLS_Actividad_Campo Clase = new CLS_Actividad_Campo();

            Clase.c_codigo_cam = glue_Campos.EditValue.ToString().Trim();
            Clase.c_codigo_act = glue_Actividades.EditValue.ToString().Trim();
            Clase.Id_Unidad = glue_Unidades.EditValue.ToString().Trim();

            Clase.MtdDeleteActividadCampo();

            CargarGrid();
        }

        private void glue_Campos_EditValueChanged(object sender, EventArgs e)
        {
            if (!check_LimpiaFiltro.Checked)
            {
                DevExpress.XtraGrid.Columns.ColumnFilterInfo FilterInfo;
                //DevExpress.XtraGrid.Columns.GridColumn columnCustomer = gridView1.Columns["c_codigo_cam"];
                gridView1.Columns["c_codigo_cam"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[c_codigo_cam] = '" + glue_Campos.EditValue.ToString() + "'");
            }
               
        }

        private void check_LimpiaFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (check_LimpiaFiltro.Checked)
            {
                gridView1.ClearColumnsFilter();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                   
                    glue_Campos.EditValue = row["c_codigo_cam"].ToString().Trim();
                    glue_Actividades.EditValue = row["c_codigo_act"].ToString();
                   
                    glue_Unidades.EditValue = row["Id_Unidad"].ToString().Trim();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}