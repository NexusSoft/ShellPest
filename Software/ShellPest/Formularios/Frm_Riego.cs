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
    public partial class Frm_Riego : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Riego()
        {
            InitializeComponent();
        }

       
        public Boolean PaSel { get; set; }
        public string Id_Usuario { get; set; }



        private void CargarRiego()
        {
            dtgRiego.DataSource = null;
            CLS_Riego Riego = new CLS_Riego();
            DateTime Fecha;
            Fecha = Convert.ToDateTime(dtFecha.Text.Trim());
            Riego.Fecha_Riego = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Riego.MtdSeleccionarRiego();
            if (Riego.Exito)
            {
                dtgRiego.DataSource = Riego.Datos;
            }
        }



        private void InsertarRiego()
        {
            CLS_Riego Riego = new CLS_Riego();
            Riego.Id_Bloque = txtBloque.Tag.ToString();
            DateTime Fecha;

            Fecha = Convert.ToDateTime(dtFecha.Text.Trim());
           
            Riego.Fecha_Riego = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Riego.Horas_Riego = Convert.ToDecimal(txtHoras.Text);
           
            Riego.Id_Usuario = Id_Usuario;
            Riego.MtdInsertarRiego();
            if (Riego.Exito)
            {
                CargarRiego();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Riego.Mensaje);
            }
        }
        private void EliminarRiego()
        {
            CLS_Riego Riego = new CLS_Riego();
            Riego.Id_Bloque = txtBloque.Text.Trim();
            Riego.MtdEliminarRiego();
            if (Riego.Exito)
            {
                CargarRiego();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Riego.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            txtBloque.Text = "";
            txtHoras.Text = "";
        }

        private string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }

        private void dtgRiego_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValRiego.GetSelectedRows())
                {
                    DataRow row = this.dtgValRiego.GetDataRow(i);
                    txtBloque.Tag = row["Id_Bloque"].ToString();
                    txtBloque.Text = row["Nombre_Bloque"].ToString();
                    dtFecha.EditValue = Convert.ToDateTime(row["Fecha_Riego"]);
                    txtHoras.Text = row["Horas_Riego"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Riego_Load(object sender, EventArgs e)
        {
            dtFecha.EditValue = DateTime.Today;
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarRiego();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtBloque.Tag.ToString().Trim().Length > 0)
            {
                if (verificaBloque())
                {
                    InsertarRiego();
                }
                
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un bloque.");
            }
        }

        private Boolean verificaBloque()
        {
            foreach (int i in this.dtgValRiego.GetSelectedRows())
            {
                DataRow row = this.dtgValRiego.GetDataRow(i);
                if (row["Id_Bloque"].ToString().Trim().Equals(txtBloque.Tag.ToString().Trim()))
                {
                    DialogResult = XtraMessageBox.Show("¿Ya se agregó este bloque, Deseas reemplazar las horas ingresadas por las ya previamente agregadas?", "Bloque ya agregado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (DialogResult == DialogResult.Yes)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }

                }else
                {
                    return true;
                }
               

            }
            return true;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtBloque.Text.Trim().Length > 0 && txtHoras.Text.ToString().Trim().Length > 0)
            {
                EliminarRiego();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Riego.");
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
            
           
        }

        private void btnBloque_Click(object sender, EventArgs e)
        {
            Frm_Bloques Ventana = new Frm_Bloques();
            Ventana.PaSel = true;
            Ventana.Id_Usuario = Id_Usuario;
           
            Ventana.ShowDialog();
            txtBloque.Tag = Ventana.IdBloque.Trim();
            txtBloque.Text = Ventana.Bloque;
        }

        private void dtFecha_EditValueChanged(object sender, EventArgs e)
        {
            CargarRiego();
        }
    }
}