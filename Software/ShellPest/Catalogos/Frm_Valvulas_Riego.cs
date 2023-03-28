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
    public partial class Frm_Valvulas_Riego : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Valvulas_Riego()
        {
            InitializeComponent();
        }
        public String Id_Usuario;

        int RenglonSel = 0;

        private static Frm_Valvulas_Riego m_FormDefInstance;
        public static Frm_Valvulas_Riego DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Valvulas_Riego();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Valvulas_Riego_Load(object sender, EventArgs e)
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

        private void CargarGrid()
        {
            gridControl1.DataSource = null;
            if (textValvula.Text.Trim().Length > 0 && glue_Bloque.EditValue!=null)
            {
                CLS_Valvulas Clase = new CLS_Valvulas();

                Clase.N_Valvula = int.Parse(textValvula.Text);
                Clase.Id_Bloque = glue_Bloque.EditValue.ToString().Trim();

                Clase.MtdSeleccionarValvulasDet();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
                if (gridView1.RowCount > 0)
                {
                    if (label_Id.Text.Trim().Length == 0)
                    {
                        label_Id.Text =Clase.Datos.Rows[0][2].ToString();
                    }
                }
            }

        }

        private void glue_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void textValvula_EditValueChanged(object sender, EventArgs e)
        {
            CLS_Valvulas Clase = new CLS_Valvulas();
            Clase.Id_Bloque=glue_Bloque.EditValue.ToString();
            Clase.Id_Valvula=label_Id.Text.Trim();
            try
            {
                Clase.N_Valvula = Int32.Parse(textValvula.Text);
            }
            catch (FormatException FE)
            {

            }
            Clase.MtdSeleccionarValvulas();
            if (Clase.Exito)
            {
                try
                {
                    if (Clase.Datos.Rows.Count > 0)
                    {
                        text_Arboles.Text = Clase.Datos.Rows[0][3].ToString();
                        text_Replantes.Text = Clase.Datos.Rows[0][4].ToString();
                        text_Morras.Text = Clase.Datos.Rows[0][5].ToString();
                        label_Id.Text = Clase.Datos.Rows[0][1].ToString();
                    }
                    else
                    {
                        text_Arboles.Text = "0";
                        text_Replantes.Text = "0";
                        text_Morras.Text = "0";
                        label_Id.Text = "";
                    }
                   
                }
                catch (FormatException FE)
                {

                }
            }
            else
            {
                label_Id.Text="";
            }
            CargarGrid();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Guardar(false);
            text_Micros.Focus();

        }

        private void Guardar(Boolean SinDet)
        {
            CLS_Valvulas Clase = new CLS_Valvulas();
            if (glue_Bloque.EditValue.ToString().Trim().Length > 0)
            {
                try
                {
                    Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
                    Clase.Id_Valvula=label_Id.Text.Trim();
                    if (textValvula.Text.Trim().Length > 0)
                    {
                        Clase.N_Valvula = int.Parse(textValvula.Text);
                    }
                    else
                    {
                        Clase.N_Valvula = 0;
                    }
                    if (text_Arboles.Text.Trim().Length > 0)
                    {
                        Clase.N_Arboles = int.Parse(text_Arboles.Text);
                    }
                    else
                    {
                        Clase.N_Arboles = 0;
                    }
                    if (text_Replantes.Text.Trim().Length > 0)
                    {
                        Clase.N_Replantes = int.Parse(text_Replantes.Text);
                    }
                    else
                    {
                        Clase.N_Replantes = 0;
                    }
                    if (text_Morras.Text.Trim().Length > 0)
                    {
                        Clase.N_Morras = int.Parse(text_Morras.Text);
                    }
                    else
                    {
                        Clase.N_Morras = 0;
                    }
                    if (text_Micros.Text.Trim().Length > 0)
                    {
                        Clase.N_Micros = int.Parse(text_Micros.Text);
                    }
                    else
                    {
                        Clase.N_Micros = 0;
                    }
                    if (text_Caudal.Text.Trim().Length > 0)
                    {
                        Clase.N_Caudales = Decimal.Parse(text_Caudal.Text);
                    }
                    else
                    {
                        Clase.N_Caudales = 0;
                    }
                    if (text_M3.Text.Trim().Length > 0)
                    {
                        Clase.M3 = Decimal.Parse(text_M3.Text);
                    }
                    else
                    {
                        Clase.M3 = 0;
                    }

                    Clase.SinDet = SinDet;
                    Clase.MtdInsertarValvulas();
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

        private void Eliminar(Boolean SinDet)
        {
            CLS_Valvulas Clase = new CLS_Valvulas();
            if (glue_Bloque.EditValue.ToString().Trim().Length > 0)
            {
                try
                {
                    Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
                    if (label_Id.Text.Trim().Length > 0)
                    {
                        Clase.Id_Valvula = label_Id.Text.Trim();
                    }
                    else
                    {
                        Clase.Id_Valvula = "";
                    }
                    if (!SinDet)
                    {
                        Clase.N_Arboles = 0;
                        Clase.N_Replantes = 0;
                        Clase.N_Morras = 0;

                        foreach (int i in this.gridView1.GetSelectedRows())
                        {
                            RenglonSel = i;
                        }
                        DataRow row = this.gridView1.GetDataRow(RenglonSel);

                        Clase.N_Micros = Int32.Parse(row["N_Micros"].ToString());

                        Clase.N_Caudales = Decimal.Parse(row["N_Caudales"].ToString());

                        Clase.M3 = Decimal.Parse(row["M3"].ToString());
                    }
                    else
                    {
                        Clase.N_Arboles = 0;
                        Clase.N_Replantes = 0;
                        Clase.N_Morras = 0;
                        Clase.N_Micros = 0;

                        Clase.N_Caudales = 0;

                        Clase.M3 = 0;
                    }
                   
                   

                    Clase.SinDet = SinDet;
                    Clase.MtdEliminarValvulas();
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

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar(true);
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            Eliminar(false);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            foreach (int i in this.gridView1.GetSelectedRows())
            {
                RenglonSel = i;
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar esta Valvula?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Eliminar(true);
            }
           
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            label_Id.Text = "";
            RenglonSel = 0;
            textValvula.Text = "0";
            text_Arboles.Text = "0";
            text_Replantes.Text = "0";
            text_Morras.Text = "0";
            text_Micros.Text = "0";
            text_Caudal.Text = "0";
            text_M3.Text = "0";
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void text_M3_Properties_Enter(object sender, EventArgs e)
        {
            text_M3.SelectAll();
        }
    }
}