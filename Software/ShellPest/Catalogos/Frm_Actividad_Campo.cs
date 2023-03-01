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

namespace ShellPest.Catalogos
{
    public partial class Frm_Actividad_Campo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Actividad_Campo()
        {
            InitializeComponent();
        }


        private void CargarGrid()
        {
            gridControl1.DataSource = null;
            CLS_Actividad_Campo Clase = new CLS_Actividad_Campo();

                Clase.MtdSeleccionarActividadCampo();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
            }

        private void Frm_Actividad_Campo_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    
    }
}