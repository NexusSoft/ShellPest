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
    public partial class Frm_Bloques : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Bloques()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdBloque { get; set; }
        public string Bloque { get; set; }
        public string Id_Usuario { get; set; }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtHuerta.Text = "";
            txtHuerta.Tag = "";
        }

        private void CargarBloque()
        {
            dtgBloque.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            Clase.MtdSeleccionarBloque();
            if (Clase.Exito)
            {
                dtgBloque.DataSource = Clase.Datos;
            }
        }

        private void InsertarBloque()
        {
            CLS_Bloque Clase = new CLS_Bloque();

            Clase.Id_Bloque = txtId.Text.Trim();
            Clase.Nombre_Bloque = txtNombre.Text.Trim();
            Clase.Id_Huerta = txtHuerta.Tag.ToString();
            Clase.Id_Usuario = "";

            Clase.MtdInsertarBloque();

            if (Clase.Exito)
            {
                CargarBloque();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarBloque()
        {
            CLS_Bloque Clase = new CLS_Bloque();
            Clase.Id_Bloque = txtId.Text.Trim();
            Clase.MtdEliminarBloque();
            if (Clase.Exito)
            {
                CargarBloque();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgBloque_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValBloque.GetSelectedRows())
                {
                    DataRow row = this.dtgValBloque.GetDataRow(i);
                    txtId.Text = row["Id_Bloque"].ToString();
                    txtNombre.Text = row["Nombre_Bloque"].ToString();
                    txtHuerta.Tag = row["Id_Huerta"].ToString();
                    txtHuerta.Text = row["Nombre_huerta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Bloques_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarBloque();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarBloque();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Bloque.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                EliminarBloque();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Bloque.");
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
            IdBloque = txtId.Text.Trim();
            Bloque = txtNombre.Text.Trim();

            this.Close();
        }
    }
}