using System;
using System.Data;
using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_EstFenologico : DevExpress.XtraEditors.XtraForm
    {
        public Frm_EstFenologico()
        {
            InitializeComponent();
        }

        public string IdEstFen { get; set; }
        public string EstFen { get; set; }
        public string VPoE { get; set; }

        public Boolean PaSel { get; set; }

        private void rg_PoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rg_PoE.EditValue.Equals('P'))
            {
                l_nombre.Text = "Fenologico:";
            }
            else
            {
                l_nombre.Text = "Sintomatología:";
            }
            CargarEstFen();
        }

        private void Frm_EstFenologico_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            rg_PoE.EditValue = 'P';
            CargarEstFen();
        }

        private void CargarEstFen()
        {
            gridControl1.DataSource = null;
            CLS_Estado_Fenologico Estado = new CLS_Estado_Fenologico();
            Estado.PoE = rg_PoE.EditValue.ToString().Trim();
            Estado.MtdSeleccionarFenologico();
            if (Estado.Exito)
            {
                gridControl1.DataSource = Estado.Datos;
            }
        }

        private void InsertarEstFen()
        {
            CLS_Estado_Fenologico Estado = new CLS_Estado_Fenologico();
            Estado.Id_Fenologico = textIdEstado.Text.Trim();
            Estado.Nombre_Fenologico = textEstado.Text.Trim();
            Estado.PoE = rg_PoE.EditValue.ToString();
            Estado.MtdInsertarFenologico();
            if (Estado.Exito)
            {

                CargarEstFen();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Estado.Mensaje);
            }
        }

        private void EliminarEstFen()
        {
            CLS_Estado_Fenologico Estado = new CLS_Estado_Fenologico();
            Estado.Id_Fenologico = textIdEstado.Text.Trim();
            Estado.MtdEliminarFenologico();
            if (Estado.Exito)
            {
                CargarEstFen();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Estado.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textIdEstado.Text = "";
            textEstado.Text = "";
           
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textEstado.Text.ToString().Trim().Length > 0)
            {
                if (textEstado.Text.ToString().Trim().Length > 0)
                {
                    InsertarEstFen();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario seleccionar un nombre del pais.");
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre al estado.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textIdEstado.Text.Trim().Length > 0)
            {
                EliminarEstFen();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Estado.");
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdEstFen = textIdEstado.Text.Trim();
            EstFen = textEstado.Text.Trim();
            VPoE = rg_PoE.EditValue.ToString();
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textIdEstado.Text = row["Id_Fenologico"].ToString();
                    textEstado.Text = row["Nombre_Fenologico"].ToString();
                    rg_PoE.EditValue = Convert.ToChar(row["PoE"]);
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}