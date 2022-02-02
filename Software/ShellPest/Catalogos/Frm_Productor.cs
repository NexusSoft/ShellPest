using System;

using System.Data;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_Productor : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }
        public Frm_Productor()
        {
          
            InitializeComponent();
        }

        public string IdProductor { get; set; }
        public string Productor { get; set; }
        public string Id_Usuario { get; set; }

        private void CargarProductor()
        {
            gridControl1.DataSource = null;
            CLS_Productor Clase = new CLS_Productor();
            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarProductor();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
            }
           
        }

        private void InsertarProductor()
        {
            CLS_Productor Clase = new CLS_Productor();

            Clase.Id_Productor = textId.Text.Trim();
            Clase.Nombre_Productor = textNombre.Text.Trim();
            Clase.Id_Usuario = Id_Usuario;
            Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
            Clase.MtdInsertarProductor();

            if (Clase.Exito)
            {
                CargarProductor();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarProductor()
        {
            CLS_Productor Clase = new CLS_Productor();
            Clase.Id_Productor = textId.Text.Trim();
            Clase.MtdEliminarProductor();
            if (Clase.Exito)
            {
                CargarProductor();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Productor"].ToString();
                    textNombre.Text = row["Nombre_Productor"].ToString();
                }
                if (textId.Text.Trim().Length > 0)
                {
                    glue_Empresa.Enabled = false;
                }
                else
                {
                    glue_Empresa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Dueños_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
           

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
            CargarProductor();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {


                InsertarProductor();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Productor.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 )
            {
                EliminarProductor();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Productor.");
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
            glue_Empresa.Enabled = true;
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdProductor = textId.Text.Trim();
            Productor = textNombre.Text.Trim();
            this.Close();
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarProductor();
        }
    }
}