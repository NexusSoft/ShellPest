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
        public string Codigo_Hue { get; set; }
        public string Codigo_Emp { get; set; }
        public string Codigo_Apl { get; set; }
        public string Codigo_Pro { get; set; }
        public string Fecha { get; set; }

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
        private void MakeTablaProductos()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column;
            table.Reset();

            // DataRow row;
            column = new DataColumn();
            column.DataType = typeof(DateTime);
            column.ColumnName = "RecepcionFecha";
            column.AutoIncrement = false;
            column.Caption = "RecepcionFecha";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Producto";
            column.AutoIncrement = false;
            column.Caption = "Producto";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Dosis";
            column.AutoIncrement = false;
            column.Caption = "Dosis";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Unidad";
            column.AutoIncrement = false;
            column.Caption = "Unidad";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            

            table.Columns.Add(column);

            dtgProductos.DataSource = table;
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
        private void ValidaDatos()
        {
            try
            {
                Codigo_Emp = cmb_Empresas.EditValue.ToString();
            }
            catch (Exception)
            {
                Codigo_Emp = string.Empty;
            }
            try
            {
                Codigo_Hue = cmb_Huerta.EditValue.ToString();
            }
            catch (Exception)
            {
                Codigo_Hue = string.Empty;
            }
            try
            {
                Codigo_Apl = cmb_TipoAplicacion.EditValue.ToString();
            }
            catch (Exception)
            {
                Codigo_Apl = string.Empty;
            }
            try
            {
                Codigo_Pro = cmb_Productos.EditValue.ToString();
            }
            catch (Exception)
            {
                Codigo_Pro = string.Empty;
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
        private void CargaProductos()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.Fecha = "20000101";
            Clase1.Id_Usuario = Id_Usuario;
            Clase1.c_codigo_eps = Codigo_Emp;
            Clase1.MtdSeleccionarProductos();
            if (Clase1.Exito)
            {
                cmb_Productos.Properties.DisplayMember = "v_nombre_pro";
                cmb_Productos.Properties.ValueMember = "c_codigo_pro";
                cmb_Productos.EditValue = null;
                cmb_Productos.Properties.DataSource = Clase1.Datos;
            }
        }
        private void CargaUnidades()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.c_codigo_pro = Codigo_Pro;
            Clase1.c_codigo_eps = Codigo_Emp;
            Clase1.MtdSeleccionarUnidades();
            if (Clase1.Exito)
            {
                if(Clase1.Datos.Rows.Count > 0)
                {
                    txtUnidad.Text = Clase1.Datos.Rows[0]["v_nombre_uni"].ToString();
                    txtUnidad.Tag = Clase1.Datos.Rows[0]["c_codigo_uni"].ToString();
                }
            }
        }
        private void Frm_AplicacionHue_Shown(object sender, EventArgs e)
        {
            dt_Fecha.DateTime = DateTime.Now;
            CargarEmpresa();
            CargarHuerta();
            InicializaGrigCombos();
        }
        private void cmb_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
            CargarReceta();
            CargaTipoAplicacion();
            CargaProductos();
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
        private void CreatNewRowCorte(string Fecha, string Producto, string Medida, string Dosis)
        {
            dtgValProductos.AddNewRow();
            int rowHandle = dtgValProductos.GetRowHandle(dtgValProductos.DataRowCount);
            if (dtgValProductos.IsNewItemRow(rowHandle))
            {
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Id_Cosecha"], Fecha);
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["EstibadeSeleccion"], Producto);
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Huerta"], Medida);
                dtgValProductos.SetRowCellValue(rowHandle, dtgValProductos.Columns["Semana"], Dosis);
            }
        }

        private void cmb_Productos_EditValueChanged(object sender, EventArgs e)
        {
            ValidaDatos();
            CargaUnidades();
        }

        Boolean ValidaProducto()
        {
            Boolean valida = false;
            if(!string.IsNullOrEmpty(dt_Fecha.EditValue.ToString()))
            {
                if(!string.IsNullOrEmpty(cmb_Productos.EditValue.ToString()))
                {
                    if (!string.IsNullOrEmpty(dt_Fecha.EditValue.ToString()))
                    {
                        if(Convert.ToDouble(txtDosis.Text)>0)
                        {
                            valida = true;
                        }
                        else
                        {
                            XtraMessageBox.Show("La dosis a aplicar debe ser mayor a 0");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No se ha capturado una unidad");
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se ha capturado un producto");
                }
            }
            else
            {
                XtraMessageBox.Show("No se ha capturado un fecha");
            }
            return valida;
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(ValidaProducto())
            {

                CreatNewRowCorte(Fecha, Producto, Medida, Dosis);
            }
        }
    }
}