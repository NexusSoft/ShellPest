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
    public partial class Frm_Presentacion : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Presentacion()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdPresentacion { get; set; }
        public string Presentacion { get; set; }
        public string Id_Usuario { get; set; }

        private void Frm_Presentacion_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarPresentacion("1");
            CargarUnidad();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";

        }

        private void CargarPresentacion(string Activo)
        {
            dtgPresentacion.DataSource = null;
            CLS_Presentacion Clase = new CLS_Presentacion();
            Clase.Activo = Activo;
            Clase.MtdSeleccionarPresentacion();
            if (Clase.Exito)
            {
                dtgPresentacion.DataSource = Clase.Datos;
            }
        }

        private void InsertarPresentacion()
        {
            CLS_Presentacion Clase = new CLS_Presentacion();

            Clase.Id_Presentacion = txtId.Text.Trim();
            Clase.Nombre_Presentacion = txtNombre.Text.Trim();
            Clase.Id_TipoAplicacion = text_Tipo.Tag.ToString().Trim();
            Clase.Id_Unidad = glue_Unidad.EditValue.ToString();
            Clase.Usuario = Id_Usuario;

            Clase.MtdInsertarPresentacion();

            if (Clase.Exito)
            {
                CargarPresentacion("1");
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarPresentacion()
        {
            CLS_Presentacion Clase = new CLS_Presentacion();
            Clase.Id_Presentacion = txtId.Text.Trim();
            Clase.Usuario = Id_Usuario;
            if (check_Activo.Checked)
            {
                Clase.Activo = "1";
            }
            else
            {
                Clase.Activo = "0";
            }
            Clase.MtdEliminarPresentacion();
            if (Clase.Exito)
            {
                if (check_Activo.Checked)
                {
                    CargarPresentacion("0");
                }
                else
                {
                    CargarPresentacion("1");
                }

                XtraMessageBox.Show("Se ha Inhabilitado la presentación con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void CargarUnidad()
        {
            glue_Unidad.EditValue = null;
            glue_Unidad.Properties.DisplayMember = "Nombre_Unidad";
            glue_Unidad.Properties.ValueMember = "Id_Unidad";
            CLS_UnidadesMedida Clase = new CLS_UnidadesMedida();
            //Clase.Activo = "1";
            Clase.MtdSeleccionarUnidadesMedida();
            if (Clase.Exito)
            {
                glue_Unidad.Properties.DataSource = Clase.Datos;
            }
        }

        private void dtgPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgVal.GetSelectedRows())
                {
                    DataRow row = this.dtgVal.GetDataRow(i);
                    txtId.Text = row["Id_Presentacion"].ToString();
                    txtNombre.Text = row["Nombre_Presentacion"].ToString();
                    text_Tipo.Tag= row["Id_TipoAplicacion"].ToString();
                    text_Tipo.Text= row["Nombre_TipoAplicacion"].ToString();
                    glue_Unidad.EditValue = row["Id_Unidad"].ToString();
                    
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
                InsertarPresentacion();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de la presentación.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarPresentacion();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Asesor.");
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdPresentacion = txtId.Text.Trim();
            Presentacion = txtNombre.Text.Trim();

            this.Close();
        }

        private void btn_Tipo_Click(object sender, EventArgs e)
        {
            Frm_TipoAplicacion Frm = new Frm_TipoAplicacion();
            Frm.PaSel = true;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            text_Tipo.Tag = Frm.IdTipoAplicacion;
            text_Tipo.Text = Frm.TipoAplicacion;
        }
    }
}