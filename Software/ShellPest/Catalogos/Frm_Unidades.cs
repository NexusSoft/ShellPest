using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_Unidades : DevExpress.XtraEditors.XtraForm
    {

        public String Id_Usuario;
        public Frm_Unidades()
        {
            InitializeComponent();
        }

        private void Frm_Unidades_Load(object sender, EventArgs e)
        {
            CargarUnidades();
            LimpiarCampos();
        }

        private void CargarUnidades()
        {
            gridControl1.DataSource = null;
            CLS_UnidadesMedida Clase = new CLS_UnidadesMedida();

            Clase.MtdSeleccionarUnidadesLocalShell();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
            textAbrevia.Text = "";
        }

        private void InsertarUnidades()
        {
            CLS_UnidadesMedida Clase = new CLS_UnidadesMedida();

            Clase.Id_Unidad = textId.Text.Trim();
            Clase.Nombre_Unidad = textNombre.Text.Trim();
            Clase.Abreviatura = textAbrevia.Text.Trim();
            Clase.Usuario = Id_Usuario;
            Clase.MtdInsertarUnidadesMedida();

            if (Clase.Exito)
            {
                CargarUnidades();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarUnidades();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de una ciudad.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                EliminarUnidad();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar una ciudad.");
            }
        }

        private void EliminarUnidad()
        {
            CLS_UnidadesMedida Clase = new CLS_UnidadesMedida();
            Clase.Id_Unidad = textId.Text.Trim();
            Clase.Usuario = Id_Usuario;
            Clase.Activo = "0";
            Clase.MtdEliminarUnidadesMedida();
            if (Clase.Exito)
            {
                CargarUnidades();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Unidad"].ToString();
                    textNombre.Text = row["Nombre_Unidad"].ToString();
                    textAbrevia.Text = row["Abreviatura"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}