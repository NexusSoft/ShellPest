using System;

using System.Data;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_Plagas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Plagas()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdPlagas { get; set; }
        public string Plagas { get; set; }
        public string Id_Usuario { get; set; }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";

        }

        private void CargarPlagas()
        {
            dtgPlaga.DataSource = null;
            CLS_Plagas Clase = new CLS_Plagas();

            Clase.MtdSeleccionarPlagas();
            if (Clase.Exito)
            {
                dtgPlaga.DataSource = Clase.Datos;
            }
        }

        private void InsertarPlagas()
        {
            CLS_Plagas Clase = new CLS_Plagas();

            Clase.Id_Plagas = txtId.Text.Trim();
            Clase.Nombre_Plagas = txtNombre.Text.Trim();
            Clase.Id_Usuario = Id_Usuario;

            Clase.MtdInsertarPlagas();

            if (Clase.Exito)
            {
                CargarPlagas();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarPlagas()
        {
            CLS_Plagas Clase = new CLS_Plagas();
            Clase.Id_Plagas = txtId.Text.Trim();
            Clase.MtdEliminarPlagas();
            if (Clase.Exito)
            {
                CargarPlagas();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgPlaga_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValPlaga.GetSelectedRows())
                {
                    DataRow row = this.dtgValPlaga.GetDataRow(i);
                    txtId.Text = row["Id_Plagas"].ToString();
                    txtNombre.Text = row["Nombre_Plagas"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Plagas_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarPlagas();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarPlagas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Plagas.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarPlagas();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Plagas.");
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
            IdPlagas = txtId.Text.Trim();
            Plagas = txtNombre.Text.Trim();

            this.Close();
        }
    }
}