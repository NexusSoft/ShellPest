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
    public partial class Frm_Enfermedades : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Enfermedades()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdEnfermedad { get; set; }
        public string Enfermedad { get; set; }
        public string Id_Usuario { get; set; }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
           
        }

        private void CargarEnfermedad()
        {
            dtgEnfermedad.DataSource = null;
            CLS_Enfermedad Clase = new CLS_Enfermedad();

            Clase.MtdSeleccionarEnfermedad();
            if (Clase.Exito)
            {
                dtgEnfermedad.DataSource = Clase.Datos;
            }
        }

        private void InsertarEnfermedad()
        {
            CLS_Enfermedad Clase = new CLS_Enfermedad();

            Clase.Id_Enfermedad = txtId.Text.Trim();
            Clase.Nombre_Enfermedad = txtNombre.Text.Trim();
            Clase.Id_Usuario = "";

            Clase.MtdInsertarEnfermedad();

            if (Clase.Exito)
            {
                CargarEnfermedad();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarEnfermedad()
        {
            CLS_Enfermedad Clase = new CLS_Enfermedad();
            Clase.Id_Enfermedad = txtId.Text.Trim();
            Clase.MtdEliminarEnfermedad();
            if (Clase.Exito)
            {
                CargarEnfermedad();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgEnfermedad_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValEnfermedad.GetSelectedRows())
                {
                    DataRow row = this.dtgValEnfermedad.GetDataRow(i);
                    txtId.Text = row["Id_Enfermedad"].ToString();
                    txtNombre.Text = row["Nombre_Enfermedad"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Enfermedades_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarEnfermedad();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarEnfermedad();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Enfermedad.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarEnfermedad();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Enfermedad.");
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdEnfermedad = txtId.Text.Trim();
            Enfermedad = txtNombre.Text.Trim();

            this.Close();
        }
    }
}