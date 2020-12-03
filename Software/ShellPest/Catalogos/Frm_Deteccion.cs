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


namespace ShellPest.Catalogos
{
    public partial class Frm_Deteccion : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Deteccion()
        {
            InitializeComponent();
        }

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

    }
}