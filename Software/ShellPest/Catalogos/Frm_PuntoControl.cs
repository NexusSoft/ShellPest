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

        private static Frm_PuntoControl m_FormDefInstance;
        public static Frm_PuntoControl DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_PuntoControl();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public string IdPuntoControl { get; set; }
        public string PuntoControl { get; set; }
        public Boolean PaSel { get; set; }
        public string Id_Usuario { get; set; }

       

        private void CargarPuntoControl()
        {
            dtgPuntoControl.DataSource = null;
            CLS_PuntoControl Clase = new CLS_PuntoControl();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarPuntoControl();
                if (Clase.Exito)
                {
                    dtgPuntoControl.DataSource = Clase.Datos;
                }
            }

            
        }



        private void InsertarPuntoControl()
        {
            CLS_PuntoControl PuntoControl = new CLS_PuntoControl();
            PuntoControl.Id_PuntoControl = textId.Text.Trim();
            PuntoControl.Id_Bloque = cboBloque.EditValue.ToString();
            PuntoControl.Nombre_PuntoControl = textNombre.Text.Trim();
            PuntoControl.n_coordenadaX = txtX.Text;
            PuntoControl.n_coordenadaY = txtY.Text;
            PuntoControl.Id_Usuario = Id_Usuario;

            if (glue_Empresa.EditValue != null)
            {
                PuntoControl.c_codigo_eps = glue_Empresa.EditValue.ToString();
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
            CargarHuertas(null);
            cboBloque.Properties.DataSource = null;
            txtX.Text = string.Empty;
            txtY.Text = string.Empty;
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
                    CargarHuertas(row["Id_Huerta"].ToString());
                    CargarBloques(row["Id_Huerta"].ToString(), row["Id_Bloque"].ToString());
                    txtX.Text = row["n_coordenadaX"].ToString();
                    txtY.Text = row["n_coordenadaY"].ToString();
                }
                if (textId.Text.Trim().Length > 0)
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

            

            CargarPuntoControl();

            CargarHuertas(null);
            cboBloque.Properties.DataSource = null;
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
            glue_Empresa.Enabled = true;
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
            Ventana.Id_Usuario = Id_Usuario;
            Ventana.ShowDialog();
            if (cboHuerta.EditValue != null)
            {
                CargarBloques(cboHuerta.EditValue.ToString(), null);
            }
            else
            {
                cboBloque.Properties.DataSource = null;
            }
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
        private void CargarBloques(string Id_Huerta,string Valor)
        {
            CLS_Bloque Clase = new CLS_Bloque();
            Clase.Id_Huerta = Id_Huerta;
            
            Clase.MtdSeleccionarBloquesHuerta();
            if (Clase.Exito)
            {
                cboBloque.Properties.DisplayMember = "Nombre_Bloque";
                cboBloque.Properties.ValueMember = "Id_Bloque";
                cboBloque.EditValue = Valor;
                cboBloque.Properties.DataSource = Clase.Datos;
            }
        }
        private void btnHuerta_Click(object sender, EventArgs e)
        {
            Frm_Huertas frm = new Frm_Huertas();
            frm.PaSel = true;
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarHuertas(null);
            cboBloque.Properties.DataSource = null;
        }

        private void btnBloque_Click(object sender, EventArgs e)
        {
            Frm_Bloques frm = new Frm_Bloques();
            frm.PaSel = true;
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            if (cboHuerta.EditValue != null)
            {
                CargarBloques(cboHuerta.EditValue.ToString(), null);
            }
            else
            {
                cboBloque.Properties.DataSource = null;
            }
        }

        private void cboHuerta_EditValueChanged(object sender, EventArgs e)
        {
            if (cboHuerta.EditValue != null)
            {
                CargarBloques(cboHuerta.EditValue.ToString(), null);
            }
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarPuntoControl();
            CargarHuertas(null);

        }
    }
}