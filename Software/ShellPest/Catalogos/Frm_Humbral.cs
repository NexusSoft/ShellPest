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
    public partial class Frm_Humbral : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Humbral()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdHumbral { get; set; }
        public string Humbral { get; set; }
        public string Id_Usuario { get; set; }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtValor.Text = "";
            txtColor.Text = "";
        }

        private void CargarHumbral()
        {
            dtgHumbral.DataSource = null;
            CLS_Humbral Clase = new CLS_Humbral();

            Clase.MtdSeleccionarHumbral();
            if (Clase.Exito)
            {
                dtgHumbral.DataSource = Clase.Datos;
            }
        }

        private void InsertarHumbral()
        {
            CLS_Humbral Clase = new CLS_Humbral();

            Clase.Id_Humbral = txtId.Text.Trim();
            Clase.Nombre_Humbral = txtNombre.Text.Trim();
            Clase.Valor_Humbral = txtValor.Text.Trim();
            Clase.Color_Humbral = txtColor.Text.Trim();
            Clase.Id_Usuario = Id_Usuario;

            Clase.MtdInsertarHumbral();

            if (Clase.Exito)
            {
                CargarHumbral();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarHumbral()
        {
            CLS_Humbral Clase = new CLS_Humbral();
            Clase.Id_Humbral = txtId.Text.Trim();
            Clase.MtdEliminarHumbral();
            if (Clase.Exito)
            {
                CargarHumbral();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgHumbral_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValHumbral.GetSelectedRows())
                {
                    DataRow row = this.dtgValHumbral.GetDataRow(i);
                    txtId.Text = row["Id_Humbral"].ToString();
                    txtNombre.Text = row["Nombre_Humbral"].ToString();
                    txtValor.Text = row["Valor_Humbral"].ToString();
                    txtColor.Text = row["Color_Humbral"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Humbral_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarHumbral();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarHumbral();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Humbral.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarHumbral();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Humbral.");
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
            IdHumbral = txtId.Text.Trim();
            Humbral = txtNombre.Text.Trim();

            this.Close();
        }

    }
}