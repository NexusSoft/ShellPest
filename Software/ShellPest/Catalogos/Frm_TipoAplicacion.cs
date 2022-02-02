using System;

using System.Data;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_TipoAplicacion : DevExpress.XtraEditors.XtraForm
    {
        public Frm_TipoAplicacion()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdTipoAplicacion { get; set; }
        public string TipoAplicacion { get; set; }
        public string Id_Usuario { get; set; }

        private void Frm_TipoAplicacion_Load(object sender, EventArgs e)
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

            CargarTipo("1");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
        }

        private void CargarTipo(string Activo)
        {
            dtgTipo.DataSource = null;
            CLS_TipoAplicacion Clase = new CLS_TipoAplicacion();
            Clase.Activo = Activo;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarTipo();
                if (Clase.Exito)
                {
                    dtgTipo.DataSource = Clase.Datos;
                }
            }          
        }

        private void InsertarTipo()
        {
            CLS_TipoAplicacion Clase = new CLS_TipoAplicacion();

            Clase.Id_TipoAplicacion = txtId.Text.Trim();
            Clase.Nombre_TipoAplicacion = txtNombre.Text.Trim();
            Clase.Usuario = Id_Usuario;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertarTipo();

                if (Clase.Exito)
                {
                    CargarTipo("1");
                    XtraMessageBox.Show("Se ha Insertado el registro con exito");
                    LimpiarCampos();
                }
                else
                {
                    XtraMessageBox.Show(Clase.Mensaje);
                }
            }
        }

        private void EliminarTipo()
        {
            CLS_TipoAplicacion Clase = new CLS_TipoAplicacion();
            Clase.Id_TipoAplicacion = txtId.Text.Trim();
            Clase.Usuario = Id_Usuario;
            if (check_Activo.Checked)
            {
                Clase.Activo = "1";
            }
            else
            {
                Clase.Activo = "0";
            }
            Clase.MtdEliminarTipo();
            if (Clase.Exito)
            {
                if (check_Activo.Checked)
                {
                    CargarTipo("0");
                }
                else
                {
                    CargarTipo("1");
                }

                XtraMessageBox.Show("Se ha Inhabilitado el asesor con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarTipo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un Tipo de aplicación.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarTipo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un tipo de aplicación.");
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdTipoAplicacion = txtId.Text.Trim();
            TipoAplicacion = txtNombre.Text.Trim();

            this.Close();
        }

        private void dtgTipo_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValAsesor.GetSelectedRows())
                {
                    DataRow row = this.dtgValAsesor.GetDataRow(i);
                    txtId.Text = row["Id_TipoAplicacion"].ToString();
                    txtNombre.Text = row["Nombre_TipoAplicacion"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void check_Activo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Activo.Checked)
            {
                CargarTipo("0");
                btnEliminar.Caption = "Habilitar";
            }
            else
            {
                CargarTipo("1");
                btnEliminar.Caption = "Inhabilitar";
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            if (check_Activo.Checked)
            {
                CargarTipo("0");
            }
            else
            {
                CargarTipo("1");
            }
            
        }
    }
}