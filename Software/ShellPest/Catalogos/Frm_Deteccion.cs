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
    public partial class Frm_Deteccion : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Deteccion()
        {
            InitializeComponent();
        }

        public Boolean PaSel { get; set; }

        public string IdDeteccion { get; set; }
        public string Deteccion { get; set; }
        public string Id_Usuario { get; set; }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
            
        }

        private void CargarDetecion()
        {
            dtgDeteccion.DataSource = null;
            CLS_Deteccion Clase = new CLS_Deteccion();

            Clase.MtdSeleccionarDeteccion();
            if (Clase.Exito)
            {
                dtgDeteccion.DataSource = Clase.Datos;
            }
        }

        private void InsertarDeteccion()
        {
            CLS_Deteccion Clase = new CLS_Deteccion();

            Clase.Id_Deteccion = textId.Text.Trim();
            Clase.Nombre_Deteccion= textNombre.Text.Trim();
            Clase.Id_Usuario = "";

            Clase.MtdInsertarDeteccion();

            if (Clase.Exito)
            {
                CargarDetecion();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarDeteccion()
        {
            CLS_Deteccion Clase = new CLS_Deteccion();
            Clase.Id_Deteccion = textId.Text.Trim();
            Clase.MtdEliminarDeteccion();
            if (Clase.Exito)
            {
                CargarDetecion();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgDeteccion_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValDeteccion.GetSelectedRows())
                {
                    DataRow row = this.dtgValDeteccion.GetDataRow(i);
                    textId.Text = row["Id_Deteccion"].ToString();
                    textNombre.Text = row["Nombre_Deteccion"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Deteccion_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarDetecion();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarDeteccion();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de la detección.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                EliminarDeteccion();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una detección.");
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
            IdDeteccion = textId.Text.Trim();
            Deteccion = textNombre.Text.Trim();
            
            this.Close();
        }
    }
}