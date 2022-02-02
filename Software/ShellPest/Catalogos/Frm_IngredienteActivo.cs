using System;
using System.Data;
using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_IngredienteActivo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_IngredienteActivo()
        {
            InitializeComponent();
        }
        public string IdIngrediente { get; set; }
        public string Ingrediente { get; set; }
        public string Id_Usuario { get; set; }

        private void Frm_IngredienteActivo_Load(object sender, EventArgs e)
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
            }
            CargarIngrediente();
        }

        private void CargarIngrediente()
        {
            dtgControl.DataSource = null;
            CLS_IngredienteActivo Clase = new CLS_IngredienteActivo();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarIngrediente();
                if (Clase.Exito)
                {
                    dtgControl.DataSource = Clase.Datos;
                }
            }

           
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dtgControl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValControl.GetSelectedRows())
                {
                    DataRow row = this.dtgValControl.GetDataRow(i);
           
                    IdIngrediente = row["c_codigo_cac"].ToString();
                    Ingrediente = row["v_nombre_cac"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void dtgControl_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarIngrediente();
        }
    }
}