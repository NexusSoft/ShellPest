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
    public partial class Frm_Podas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Podas()
        {
            InitializeComponent();
        }

        public string Id_Usuario { get; set; }

        Boolean FocoDetalle;

        private static Frm_Podas m_FormDefInstance;
        public static Frm_Podas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Podas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Podas_Load(object sender, EventArgs e)
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
                de_Fecha.EditValue = DateTime.Today;
                CargarHuertas();
                CargarActividades();
                CargarGridPodas(false);
            }
            FocoDetalle = false;
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
                Clase.TipoBloque = "B";
                Clase.MtdSeleccionarBloquesHuerta();
                if (Clase.Exito)
                {
                    glue_Bloque.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarActividades()
        {
            glue_Actividad.Properties.DataSource = null;
            WS_Catalogos_cosactividad Clase = new WS_Catalogos_cosactividad();

            if (glue_Empresa.EditValue != null)
            {
                Clase.MtdSeleccionarActividad();
                if (Clase.Exito)
                {
                    glue_Actividad.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void InsertarPodas()
        {
            WS_Control_Podas_Insert Clase = new WS_Control_Podas_Insert();
            Clase.Fecha =  de_Fecha.EditValue.ToString();
            Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
            Clase.N_arboles = Int32.Parse( te_NArboles.Text);
            Clase.Observaciones = te_Observaciones.Text.Trim();
            Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
            Clase.Id_Usuario_Crea = Id_Usuario;
            Clase.actividad = glue_Actividad.EditValue.ToString();
            Clase.MtdInsertarPodas();

        }

        private void EliminarPodas()
        {
            WS_Control_Podas_Insert Clase = new WS_Control_Podas_Insert();
            Clase.Fecha = de_Fecha.EditValue.ToString();
            Clase.Id_Bloque = glue_Bloque.EditValue.ToString();
            if (FocoDetalle)
            {
                Clase.detalle = 1;
            }
            else
            {
                Clase.detalle = 0;
            }
            
           
            Clase.actividad = glue_Actividad.EditValue.ToString();
            Clase.MtdDeletePodas();

        }

        private void CargarGridPodas(Boolean sino)
        {
            gc_Poda.DataSource = null;
            WS_Control_Podas Clase = new WS_Control_Podas();
           

            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
 
            Clase.PodasSelect();
            if (Clase.Exito)
            {
                gc_Poda.DataSource = Clase.Datos;
            }

            if (gridView5.RowCount > 0)
            {
                SeleccionaUltimoycargaDet(sino);
            }
            else
            {
                gc_Det.DataSource = null;
            }

        }
        private void SeleccionaUltimoycargaDet(Boolean sino)
        {
            try
            {
                DataRow row;
                if (!sino)
                {
                    row = this.gridView5.GetDataRow(gridView5.RowCount - 1);
                    //gridView5.SelectRow(gridView5.RowCount );

                    int focusedRow = gridView5.RowCount - 1;

                    gridView5.FocusedRowHandle = focusedRow;
                    gridView5.SelectRow(focusedRow);
                    gridView5.Focus();
                }
                else
                {
                    row = this.gridView5.GetDataRow(0); 
                }
               

                CargarGridPodasDet(row["Id_bloque"].ToString());

                /*gridControl1.DataSource = null;
                WS_Control_Podas Clase = new WS_Control_Podas();


                DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
                Clase.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
                Clase.Id_bloque= row["Id_bloque"].ToString();
                Clase.PodasDetSelect();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }*/

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void CargarGridPodasDet(string Bloque)
        {
            gc_Det.DataSource = null;
            WS_Control_Podas Clase = new WS_Control_Podas();


            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_bloque = Bloque;
            Clase.PodasDetSelect();
            if (Clase.Exito)
            {
                gc_Det.DataSource = Clase.Datos;
            }
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

        private void EditarCamposG(string huerta,string bloque,string arboles,string observaciones)
        {
            glue_Huerta.EditValue = huerta;
            glue_Bloque.EditValue = bloque;
            te_NArboles.Text = arboles;
            te_Observaciones.Text = observaciones;
            

        }

        private Boolean RRecorreyBuscaBloque()
        {
            int NRenglones = gridView5.RowCount;
            DataRow row;
            for (int i = 0; i < NRenglones; i++)
            {
                row = this.gridView5.GetDataRow(i);
                if (glue_Bloque.EditValue.Equals(row["Id_bloque"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private void EditarCamposD(string actividad)
        {
            glue_Actividad.EditValue = actividad;
        }

        private void glue_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Boolean sino;
            sino = RRecorreyBuscaBloque();
            InsertarPodas();
            CargarGridPodas(sino);
        }

        

        private void gridView5_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                foreach (int i in this.gridView5.GetSelectedRows())
                {
                    DataRow row = this.gridView5.GetDataRow(i);

                    CargarGridPodasDet(row["Id_bloque"].ToString());
                    EditarCamposG(row["Id_Huerta"].ToString(), row["Id_bloque"].ToString(),  row["N_arboles"].ToString(), row["Observaciones"].ToString());

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);

                   
                    EditarCamposD( row["actividad"].ToString());

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void de_Fecha_EditValueChanged(object sender, EventArgs e)
        {
            CargarGridPodas(false);
        }

        private void gc_Det_Click(object sender, EventArgs e)
        {
            FocoDetalle = true;
            
        }

        private void gc_Poda_Click(object sender, EventArgs e)
        {
            FocoDetalle = false;
            
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if(FocoDetalle) 
            {
                if (gridView1.RowCount == 1)
                {
                    if (MessageBox.Show("Seleccionaste la unica actividad de ese bloque,Deseas continuar y eliminar?, se eliminara el bloque completo", "Se eliminara el bloque", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FocoDetalle = false;
                        EliminarPodas();
                        CargarGridPodas(false);

                    }
                }
                else
                {
                    EliminarPodas();
                    CargarGridPodas(true);
                    FocoDetalle = false;
                }

               
            }
            else
            {
                EliminarPodas();
                CargarGridPodas(false);
                FocoDetalle = false;
            }
            
        }
    }
}