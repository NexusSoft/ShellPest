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
    public partial class Frm_Lugar_Campo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Lugar_Campo()
        {
            InitializeComponent();
        }

        private void Frm_Lugar_Campo_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarLugar();
            CargarCampo();
        }

        private void CargarGrid()
        {

            gridControl1.DataSource = null;
            CLS_Lugar_Campo Clase = new CLS_Lugar_Campo();

  
            Clase.MtdSeleccionarLugarCampo();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
           

        }

        private void CargarLugar()
        {
            glue_Lugar.Properties.DataSource = null;
            CLS_Lugar_Campo Clase = new CLS_Lugar_Campo();

            if (glue_Lugar.EditValue != null)
            {
                
                Clase.MtdSeleccionarLugar();
                if (Clase.Exito)
                {
                    glue_Lugar.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarCampo()
        {
            glue_Campo.Properties.DataSource = null;
            CLS_Lugar_Campo Clase = new CLS_Lugar_Campo();

            if (glue_Campo.EditValue != null)
            {

                Clase.MtdSeleccionarCampo();
                if (Clase.Exito)
                {
                    glue_Campo.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS_Lugar_Campo Clase = new CLS_Lugar_Campo();
            
            Clase.c_codigo_cam = glue_Campo.EditValue.ToString();
            Clase.c_codigo_lug = glue_Lugar.EditValue.ToString();
            
            Clase.MtdInsertarLugarCampo();
            CargarGrid();
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            CLS_Lugar_Campo Clase = new CLS_Lugar_Campo();

            Clase.c_codigo_cam = glue_Campo.EditValue.ToString();
            Clase.c_codigo_lug = glue_Lugar.EditValue.ToString();

            Clase.MtdEliminarLugarCampo();
            CargarGrid();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    glue_Lugar.EditValue = row["c_codigo_lug"].ToString();
                    glue_Campo.EditValue = row["c_codigo_cam"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}