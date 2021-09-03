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
        private static Frm_Bloques m_FormDefInstance;
        public static Frm_Bloques DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Bloques();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Boolean PaSel { get; set; }

        public string IdBloque { get; set; }
        public string Bloque { get; set; }
        public string Id_Usuario { get; set; }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            CargarHuertas(null);
        }

        private void CargarBloque()
        {
            dtgBloque.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarBloque();
                if (Clase.Exito)
                {
                    dtgBloque.DataSource = Clase.Datos;
                }
            }

            
        }

        private void InsertarBloque()
        {
            CLS_Bloque Clase = new CLS_Bloque();

            Clase.Id_Bloque = txtId.Text.Trim();
            Clase.Nombre_Bloque = txtNombre.Text.Trim();
            Clase.Id_Huerta = cboHuerta.EditValue.ToString();
            Clase.Id_Usuario = Id_Usuario;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
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
                    CargarHuertas(row["Id_Huerta"].ToString());
                }
                if (txtId.Text.Trim().Length > 0)
                {
                    glue_Empresa.Enabled = false;
                }
                else
                {
                    glue_Empresa.Enabled = true;
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
                dtgValBloque.OptionsFind.AlwaysVisible = true;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                glue_Empresa.Properties.DisplayMember = "v_nombre_eps";
                glue_Empresa.Properties.ValueMember = "c_codigo_eps";
                glue_Empresa.EditValue = null;
                glue_Empresa.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {


                    glue_Empresa.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
            }

            CargarBloque();
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNombre.Text.ToString().Trim().Length > 0)
            {
                if (cboHuerta.EditValue != null)
                {
                    InsertarBloque();
                }
                else
                {
                    XtraMessageBox.Show("Es necesario Seleccionar una Huerta.");
                }
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
            glue_Empresa.Enabled = true;
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

        private void btnHuerta_Click(object sender, EventArgs e)
        {
            Frm_Huertas frm = new Frm_Huertas();
            frm.PaSel = true;
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarHuertas(null);
        }

        private void Frm_Bloques_Shown(object sender, EventArgs e)
        {
            CargarHuertas(null);
        }

        
        private void CargarHuertas(string Valor)
        {
            CLS_Huerta Clase = new CLS_Huerta();
            Clase.Activo = "1";
            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarHuerta();
                if (Clase.Exito)
                {
                    cboHuerta.Properties.DisplayMember = "Nombre_Huerta";
                    cboHuerta.Properties.ValueMember = "Id_Huerta";
                    cboHuerta.EditValue = Valor;
                    cboHuerta.Properties.DataSource = Clase.Datos;
                }
            }

            
        }

        private void cboHuerta_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloque();
            CargarHuertas(null);
        }
    }
}