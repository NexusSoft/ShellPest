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
    public partial class Frm_AsesorTecnico : DevExpress.XtraEditors.XtraForm
    {
        public Frm_AsesorTecnico()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdAsesor { get; set; }
        public string Asesor { get; set; }
        public string Id_Usuario { get; set; }

        private void Frm_AsesorTecnico_Load(object sender, EventArgs e)
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

            CargarAsesor("1");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";

        }

        private void CargarAsesor(string Activo)
        {
            dtgAsesor.DataSource = null;
            CLS_Asesor_Tecnico Clase = new CLS_Asesor_Tecnico();
            Clase.Activo = Activo;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarAsesor();
                if (Clase.Exito)
                {
                    dtgAsesor.DataSource = Clase.Datos;
                }
            }

            
        }

        private void InsertarAsesor()
        {
            CLS_Asesor_Tecnico Clase = new CLS_Asesor_Tecnico();

            Clase.Id_AsesorTecnico = txtId.Text.Trim();
            Clase.Nombre_AsesorTecnico = txtNombre.Text.Trim();
            Clase.Usuario = Id_Usuario;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertarAsesor();

                if (Clase.Exito)
                {
                    CargarAsesor("1");
                    XtraMessageBox.Show("Se ha Insertado el registro con exito");
                    LimpiarCampos();
                }
                else
                {
                    XtraMessageBox.Show(Clase.Mensaje);
                }
            }

           
        }

        private void EliminarAsesor()
        {
            CLS_Asesor_Tecnico Clase = new CLS_Asesor_Tecnico();
            Clase.Id_AsesorTecnico = txtId.Text.Trim();
            Clase.Usuario = Id_Usuario;
            if (check_Activo.Checked)
            {
                Clase.Activo="1";
            }
            else
            {
                Clase.Activo = "0";
            }
            Clase.MtdEliminarAsesor();
            if (Clase.Exito)
            {
                if (check_Activo.Checked )
                {
                    CargarAsesor("0");
                }
                else
                {
                    CargarAsesor("1");
                }
                
                XtraMessageBox.Show("Se ha Inhabilitado el asesor con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgAsesor_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValAsesor.GetSelectedRows())
                {
                    DataRow row = this.dtgValAsesor.GetDataRow(i);
                    txtId.Text = row["Id_AsesorTecnico"].ToString();
                    txtNombre.Text = row["Nombre_AsesorTecnico"].ToString();

                }
                if (txtId.Text.Trim().Length > 0)
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

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarAsesor();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Asesor.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarAsesor();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Asesor.");
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
            IdAsesor = txtId.Text.Trim();
            Asesor = txtNombre.Text.Trim();

            this.Close();
        }

        private void check_Activo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Activo.Checked)
            {
                CargarAsesor("0");
                btnEliminar.Caption = "Habilitar";
            }
            else
            {
                CargarAsesor("1");
                btnEliminar.Caption = "Inhabilitar";
            }
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            if (check_Activo.Checked)
            {
                CargarAsesor("0");
            }
            else
            {
                CargarAsesor("1");
            }
        }
    }
}