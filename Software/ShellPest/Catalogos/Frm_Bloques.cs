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

        string vtCampo;

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            CargarHuertas();
        }

        private void CargarBloque()
        {
            dtgBloque.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();
            Clase.TipoBloque = glue_TipoBloque.EditValue.ToString().Trim();
            if (check_Activo.Checked
                )
            {
                Clase.Activo = 0;
                btnEliminar.Caption = "Habilitar";
                btnGuardar.Enabled = false;
            }
            else
            {
                Clase.Activo = 1;
                btnEliminar.Caption = "Inhabilitar";
                btnGuardar.Enabled = true;
            }
            
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

        private void CargarCoslote()
        {
            glue_CC.Properties.DataSource = null;
            CLS_Inventum Clase = new CLS_Inventum();

            
            Clase.c_codigo_cam = vtCampo;
            Clase.MtdCosloteSelect();
            if (Clase.Exito)
            {
                glue_CC.Properties.DisplayMember = "v_nombre_lot";
                glue_CC.Properties.ValueMember = "c_codigo_lot";
                glue_CC.EditValue = null;
                glue_CC.Properties.DataSource = Clase.Datos;
            }
            
        }

        private void CargarTipoBloque()
        {
            CLS_Bloque Clase = new CLS_Bloque();
           
            if (glue_TipoBloque.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarTipoBloque();
                if (Clase.Exito)
                {
                    glue_TipoBloque.Properties.DisplayMember = "Nombre_TipoBloque";
                    glue_TipoBloque.Properties.ValueMember = "TipoBloque";
                    glue_TipoBloque.EditValue = 'B';
                    glue_TipoBloque.Properties.DataSource = Clase.Datos;
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
            Clase.TipoBloque = glue_TipoBloque.EditValue.ToString().Trim();
            if (glue_CC.EditValue!= null)
            {
                Clase.c_codigo_lot = glue_CC.EditValue.ToString();
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
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Lote para el centro de contos");
            }
            

           
        }

        private void EliminarBloque()
        {
            CLS_Bloque Clase = new CLS_Bloque();
            Clase.Id_Bloque = txtId.Text.Trim();
            if (check_Activo.Checked)
            {
                Clase.Activo = 1;
            }
            else
            {
                Clase.Activo = 0;
            }
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
                    
                    cboHuerta.EditValue = row["Id_Huerta"].ToString();
                   
                    glue_TipoBloque.EditValue= row["TipoBloque"].ToString();
                    vtCampo= row["c_codigo_cam"].ToString();
                    CargarCoslote();
                    glue_CC.EditValue= row["c_codigo_lot"].ToString();
                    
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

            CargarTipoBloque();

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
            CargarCoslote();
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
            CargarHuertas();
        }

        private void Frm_Bloques_Shown(object sender, EventArgs e)
        {
            CargarHuertas();
        }

        
        private void CargarHuertas()
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
                    cboHuerta.EditValue = null;
                    cboHuerta.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void cboHuerta_EditValueChanged(object sender, EventArgs e)
        {
           
            try
            {

                foreach (int i in this.gridLookUpEdit1View.GetSelectedRows())
                {
                    DataRow row = this.gridLookUpEdit1View.GetDataRow(i);
                    vtCampo = row["c_codigo_cam"].ToString();

                }
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            CargarCoslote();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloque();
            CargarHuertas();
        }

        private void glue_TipoBloque_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloque();
        }

        private void check_Activo_CheckedChanged(object sender, EventArgs e)
        {
            CargarBloque();
        }

        
    }
}