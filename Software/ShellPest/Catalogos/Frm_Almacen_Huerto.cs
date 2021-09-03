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
    public partial class Frm_Almacen_Huerto : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Almacen_Huerto()
        {
            InitializeComponent();
        }
        public string Id_Usuario { get; set; }

        private void Frm_Almacen_Huerto_Load(object sender, EventArgs e)
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
            }
            CargarAlmacenHuerta();
            CargarAlmacen();
            CargarHuerta();
        }

        private void CargarAlmacenHuerta()
        {
            gridControl1.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarAlmHue();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }
            }

            
        }


        private void CargarAlmacen()
        {
            glue_Almacen.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();
            

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarAlmacen();
                if (Clase.Exito)
                {
                    glue_Almacen.Properties.DataSource = Clase.Datos;
                }
            }

            
        }

        private void CargarHuerta()
        {
            glue_Huerto.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();
            Clase.MtdSeleccionarHuerta();
            if (Clase.Exito)
            {
                glue_Huerto.Properties.DataSource = Clase.Datos;
            }

        }

        private Boolean recorrerPaNoDuplica()
        {
            for (int x = 0; x < gridValue.RowCount; x++)
            {
                int xRow = gridValue.GetVisibleRowHandle(x);

                if (gridValue.GetRowCellValue(xRow, gridValue.Columns["c_codigo_alm"]).ToString().Equals(glue_Almacen.EditValue.ToString()))
                {
                    return false; 
                }

            }
            return true;
        }

        private void InsertarAlmacenHuerta()
        {
            
            if (recorrerPaNoDuplica())
            {
                CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

                Clase.c_codigo_alm = glue_Almacen.EditValue.ToString();
                Clase.c_codigo_hue = glue_Huerto.EditValue.ToString();

                if (glue_Empresa.EditValue != null)
                {
                    Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                    Clase.MtdInsertarAlmHue();

                    if (Clase.Exito)
                    {
                        CargarAlmacenHuerta();
                        XtraMessageBox.Show("Se ha Insertado el registro con exito");

                    }
                    else
                    {
                        XtraMessageBox.Show(Clase.Mensaje);
                    }
                }

                
            }
            else
            {
                XtraMessageBox.Show("Almacen ya ingresado, favor de verificar los datos ingresados.");
            }
            
        }

        private void EliminarAlmacenHuerta()
        {
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();
            Clase.c_codigo_alm = glue_Almacen.EditValue.ToString();
            Clase.c_codigo_hue = glue_Huerto.EditValue.ToString();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdEliminarAlmhue();
                if (Clase.Exito)
                {
                    CargarAlmacenHuerta();
                    XtraMessageBox.Show("Se ha Eliminado el registro con exito");

                }
                else
                {
                    XtraMessageBox.Show(Clase.Mensaje);
                }
            }

            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridValue.GetSelectedRows())
                {
                    DataRow row = this.gridValue.GetDataRow(i);
                    glue_Almacen.EditValue = row["c_codigo_alm"].ToString();
                    glue_Huerto.EditValue = row["c_codigo_hue"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (glue_Almacen.EditValue!=null && glue_Huerto.EditValue!=null)
            {
                InsertarAlmacenHuerta();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre del Plagas.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (glue_Almacen.EditValue != null && glue_Huerto.EditValue != null)
            {
                EliminarAlmacenHuerta();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un Plagas.");
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Down)
            {
                try
                {
                    foreach (int i in this.gridValue.GetSelectedRows())
                    {
                        DataRow row = this.gridValue.GetDataRow(i);
                        glue_Almacen.EditValue = row["c_codigo_alm"].ToString();
                        glue_Huerto.EditValue = row["c_codigo_hue"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
           if(e.KeyCode == Keys.Up)
            {
                try
                {
                    foreach (int i in this.gridValue.GetSelectedRows())
                    {
                        DataRow row = this.gridValue.GetDataRow(i);
                        glue_Almacen.EditValue = row["c_codigo_alm"].ToString();
                        glue_Huerto.EditValue = row["c_codigo_hue"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarAlmacenHuerta();
            CargarAlmacen();
            CargarHuerta();
        }
    }
}