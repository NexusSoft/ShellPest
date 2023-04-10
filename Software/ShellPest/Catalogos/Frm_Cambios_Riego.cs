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
    public partial class Frm_Cambios_Riego : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Cambios_Riego()
        {
            InitializeComponent();
        }

        private static Frm_Cambios_Riego m_FormDefInstance;
        public static Frm_Cambios_Riego DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Cambios_Riego();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public String Id_Usuario;

        int RenglonSel = 0;

        private void Frm_Cambios_Riego_Load(object sender, EventArgs e)
        {
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

                CargarHuertas();
            }
        }

        private void CargarHuertas()
        {
            glue_Huerta.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarHuerta();
                if (Clase.Exito)
                {
                    glue_Huerta.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarBloques()
        {
            glue_Bloque.Properties.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            if (glue_Empresa.EditValue != null)
            {
                Clase.Id_Huerta = glue_Huerta.EditValue.ToString();
                Clase.TipoBloque = "R";
                Clase.MtdSeleccionarBloquesHuerta();
                if (Clase.Exito)
                {
                    glue_Bloque.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarValvulas()
        {
            glue_Valvula.Properties.DataSource = null;
            CLS_Cambios_Riego Clase = new CLS_Cambios_Riego();

            if (glue_Bloque.EditValue != null)
            {
                Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
                Clase.MtdSeleccionarCargarValvulas();
                if (Clase.Exito)
                {
                    glue_Valvula.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarGrid()
        {
            gridControl1.DataSource = null;
            if (textCambio.Text.Trim().Length > 0 && glue_Bloque.EditValue != null)
            {
                CLS_Cambios_Riego Clase = new CLS_Cambios_Riego();
                Clase.N_Cambio = textCambio.Text.Trim();

                Clase.Id_Bloque = glue_Bloque.EditValue.ToString().Trim();

                Clase.MtdSeleccionarCambiosRiego();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
                if (gridView1.RowCount > 0)
                {
                    if (label_Id.Text.Trim().Length == 0)
                    {
                        label_Id.Text = Clase.Datos.Rows[0][0].ToString();
                    }
                }
                else
                {
                    label_Id.Text = "";
                }
                
            }

        }

        private void glue_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void textCambio_EditValueChanged(object sender, EventArgs e)
        {
            CargarGrid();


        }

        private void glue_Bloque_EditValueChanged(object sender, EventArgs e)
        {
            CargarValvulas();
        }

        private void Guardar(Boolean SinDet)
        {
            CLS_Cambios_Riego Clase = new CLS_Cambios_Riego();
            if (glue_Bloque.EditValue.ToString().Trim().Length > 0)
            {
                try
                {
                    Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
                    if (label_Id.Text.Trim().Length > 0)
                    {
                        Clase.Id_Cambio = label_Id.Text.Trim();
                    }
                    else
                    {
                        Clase.Id_Cambio = "";
                    }
                    
                    Clase.N_Cambio=textCambio.Text.Trim();
                    if (glue_Valvula.EditValue!=null)
                    {
                        Clase.Id_Valvula = glue_Valvula.EditValue.ToString().Trim();
                    }
                   

                    Clase.SinDet = SinDet;
                    Clase.MtdInsertarCambios();
                    if (Clase.Exito)
                    {
                        CargarGrid();

                        MessageBox.Show("Datos Guardados correctamente", "GUARDADO", MessageBoxButtons.OK);
                    }

                }
                catch (FormatException FE)
                {

                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Guardar(false);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar(true);
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            Eliminar(false);
        }

        private void Eliminar(Boolean SinDet)
        {
            CLS_Cambios_Riego Clase = new CLS_Cambios_Riego();
            if (glue_Bloque.EditValue.ToString().Trim().Length > 0)
            {
                try
                {
                    Clase.Id_Bloque = glue_Bloque.EditValue.ToString();

                    if (label_Id.Text.Trim().Length > 0)
                    {
                        Clase.Id_Cambio = label_Id.Text.Trim();
                    }
                    else
                    {
                        Clase.Id_Cambio = "";
                    }

                    
                        
                   
                    if (!SinDet)
                    {
                       

                        foreach (int i in this.gridView1.GetSelectedRows())
                        {
                            RenglonSel = i;
                        }
                        DataRow row = this.gridView1.GetDataRow(RenglonSel);

                        Clase.Id_Valvula = row["Id_Valvula"].ToString();

                        
                    }
                   



                    Clase.SinDet = SinDet;
                    Clase.MtdEliminarCambiosRiego();
                    if (Clase.Exito)
                    {
                        if (!SinDet)
                        {
                            CargarGrid();
                        }
                        else
                        {
                            LimpiarCampos();
                        }

                    }

                }
                catch (FormatException FE)
                {

                }
            }
        }

        private void LimpiarCampos()
        {
            label_Id.Text = "";
            RenglonSel = 0;
            textCambio.Text = "";
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar este Cambio?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Eliminar(true);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }
    }
}