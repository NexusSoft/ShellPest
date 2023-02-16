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
    public partial class Frm_Combustibles : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Combustibles()
        {
            InitializeComponent();
        }

        public string Id_Usuario { get; set; }
        string Gbloques;

        private static Frm_Combustibles m_FormDefInstance;
        public static Frm_Combustibles DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Combustibles();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Combustibles_Load(object sender, EventArgs e)
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;

            
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                glue_Empresas.Properties.DisplayMember = "v_nombre_eps";
                glue_Empresas.Properties.ValueMember = "c_codigo_eps";
                glue_Empresas.EditValue = null;
                glue_Empresas.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {


                    glue_Empresas.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
                de_Fecha.EditValue = DateTime.Today;
                CargarHuertas();
                CargarResponsables();
                CargarTipoGas();
                //CargarGridPodas(false);
            }

            rg_IoS.EditValue = 'S';
        }

        private void CargarHuertas()
        {
            glue_Huertas.Properties.DataSource = null;
            CLS_Almacen_Huerto Clase = new CLS_Almacen_Huerto();

            if (glue_Empresas.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresas.EditValue.ToString();
                Clase.MtdSeleccionarHuerta();
                if (Clase.Exito)
                {
                    glue_Huertas.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarResponsables()
        {
            glue_Responsables.Properties.DataSource = null;
            WS_Catalogos_empleados_huerta sel = new WS_Catalogos_empleados_huerta();
            sel.Id_Usuario = Id_Usuario;
            sel.MtdSeleccionarEmpleados();
                   
            if (sel.Exito)
            {
                glue_Responsables.Properties.DataSource = sel.Datos;
            }
            
        }

        private void CargarActivosGas()
        {
            glue_Activos.Properties.DataSource = null;
            WS_Catalogos_Activos_Gasolina sel = new WS_Catalogos_Activos_Gasolina();
            sel.Id_Usuario = Id_Usuario;
           
            sel.Fecha = "19000101";
            
           
            sel.MtdSeleccionarActivo();
            if (sel.Exito)
            {
                glue_Activos.Properties.DataSource = sel.Datos;
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

        private void rg_IoS_EditValueChanged(object sender, EventArgs e)
        {
            if (rg_IoS.EditValue.ToString() == "S")
            {
                
                label_Activo.Visible = true;
                glue_Activos.Visible = true;
                label_Bloque.Visible = true;
                glue_Bloques.Visible = true;
                label_Actividad.Visible = true;
                glue_Actividades.Visible = true;
                CargarActividades();
                CargarActivosGas();
            }
            else
            {
                label_Activo.Visible = false;
                glue_Activos.Visible = false;
                label_Bloque.Visible = false;
                glue_Bloques.Visible = false;
                label_Actividad.Visible = false;
                glue_Actividades.Visible = false;
            }
        }

        private void CargarActividades()
        {
            glue_Actividades.Properties.DataSource = null;
           
            
            if (glue_Empresas.EditValue != null)
            {
                WS_Catalogos_Actividades_Huerta Clase = new WS_Catalogos_Actividades_Huerta();

                Clase.Id_Usuario = Id_Usuario;
                Clase.MtdSeleccionarActividades();
                if (Clase.Exito)
                {
                    glue_Actividades.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarTipoGas()
        {
            DataTable Datos;
            Datos = new DataTable();

            Datos.Columns.Add("Tipo");
            DataRow row = Datos.NewRow();
            row["Tipo"] = Convert.ToString("Magna  87  octanos");
            Datos.Rows.Add(row);
            DataRow row2 = Datos.NewRow();
            row2["Tipo"] = Convert.ToString("Premium  92  octanos");
            Datos.Rows.Add(row2);
            DataRow row3 = Datos.NewRow();
            row3["Tipo"] = Convert.ToString("Diesel");
            Datos.Rows.Add(row3);

            glue_TipoCombustible.Properties.DataSource = Datos;
        }

        private void glue_Huertas_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void glue_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            CargarHuertas();
        }

        private void CargarBloques()
        {
            glue_Bloques.Properties.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            if (glue_Empresas.EditValue != null)
            {
                Clase.Id_Huerta = glue_Huertas.EditValue.ToString();
                Clase.TipoBloque = "B";
                Clase.MtdSeleccionarBloquesHuerta();
                if (Clase.Exito)
                {
                    glue_Bloques.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarGrid()
        {
            gridControl1.DataSource = null;
            WS_Control_Gasolina Clase = new WS_Control_Gasolina();

            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.d_fechaconsumo_gas = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.MtdConsultaCombustiblexFecha();
                if (Clase.Exito)
                {
                gridControl1.DataSource = Clase.Datos;
                }
            if (gridView1.RowCount > 0)
            {
                double saldoM = 0,saldoP=0,saldoD=0;
                DataRow row;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    row = this.gridView1.GetDataRow(i);
                    if (row["v_tipo_gas"].ToString().Equals("Magna  87  octanos"))
                    {
                        saldoM = double.Parse(row["Saldo"].ToString());
                       
                    }
                    if (row["v_tipo_gas"].ToString().Equals("Premium  92  octanos"))
                    {
                        saldoP = double.Parse(row["Saldo"].ToString());
                      
                    }
                    if (row["v_tipo_gas"].ToString().Equals("Diesel"))
                    {
                        saldoD = double.Parse(row["Saldo"].ToString());
                       
                    }

                }

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    row = this.gridView1.GetDataRow(i);
                    if (row["v_tipo_gas"].ToString().Equals("Magna  87  octanos"))
                    {
                        
                        saldoM = saldoM + double.Parse(row["v_cantutilizada_gas"].ToString());
                        gridView1.SetRowCellValue(i, "Saldo", saldoM);
                    }
                    if (row["v_tipo_gas"].ToString().Equals("Premium  92  octanos"))
                    {
                        
                        saldoP = saldoP + double.Parse(row["v_cantutilizada_gas"].ToString());
                        gridView1.SetRowCellValue(i, "Saldo", saldoP);
                    }
                    if (row["v_tipo_gas"].ToString().Equals("Diesel"))
                    {
                        
                        saldoD = saldoD + double.Parse(row["v_cantutilizada_gas"].ToString());
                        gridView1.SetRowCellValue(i, "Saldo", saldoD);
                    }

                }
                gridControl1.RefreshDataSource();
            }
            
        }

        private void btn_Salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void InsertarGasConsumo()
        {
            WS_Control_Gasolina Clase = new WS_Control_Gasolina();
            Clase.d_fecha_crea = de_Fecha.EditValue.ToString();
            Clase.c_folio_gas = textId.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.d_fechaconsumo_gas = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.c_codigo_eps = glue_Empresas.EditValue.ToString().Trim();
            Clase.Id_Huerta = glue_Huertas.EditValue.ToString();
            Clase.v_Bloques_gas = glue_Bloques.EditValue.ToString(); 
            Clase.Id_ActivosGas = glue_Activos.EditValue.ToString();
            Clase.MtdInsertarGasolina();
        }

       

        private void ConcatenaBloques(string Bloques )
        {
            if (Gbloques.Trim().Length == 0)
            {
                Gbloques = Bloques;
            }
            else
            {
                Gbloques = Gbloques + ", " + Bloques;
            }
            
            //MessageBox.Show(Gbloques, "Bloques");
        }

       

        private void glue_Bloques_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            Gbloques = "";
            System.Collections.ArrayList rows = new System.Collections.ArrayList();

            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView5.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                DataRow row = this.gridView5.GetDataRow(selectedRowHandles[i]);
                // MessageBox.Show(selectedRowHandles[i].ToString(), "handles");
                ConcatenaBloques(row[0].ToString());
                // int selectedRowHandle = selectedRowHandles[i];

                /* if (selectedRowHandle >= 0)
                     rows.Add(gridView5.GetDataRow(selectedRowHandle));*/
            }
            try
            {
                // gridView5.BeginUpdate();
                for (int j = 0; j < rows.Count; j++)
                {
                    DataRow row = rows[j] as DataRow;
                    MessageBox.Show(rows[j].ToString(), "rows");
                    // Change the field value.
                    // row["Discontinued"] = true;
                }
            }
            finally
            {
                //gridView5.EndUpdate();
            }

            //MessageBox.Show(gridView5.GetSelectedRows(), "") ;
            
        }

        private void de_Fecha_EditValueChanged(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}