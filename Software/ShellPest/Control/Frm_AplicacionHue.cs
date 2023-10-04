using CapaDeDatos;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using GridLookUpEditCBMultipleSelection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellPest
{
    public partial class Frm_AplicacionHue : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Usuario { get; set; }
        public string Id_Receta{ get; set; }
        public string Codigo_Hue { get; set; }
        public string Codigo_Emp { get; set; }
        public string Codigo_Apl { get; set; }
        public string Codigo_Pro { get; set; }
        public string Fecha { get; set; }
        public bool CambioReceta { get; set; }

        GridCheckMarksSelection gridCheckMarksBloques;
        StringBuilder sb = new StringBuilder();
        string CadenaBloques = string.Empty;
        string CadenaEspBloques = string.Empty;
        int TotalRegBloques = 0;

        private static Frm_AplicacionHue m_FormDefInstance;
        public static Frm_AplicacionHue DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_AplicacionHue();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        
        public Frm_AplicacionHue()
        {
            InitializeComponent();
        }

        private void MakeTablaAplicacion()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();

            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(DateTime);
            column.ColumnName = "Fecha_Aplicada";
            column.AutoIncrement = false;
            column.Caption = "Fecha_Aplicada";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Calibracion";
            column.AutoIncrement = false;
            column.Caption = "Calibracion";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Presion";
            column.AutoIncrement = false;
            column.Caption = "Presion";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "NArboles";
            column.AutoIncrement = false;
            column.Caption = "NArboles";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Unidades_aplicadas";
            column.AutoIncrement = false;
            column.Caption = "Unidades_aplicadas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(decimal);
            column.ColumnName = "Centro_Costos";
            column.AutoIncrement = false;
            column.Caption = "Centro_Costos";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgAplicacionesD.DataSource = table;
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
        private void Habilita_diarias(Boolean Valor)
        {
            groupControl2.Enabled = Valor;
        }
        private void ValidaDatos()
        {
            try
            {
                if (cmb_Empresas.EditValue != null)
                {
                    Codigo_Emp = cmb_Empresas.EditValue.ToString();
                }
                
            }
            catch (Exception)
            {
                Codigo_Emp = string.Empty;
            }
            try
            {
                if (cmb_Huerta.EditValue != null)
                {
                    Codigo_Hue = cmb_Huerta.EditValue.ToString();
                }
                
            }
            catch (Exception)
            {
                Codigo_Hue = string.Empty;
            }
            try
            {
                if (cmb_TipoAplicacion.EditValue != null)
                {
                    Codigo_Apl = cmb_TipoAplicacion.EditValue.ToString();
                }
                
            }
            catch (Exception)
            {
                Codigo_Apl = string.Empty;
            }
            try
            {
                if (cmb_Recetas.EditValue != null)
                {
                    Id_Receta = cmb_Recetas.EditValue.ToString();

                }
                
            }
            catch (Exception)
            {
                Id_Receta = string.Empty;
            }
        }
        private void CargarEmpresa()
        {
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                cmb_Empresas.Properties.DisplayMember = "v_nombre_usuemp";
                cmb_Empresas.Properties.ValueMember = "c_codigo_eps";
                cmb_Empresas.EditValue = null;
                cmb_Empresas.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarHuerta()
        {
            CLS_Aplicaciones Clase2 = new CLS_Aplicaciones();
            Clase2.Id_Usuario = Id_Usuario;
            Clase2.MtdSeleccionarHuertaXUsuario();
            if (Clase2.Exito)
            {
                cmb_Huerta.Properties.DisplayMember = "Nombre_Huerta";
                cmb_Huerta.Properties.ValueMember = "Id_Huerta";
                cmb_Huerta.EditValue = null;
                cmb_Huerta.Properties.DataSource = Clase2.Datos;
            }
        }
        private void CargarReceta()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.Id_Huerta = Codigo_Hue;
            Clase1.c_codigo_eps = Codigo_Emp;
            Clase1.MtdSeleccionarRecetas();
            if (Clase1.Exito)
            {
                cmb_Recetas.Properties.DisplayMember = "Receta_Fecha";
                cmb_Recetas.Properties.ValueMember = "Id_Receta";
                cmb_Recetas.EditValue = null;
                cmb_Recetas.Properties.DataSource = Clase1.Datos;
            }
        }
        private void CargaTipoAplicacion()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.c_codigo_eps = Codigo_Emp;
            Clase1.MtdSeleccionarTipoAplicacion();
            if (Clase1.Exito)
            {
                cmb_TipoAplicacion.Properties.DisplayMember = "Nombre_TipoAplicacion";
                cmb_TipoAplicacion.Properties.ValueMember = "Id_TipoAplicacion";
                cmb_TipoAplicacion.EditValue = null;
                cmb_TipoAplicacion.Properties.DataSource = Clase1.Datos;
            }
        }
        private void CargarBloques()
        {
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Huerta = Codigo_Hue;
            Clase.MtdSeleccionarBloquesXHuerta();
            if (Clase.Exito)
            {
                if (Clase.Datos.Rows.Count > 0)
                {
                    gridCheckMarksBloques.ClearSelection(cmb_BloquesView);
                    TotalRegBloques = Clase.Datos.Rows.Count;
                    cmb_Bloques.Properties.DataSource = Clase.Datos;
                }
            }
        }
        private void CargaPresentacion()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.Id_TipoAplicacion = Codigo_Apl;
            Clase1.MtdSeleccionarPresentacion();
            if (Clase1.Exito)
            {
                cmb_Presentacion.Properties.DisplayMember = "Nombre";
                cmb_Presentacion.Properties.ValueMember = "Id_Presentacion";
                cmb_Presentacion.EditValue = null;
                cmb_Presentacion.Properties.DataSource = Clase1.Datos;
            }
        }
        private void CargaRecetaDetalles()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.Id_Huerta = Codigo_Hue;
            Clase1.Id_Receta = Id_Receta;
            Clase1.MtdSeleccionarRecetasDetalle();
            if (Clase1.Exito)
            {
                dtgProductos.DataSource = Clase1.Datos;
                CambioReceta = true;
            }
        }

        private void Frm_AplicacionHue_Shown(object sender, EventArgs e)
        {
            
            dt_FechaD.DateTime = DateTime.Now;
            dt_FechaA.DateTime = DateTime.Now;
            CargarEmpresa();
            CargarHuerta();
            MakeTablaAplicacion();
            InicializaGrigCombos();
            Habilita_diarias(false);
        }
        private void cmb_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
            CargarReceta();
            CargaTipoAplicacion();
        }
        private void cmb_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
            CargarReceta();
            CargarBloques();
        }
        private void cmb_TipoAplicacion_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
            CargaPresentacion();
            try
            {
                lbl_NomAplicacion.Text = "N° " + cmb_TipoAplicacion.Text;
            }
            catch (Exception)
            {
                lbl_NomAplicacion.Text = "N° ";
            }
        }
        private void InicializaGrigCombos()
        {
            cmb_Bloques.CustomDisplayText += cboGridBloques_CustomDisplayText;
            cmb_Bloques.Properties.PopulateViewColumns();
            gridCheckMarksBloques = new GridCheckMarksSelection(cmb_Bloques.Properties);
            gridCheckMarksBloques.SelectionChanged += gridCheckMarksBloques_SelectionChanged;
            cmb_Bloques.Properties.Tag = gridCheckMarksBloques;
        }
        void gridCheckMarksBloques_SelectionChanged(object sender, EventArgs e)
        {
            CadenaBloques = string.Empty;
            if (ActiveControl is GridLookUpEdit)
            {
                CadenaEspBloques = string.Empty;
                foreach (DataRowView rv in (sender as GridCheckMarksSelection).Selection)
                {
                    if (sb.ToString().Length > 0) { sb.Append(", "); }
                    sb.AppendFormat("{0}", rv["Id_Bloque"]);

                    if (CadenaBloques != string.Empty)
                    {
                        CadenaBloques = string.Format("{0},{1}", CadenaBloques, rv["Id_Bloque"]);
                    }
                    else
                    {
                        CadenaBloques = rv["Id_Bloque"].ToString();
                    }
                     (ActiveControl as GridLookUpEdit).Text = sb.ToString();
                }
                int TotalSelect = gridCheckMarksBloques.SelectedCount;
                if (TotalSelect == TotalRegBloques)
                {
                    CadenaEspBloques = "Todas";
                }
            }
        }
        void cboGridBloques_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            GridCheckMarksSelection gridCheckMark = sender is GridLookUpEdit ? (sender as GridLookUpEdit).Properties.Tag as GridCheckMarksSelection : (sender as RepositoryItemGridLookUpEdit).Tag as GridCheckMarksSelection;
            if (gridCheckMark == null) return;
            foreach (DataRowView rv in gridCheckMark.Selection)
            {
                if (sb.ToString().Length > 0) { sb.Append(", "); }
                sb.AppendFormat("{0}", rv["Id_Bloque"]);
                e.DisplayText = sb.ToString();
            }
            if (sb.ToString() == string.Empty)
            {
                e.DisplayText = "-Seleccionar-";
            }
        }
        private void CreatNewRowAplicacion(string Fecha_Aplicada, string Calibracion, string Presion, string NArboles,string Unidades_aplicadas, string Centro_Costos)
        {
            dtgValAplicacionesD.AddNewRow();
            int rowHandle = dtgValAplicacionesD.GetRowHandle(dtgValAplicacionesD.DataRowCount);
            if (dtgValAplicacionesD.IsNewItemRow(rowHandle))
            {
                dtgValAplicacionesD.SetRowCellValue(rowHandle, dtgValAplicacionesD.Columns["Fecha_Aplicada"], Fecha_Aplicada);
                dtgValAplicacionesD.SetRowCellValue(rowHandle, dtgValAplicacionesD.Columns["Calibracion"], Calibracion);
                dtgValAplicacionesD.SetRowCellValue(rowHandle, dtgValAplicacionesD.Columns["Presion"], Presion);
                dtgValAplicacionesD.SetRowCellValue(rowHandle, dtgValAplicacionesD.Columns["NArboles"], NArboles);
                dtgValAplicacionesD.SetRowCellValue(rowHandle, dtgValAplicacionesD.Columns["Unidades_aplicadas"], Unidades_aplicadas);
                dtgValAplicacionesD.SetRowCellValue(rowHandle, dtgValAplicacionesD.Columns["Centro_Costos"], Centro_Costos);
            }
        }
        private void CreatNewRowProducto(string Fecha, string Producto, string Dosis, string Unidad)
        {
            dtgValProductos.AddNewRow();
            int rowHandle = dtgValProductos.GetRowHandle(dtgValProductos.DataRowCount);
            if (dtgValProductos.IsNewItemRow(rowHandle))
            {
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Fecha"], Fecha);
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Producto"], Producto);
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Dosis"], Dosis);
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Unidad"], Unidad);
            }
        }

        private void cmb_Productos_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
        }
        bool ValidarCamposD()
        {
            Boolean Valor = false;
            if(!string.IsNullOrEmpty(txtCalibracion.Text))
            {
                if (!string.IsNullOrEmpty(txt_Presion.Text))
                {
                    if (!string.IsNullOrEmpty(txt_NArboles.Text))
                    {
                        if (!string.IsNullOrEmpty(txt_UAplicadas.Text))
                        {
                            Valor = true;
                        }
                        else
                        {
                            XtraMessageBox.Show("no se ha capturado Volumen aplicado");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("no se ha capturado Numero de Arboles");
                    }
                }
                else
                {
                    XtraMessageBox.Show("no se ha capturado Presion");
                }
            }
            else 
            {
                XtraMessageBox.Show("no se ha capturado calibracion");
            }
            return Valor;
        }
        bool ValidarCamposA()
        {
            Boolean Valor = false;
            try
            {
                if (!string.IsNullOrEmpty(cmb_Empresas.EditValue.ToString()))
                {
                    if (!string.IsNullOrEmpty(cmb_Huerta.EditValue.ToString()))
                    {
                        if (!string.IsNullOrEmpty(cmb_Recetas.EditValue.ToString()))
                        {
                            if (!string.IsNullOrEmpty(cmb_TipoAplicacion.EditValue.ToString()))
                            {
                                if (!string.IsNullOrEmpty(cmb_Presentacion.EditValue.ToString()))
                                {
                                    Valor = true;
                                }
                                else
                                {
                                    XtraMessageBox.Show("no se ha capturado Presentacion");
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("no se ha capturado Tipo de Aplicaicon");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("no se ha capturado Receta");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("no se ha capturado Huerta");
                    }
                }
                else
                {
                    XtraMessageBox.Show("no se ha capturado Empresa");
                }
            }
            catch (Exception)
            {
                Valor = false;
                XtraMessageBox.Show("Faltan datos por capturar");
            }
            return Valor;
        }
        private void btn_AgregarD_Click(object sender, EventArgs e)
        {
            if(ValidarCamposD())
            {
                DateTime fecha = dt_FechaD.DateTime;
                string Fecha_Aplicada = fecha.Year.ToString() +"-"+ DosCero(fecha.Month.ToString()) +"-"+ DosCero(fecha.Day.ToString());
                string Calibracion= txtCalibracion.Text;
                string Presion = txt_Presion.Text;
                string NArboles= txt_NArboles.Text;
                string Unidades_aplicadas= txt_UAplicadas.Text;
                string Centro_Costos = cmb_Bloques.Text;
                CreatNewRowAplicacion(Fecha_Aplicada, Calibracion, Presion, NArboles, Unidades_aplicadas, Centro_Costos);
            }
        }

        private void cmb_Recetas_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
            CargaRecetaDetalles();
        }

        void GuardarReceta()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.Id_Aplicacion= txt_CodigoAplicacion.Text;
            Clase1.Id_Huerta = Codigo_Hue;
            Clase1.Id_Receta = Id_Receta;
            Clase1.Id_Usuario = Id_Usuario;
            Clase1.MtdInsertarAplicacionesReceta();
            if (!Clase1.Exito)
            {
                XtraMessageBox.Show(Clase1.Mensaje);
            }
        }
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_CodigoAplicacion.Text == string.Empty)
            {
                if (ValidarCamposA())
                {
                    CLS_Aplicaciones ins = new CLS_Aplicaciones();
                    ins.c_codigo_eps = cmb_Empresas.EditValue.ToString();
                    ins.Id_Huerta = cmb_Huerta.EditValue.ToString();
                    ins.Id_Receta = cmb_Recetas.EditValue.ToString();
                    ins.Id_TipoAplicacion = cmb_TipoAplicacion.EditValue.ToString();
                    ins.Id_Presentacion = cmb_Presentacion.EditValue.ToString();
                    ins.Observaciones = txt_Observaciones.Text;
                    ins.No_aplicaciones = Convert.ToInt32(txt_NAplicaciones.Text);
                    DateTime FechaA = dt_FechaA.DateTime;
                    ins.Fecha = FechaA.Year.ToString() + DosCero(FechaA.Month.ToString()) + DosCero(FechaA.Day.ToString());
                    ins.Anio = FechaA.Year.ToString();
                    ins.Id_Usuario = Id_Usuario;
                    ins.MtdInsertarAplicaciones();
                    if (ins.Exito)
                    {
                        if (ins.Datos.Rows.Count > 0)
                        {
                            txt_CodigoAplicacion.Text = ins.Datos.Rows[0]["Folio"].ToString();
                            Habilita_diarias(true);
                            GuardarReceta();
                            CambioReceta=false;
                        }
                    }
                }
            }
            else
            {
                if (ValidarCamposA())
                {
                    CLS_Aplicaciones ins = new CLS_Aplicaciones();
                    ins.Id_Aplicacion = txt_CodigoAplicacion.Text;
                    ins.c_codigo_eps = cmb_Empresas.EditValue.ToString();
                    ins.Id_Huerta = cmb_Huerta.EditValue.ToString();
                    ins.Id_Receta = cmb_Recetas.EditValue.ToString();
                    ins.Id_TipoAplicacion = cmb_TipoAplicacion.EditValue.ToString();
                    ins.Id_Presentacion = cmb_Presentacion.EditValue.ToString();
                    ins.Observaciones = txt_Observaciones.Text;
                    ins.No_aplicaciones = Convert.ToInt32(txt_NAplicaciones.Text);
                    DateTime FechaA = dt_FechaA.DateTime;
                    ins.Fecha = FechaA.Year.ToString() + DosCero(FechaA.Month.ToString()) + DosCero(FechaA.Day.ToString());
                    ins.Anio = FechaA.Year.ToString();
                    ins.Id_Usuario = Id_Usuario;
                    ins.MtdUpdateAplicaciones();
                    if (ins.Exito)
                    {
                        if (CambioReceta)
                        {
                            GuardarReceta();
                            CambioReceta = false;
                        }
                    }
                }
            }
        }

        private void btn_Cultivo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}