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
    public partial class Frm_Individuos : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }

        public Frm_Individuos()
        {
            InitializeComponent();
        }

        public string IdIndividuo { get; set; }
        public string Individuo { get; set; }
        public string Id_Usuario { get; set; }

        private void CargarIndividuo()
        {
            gridControl1.DataSource = null;
            CLS_Individuo Clase = new CLS_Individuo();

            Clase.MtdSeleccionarIndividuo();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void InsertarCultivo()
        {
            CLS_Individuo Clase = new CLS_Individuo();

            Clase.Id_Individuo = textId.Text.Trim();
            Clase.No_Individuo = textNombre.Text.Trim();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdInsertarIndividuo();

            if (Clase.Exito)
            {
                CargarIndividuo();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarCultivo()
        {
            CLS_Individuo Clase = new CLS_Individuo();
            Clase.Id_Individuo = textId.Text.Trim();
            Clase.MtdEliminarIndividuo();
            if (Clase.Exito)
            {
                CargarIndividuo();
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
                    textId.Text = row["Id_Individuo"].ToString();
                    textNombre.Text = row["No_Individuo"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Cultivo_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarIndividuo();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarCultivo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de un cultivo.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                EliminarCultivo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un cultivo.");
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
            IdIndividuo = textId.Text.Trim();
            Individuo = textNombre.Text.Trim();
            this.Close();
        }
    }
}