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
    public partial class Frm_PuntoControl : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PuntoControl()
        {
            InitializeComponent();
        }

        public string IdPuntoControl { get; set; }
        public string PuntoControl { get; set; }
        public Boolean PaSel { get; set; }
        public string Id_Usuario { get; set; }

       

        private void CargarPuntoControl()
        {
            dtgPuntoControl.DataSource = null;
            CLS_PuntoControl PuntoControl = new CLS_PuntoControl();

            PuntoControl.MtdSeleccionarPuntoControl();
            if (PuntoControl.Exito)
            {
                dtgPuntoControl.DataSource = PuntoControl.Datos;
            }
        }



        private void InsertarPuntoControl()
        {
            CLS_PuntoControl PuntoControl = new CLS_PuntoControl();
            PuntoControl.Id_PuntoControl = textId.Text.Trim();
            PuntoControl.Id_Bloque = txtBloque.Tag.ToString();
            PuntoControl.Nombre_PuntoControl = textNombre.Text.Trim();
            PuntoControl.n_coordenadaX = txtX.Text;
            PuntoControl.n_coordenadaY = txtY.Text;
            PuntoControl.Id_Usuario = Id_Usuario;
            PuntoControl.MtdInsertarPuntoControl();
            if (PuntoControl.Exito)
            {
                CargarPuntoControl();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(PuntoControl.Mensaje);
            }
        }
        private void EliminarPuntoControl()
        {
            CLS_PuntoControl PuntoControl = new CLS_PuntoControl();
            PuntoControl.Id_PuntoControl = textId.Text.Trim();
            PuntoControl.MtdEliminarPuntoControl();
            if (PuntoControl.Exito)
            {
                CargarPuntoControl();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(PuntoControl.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
        }

        private void dtgPuntoControl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValPuntoControl.GetSelectedRows())
                {
                    DataRow row = this.dtgValPuntoControl.GetDataRow(i);
                    textId.Text = row["Id_PuntoControl"].ToString();
                    textNombre.Text = row["Nombre_PuntoControl"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_PuntoControl_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarPuntoControl();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarPuntoControl();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del PuntoControl.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0 && textNombre.Text.ToString().Trim().Length > 0)
            {
                EliminarPuntoControl();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un PuntoControl.");
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
            IdPuntoControl = textId.Text.Trim();
            PuntoControl = textNombre.Text.Trim();
            this.Close();
        }

        private void btn_Bloque_Click(object sender, EventArgs e)
        {
            Frm_Bloques Ventana = new Frm_Bloques();
            Ventana.PaSel = true;
            Ventana.ShowDialog();
            txtBloque.Tag = Ventana.IdBloque;
            txtBloque.Text = Ventana.Bloque;
        }
    }
}