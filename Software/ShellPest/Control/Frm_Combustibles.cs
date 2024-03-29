﻿using DevExpress.XtraEditors;
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
                
                CargarTipoGas();
                //CargarGridPodas(false);
            }

            rg_IoS.EditValue = 'S';
        }

        private void CargarHuertas()
        {
            /*Este dato es basado en el codigo de campo de costos, no en Huertas de Shellpest*/
            glue_Huertas.Properties.DataSource = null;
            CLS_Inventum Clase = new CLS_Inventum();

            if (glue_Empresas.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresas.EditValue.ToString();
                Clase.MtdCosCampoSelect();
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
            sel.c_codigo_cam = glue_Huertas.EditValue.ToString().Trim();
            sel.MtdSeleccionarEmpleadosLocal();
                   
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
                btn_RefreshAc.Visible=true;
                label_Bloque.Visible = true;
                glue_Bloques.Visible = true;
                btn_RefreshB.Visible = true;
                label_BloquesView.Visible = true;
                label_Actividad.Visible = true;
                glue_Actividades.Visible = true;
                btn_RefreshA.Visible = true;
                label_Rendimiento.Visible = true;
                text_Rendimiento.Visible=true;
                glue_Unidades.Visible = true;
                btn_RefreshU.Visible = true;
                if (glue_Huertas.EditValue.ToString().Trim().Length > 0)
                {
                    CargarActividades();
                }
                
                CargarActivosGas();
                CargarUnidades();
            }
            else
            {
                label_Activo.Visible = false;
                glue_Activos.Visible = false;
                btn_RefreshAc.Visible = false;
                label_Bloque.Visible = false;
                glue_Bloques.Visible = false;
                btn_RefreshB.Visible=false;
                label_BloquesView.Visible = false;
                label_Actividad.Visible = false;
                glue_Actividades.Visible = false;
                btn_RefreshA.Visible=false;
                label_Rendimiento.Visible = false;
                text_Rendimiento.Visible = false;
                glue_Unidades.Visible = false;
                btn_RefreshU.Visible=false;
            }
        }

        private void CargarActividades()
        {
            glue_Actividades.Properties.DataSource = null;
           
            
            if (glue_Empresas.EditValue != null)
            {
                WS_Catalogos_Actividades_Huerta Clase = new WS_Catalogos_Actividades_Huerta();

                Clase.c_codigo_cam = glue_Huertas.EditValue.ToString().Trim();
                Clase.MtdSeleccionarActividadesCombustible();
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
            CargarResponsables();
            if (rg_IoS.EditValue.ToString() == "S")
            {
                CargarActividades();
            }
            if (glue_Huertas.EditValue.ToString().Trim().Length > 0 && glue_TipoCombustible.EditValue.ToString().Trim().Length > 0)
            {
                String Filtro;
                Filtro = gridView1.ActiveFilterString;
                gridView1.ClearSorting();
                gridView1.ClearColumnsFilter();

                CargarGrid();
                gridView1.ActiveFilterString = Filtro; //Guardo filtros, despues los quito, calculo saldos y despues vuelvo a aplicar los filtros
            }
           }

        private void glue_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            CargarHuertas();
        }

        private void CargarBloques()
        {
            glue_Bloques.Properties.DataSource = null;
            CLS_Inventum Clase = new CLS_Inventum();

            if (glue_Empresas.EditValue != null)
            {
                Clase.c_codigo_cam = glue_Huertas.EditValue.ToString();
                
                Clase.MtdCosloteSelect();
                if (Clase.Exito)
                {
                    glue_Bloques.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void CargarUnidades()
        {
            glue_Unidades.Properties.DataSource = null;
            WS_Catalogos_Unidades Clase = new WS_Catalogos_Unidades();

            Clase.MtdSeleccionarUnidadesLocal();
            if (Clase.Exito)
            {
            glue_Unidades.Properties.DataSource = Clase.Datos;
            }
            
        }

        private void CargarGrid()
        {

            gridControl1.DataSource = null;
            WS_Control_Gasolina Clase = new WS_Control_Gasolina();

            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.d_fechaconsumo_gas = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_Huerta=glue_Huertas.EditValue.ToString().Trim();
            Clase.v_tipo_gas=glue_TipoCombustible.EditValue.ToString().Trim();
            Clase.MtdConsultaCombustiblexFecha();
                if (Clase.Exito)
                {
                gridControl1.DataSource = Clase.Datos;
                //gridView1.Columns["v_cantutilizada_gas"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            if (gridView1.RowCount > 0)
            {
                CalculaSaldos(); 
            }
            
        }

        private void CalculaSaldos()
        {
             
            List<AcumulaSaldoCombustible> Matriz = new List<AcumulaSaldoCombustible>();

            DataRow row2;

            for (int j = 0; j < gridView1.RowCount; j++)
            {
                row2 = this.gridView1.GetDataRow(j);
                //MessageBox.Show("", row["c_codigo_hue"].ToString());

                if (Matriz.Count == 0)
                {
                    Matriz.Add(new AcumulaSaldoCombustible() { Id_Huerta = row2["Id_Huerta"].ToString(), TipoGas = row2["v_tipo_gas"].ToString().Trim(), Saldo = double.Parse(row2["Saldo"].ToString()), Linea=j });
                }
                else
                {
                    Boolean existe = false;
                    for (int k = 0; k < Matriz.Count; k++)
                    {
                        
                        if (Matriz[k].getHuerta().Equals(row2["Id_Huerta"].ToString()) && Matriz[k].getTipoGas().Trim().Equals(row2["v_tipo_gas"].ToString().Trim()))
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        Matriz.Add(new AcumulaSaldoCombustible() { Id_Huerta = row2["Id_Huerta"].ToString(), TipoGas = row2["v_tipo_gas"].ToString().Trim(), Saldo = double.Parse(row2["Saldo"].ToString()), Linea = j });
                    }
                }
 
            }


            for (int i = 0; i < gridView1.RowCount; i++)
            {
                row2 = this.gridView1.GetDataRow(i);
                int rowHandle = gridView1.GetRowHandle(i);

                for (int k = 0; k < Matriz.Count; k++)
                {
                    if (i == 0 && k==0)
                    {
                        Matriz[k].updateSaldo(Matriz[k].getSaldo()+ double.Parse(row2["v_cantutilizada_gas"].ToString()));
                        gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Saldo"], Matriz[k].getSaldo());
                        break;
                    }
                    else
                    {
                        if(row2["Id_Huerta"].ToString().Equals(Matriz[k].getHuerta()) && row2["v_tipo_gas"].ToString().Trim().Equals(Matriz[k].getTipoGas().Trim()))
                        {
                            Matriz[k].updateSaldo(Matriz[k].getSaldo() + double.Parse(row2["v_cantutilizada_gas"].ToString()));
                            gridView1.SetRowCellValue(rowHandle, gridView1.Columns["Saldo"], Matriz[k].getSaldo());
                            break;
                        }
                    }
                }

            }

        }

       

        private void btn_Salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            InsertarGasConsumo();

            String Filtro;
            Filtro = gridView1.ActiveFilterString;
            gridView1.ClearSorting();
            gridView1.ClearColumnsFilter();

            CargarGrid();
            gridView1.ActiveFilterString = Filtro; //Guardo filtros, despues los quito, calculo saldos y despues vuelvo a aplicar los filtros

            //CargarGrid();
        }

        private void InsertarGasConsumo()
        {
            WS_Control_Gasolina Clase = new WS_Control_Gasolina();
            DateTime Fecha;
            
            Clase.c_folio_gas = textId.Text.Trim();
            Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.d_fechaconsumo_gas = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.c_codigo_eps = glue_Empresas.EditValue.ToString().Trim();
            Clase.Id_Huerta = glue_Huertas.EditValue.ToString();
            
            if (Char.Parse(rg_IoS.EditValue.ToString()).Equals('S'))
            {
                Clase.Id_ActivosGas = glue_Activos.EditValue.ToString();
                Clase.v_Bloques_gas = Gbloques;
            }
            else
            {
                Clase.Id_ActivosGas = "0000";
                Clase.v_Bloques_gas = "";
            }
           
            Clase.c_codigo_emp=glue_Responsables.EditValue.ToString().Trim();
            if (Char.Parse(rg_IoS.EditValue.ToString()).Equals('S'))
            {
                Clase.c_codigo_act = glue_Actividades.EditValue.ToString();
            }
            else
            {
                Clase.c_codigo_act = "0000";
            }
            Clase.v_tipo_gas=glue_TipoCombustible.EditValue.ToString();
            if (Double.Parse(text_Cant.Text) < 0)
            {
                Clase.v_cantutilizada_gas = (Double.Parse(text_Cant.Text) * -1).ToString();
            }
            else
            {
                Clase.v_cantutilizada_gas = text_Cant.Text;
            }
            
            Clase.v_horometro_gas = "0";
            Clase.v_kminicial_gas = "0";
            Clase.v_kmfinal_gas = "0";
            Clase.v_observaciones_gas = text_Observaciones.Text.ToString();
            if (Char.Parse(rg_IoS.EditValue.ToString()).Equals('S'))
            {
                Clase.n_rendimiento_act = Decimal.Parse(text_Rendimiento.Text);
                Clase.c_unidad_act = glue_Unidades.EditValue.ToString();
            }
            else
            {
                Clase.n_rendimiento_act = 0;
                Clase.c_unidad_act = "";
            }
                    Clase.EntOSal = rg_IoS.EditValue.ToString();
            Clase.MtdInsertarRCombustibleLocal();
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
            label_BloquesView.Text = Gbloques;
            //MessageBox.Show(Gbloques, "Bloques");
        }

       

        private void glue_Bloques_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            Gbloques = "";
            label_BloquesView.Text = Gbloques;
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
            if(glue_Huertas.EditValue.ToString().Trim().Length>0 && glue_TipoCombustible.EditValue.ToString().Trim().Length > 0)
            {
                String Filtro;
                Filtro = gridView1.ActiveFilterString;
                gridView1.ClearSorting();
                gridView1.ClearColumnsFilter();

                CargarGrid();
                gridView1.ActiveFilterString = Filtro; //Guardo filtros, despues los quito, calculo saldos y despues vuelvo a aplicar los filtros
            }
 
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            WS_Control_Gasolina Clase = new WS_Control_Gasolina();
            DateTime Fecha;

            Clase.c_folio_gas = textId.Text.Trim();
            Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());
            Clase.d_fechaconsumo_gas = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.c_codigo_eps = glue_Empresas.EditValue.ToString().Trim();
            Clase.Id_Huerta = glue_Huertas.EditValue.ToString();

            if (Char.Parse(rg_IoS.EditValue.ToString()).Equals('S'))
            {
                Clase.Id_ActivosGas = glue_Activos.EditValue.ToString();
                Clase.v_Bloques_gas = Gbloques;
            }
            else
            {
                Clase.Id_ActivosGas = "0000";
                Clase.v_Bloques_gas = "";
            }

            Clase.c_codigo_emp = glue_Responsables.EditValue.ToString().Trim();
            if (Char.Parse(rg_IoS.EditValue.ToString()).Equals('S'))
            {
                Clase.c_codigo_act = glue_Actividades.EditValue.ToString();
            }
            else
            {
                Clase.c_codigo_act = "0000";
            }
            Clase.v_tipo_gas = glue_TipoCombustible.EditValue.ToString();
            
            Clase.EntOSal = rg_IoS.EditValue.ToString();
            Clase.MtdEliminaCombustibleLocal();
            CargarGrid();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["c_folio_gas"].ToString();
                    //de_Fecha.Text = row["d_fechaconsumo_gas"].ToString();
                    if (row["Id_ActivosGas"].ToString().Equals("0000"))
                    {
                        rg_IoS.EditValue = 'I';
                        
                    }
                    else
                    {
                        rg_IoS.EditValue = 'S';
                    }
                    glue_Huertas.EditValue= row["Id_Huerta"].ToString().Trim();
                    glue_TipoCombustible.EditValue= row["v_tipo_gas"].ToString();
                    if (Double.Parse(row["v_cantutilizada_gas"].ToString()) < 0)
                    {
                        text_Cant.Text = (Double.Parse(row["v_cantutilizada_gas"].ToString()) * -1).ToString();
                    }
                    else
                    {
                        text_Cant.Text = row["v_cantutilizada_gas"].ToString();
                    }
                    
                    text_Observaciones.Text= row["v_observaciones_gas"].ToString();
                    glue_Responsables.EditValue= row["c_codigo_emp"].ToString().Trim();
                    glue_Activos.EditValue= row["Id_ActivosGas"].ToString().Trim();

                    Gbloques= row["v_Bloques_gas"].ToString();
                    label_BloquesView.Text = Gbloques;
                    glue_Actividades.EditValue= row["c_codigo_act"].ToString().Trim();
                    text_Rendimiento.Text= row["n_rendimiento_act"].ToString();
                    glue_Unidades.EditValue= row["c_unidad_act"].ToString();
                    glue_Empresas.EditValue = row["c_codigo_eps"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btn_RefreshB_Click(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void btn_RefreshU_Click(object sender, EventArgs e)
        {
            CargarUnidades();
        }

        private void btn_RefreshA_Click(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void btn_RefreshAc_Click(object sender, EventArgs e)
        {
            CargarActivosGas();
        }

        private void glue_Actividades_EditValueChanged(object sender, EventArgs e)
        {
            CLS_Actividad_Campo sel = new CLS_Actividad_Campo();
            sel.c_codigo_cam = glue_Huertas.EditValue.ToString();

            sel.c_codigo_act = glue_Actividades.EditValue.ToString();


            sel.MtdSeleccionarUnidad_X_ActividadCampo();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    glue_Unidades.EditValue = sel.Datos.Rows[0][0].ToString();
                }
                
            }
        }

        private void glue_TipoCombustible_EditValueChanged(object sender, EventArgs e)
        {
            if (glue_Huertas.EditValue.ToString().Trim().Length > 0 && glue_TipoCombustible.EditValue.ToString().Trim().Length > 0)
            {
                String Filtro;
                Filtro = gridView1.ActiveFilterString;
                gridView1.ClearSorting();
                gridView1.ClearColumnsFilter();

                CargarGrid();
                gridView1.ActiveFilterString = Filtro; //Guardo filtros, despues los quito, calculo saldos y despues vuelvo a aplicar los filtros
            }
         }
    }
}