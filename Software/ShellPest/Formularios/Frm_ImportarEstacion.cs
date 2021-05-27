using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaDeDatos;
using SpreadsheetLight;
using System.Data;
using CapaDeDatos;

namespace ShellPest
{

    public partial class Frm_ImportarEstacion : DevExpress.XtraEditors.XtraForm
    {
        int rCnt = 0;
        int cCnt = 0;
        public int Row_PSC_Inicio { get; set; }
        public int Col_Fecha { get; set; }
        public int Col_TimeOut { get; set; }
        public int Col_ET { get; set; }
        public int Col_Rain { get; set; }
        public int Col_PSC_Placas { get; set; }
        public int Col_PSC_Huertas { get; set; } 
        public int Col_PSC_Productor { get; set; }
        public int Col_PSC_Cajas { get; set; }
        public int Col_PSC_Kilos { get; set; }
        public int Col_PSC_Variedad { get; set; }
        public int Col_PSC_JefeCuadrilla { get; set; }
        public int Col_PSC_CajasZ { get; set; }
        public int Col_PSC_FolioZ { get; set; }
        public int Col_PSC_JefeArea { get; set; }
        public int Col_PSC_ClaveDia { get; set; }

     public int Col_PSC_Fecha { get; set; }
    public int Col_PSC_ODC { get; set; }
    public int Col_PSC_Ubicacion { get; set; }
    public int Col_PSC_Pesada { get; set; }
  

    private static Frm_ImportarEstacion m_FormDefInstance;
        public static Frm_ImportarEstacion DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_ImportarEstacion();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_ImportarEstacion()
        {
            InitializeComponent();
        }
        public string DosCeros(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        private void MakeTablaPedidos()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column = new DataColumn();
            table.Reset();

            // DataRow row;
            column.DataType = typeof(DateTime);
            column.ColumnName = "col_Fecha";
            column.AutoIncrement = false;
            column.Caption = "Fecha";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_ODC";
            column.AutoIncrement = false;
            column.Caption = "ODC";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Ubicacion";
            column.AutoIncrement = false;
            column.Caption = "Ubicacion";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Pesada";
            column.AutoIncrement = false;
            column.Caption = "Pesada";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Placas";
            column.AutoIncrement = false;
            column.Caption = "Placas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Huertas";
            column.AutoIncrement = false;
            column.Caption = "Huertas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Productor";
            column.AutoIncrement = false;
            column.Caption = "Productor";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Cajas";
            column.AutoIncrement = false;
            column.Caption = "Cajas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Kilos";
            column.AutoIncrement = false;
            column.Caption = "Kilos";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_Variedad";
            column.AutoIncrement = false;
            column.Caption = "Variedad";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_JefeCuadrilla";
            column.AutoIncrement = false;
            column.Caption = "Jefe Cuadrilla";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_CajasZ";
            column.AutoIncrement = false;
            column.Caption = "CajasZ";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_FolioZ";
            column.AutoIncrement = false;
            column.Caption = "FolioZ";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "col_JefeArea";
            column.AutoIncrement = false;
            column.Caption = "Jefe Area";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgServicios.DataSource = table;
        }
        private void CreatNewRowArticulo(string Col_Fecha ,string Col_TimeOut,string Col_ET ,string Col_Rain)
        {
            dtgValServicios.AddNewRow();

            int rowHandle = dtgValServicios.GetRowHandle(dtgValServicios.DataRowCount);
            if (dtgValServicios.IsNewItemRow(rowHandle))
            {
                dtgValServicios.SetRowCellValue(rowHandle, dtgValServicios.Columns["F_Estacion"], Col_Fecha);
                dtgValServicios.SetRowCellValue(rowHandle, dtgValServicios.Columns["Time_Out_Estacion"], Col_TimeOut);
                dtgValServicios.SetRowCellValue(rowHandle, dtgValServicios.Columns["ET_Estacion"], Col_ET);
                dtgValServicios.SetRowCellValue(rowHandle, dtgValServicios.Columns["Rain_Estacion"], Col_Rain);
            }
        }

        private void spreadsheetCommandBarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Frm_ImportarODC_Shown(object sender, EventArgs e)
        {
            MakeTablaPedidos();
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            
        }
        private Boolean CargarPosicionColumnas()
        {
            Boolean Valor = false;
            ColumnasExcel sel = new ColumnasExcel();
            sel.MtdSeleccionar();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    Row_PSC_Inicio= Convert.ToInt32(sel.Datos.Rows[0]["Row_PSC_Inicio"].ToString());
                    Col_PSC_Fecha = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Fecha"].ToString());
                    Col_PSC_ODC = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_ODC"].ToString());
                    Col_PSC_Ubicacion = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Ubicacion"].ToString());
                    Col_PSC_Pesada = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Pesada"].ToString());
                    Col_PSC_Pesada = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Pesada"].ToString());
                    Col_PSC_Placas = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Placas"].ToString());
                    Col_PSC_Huertas = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Huertas"].ToString());
                    Col_PSC_Productor = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Productor"].ToString());
                    Col_PSC_Cajas = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Cajas"].ToString());
                    Col_PSC_Kilos = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Kilos"].ToString());
                    Col_PSC_Variedad = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_Variedad"].ToString());
                    Col_PSC_JefeCuadrilla = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_JefeCuadrilla"].ToString());
                    Col_PSC_CajasZ = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_CajasZ"].ToString());
                    Col_PSC_FolioZ = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_FolioZ"].ToString());
                    Col_PSC_JefeArea = Convert.ToInt32(sel.Datos.Rows[0]["Col_PSC_JefeArea"].ToString());
                    Valor = true;
                }
            }
            return Valor;
        }

        private void btnParametros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MakeTablaPedidos();
            txtClave.Text = string.Empty;
        }

        private void btnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int contadorins = 0;
            if (txtClave.Text!=string.Empty)
            {
                if (dtgValServicios.RowCount > 0)
                {
                    pgbProgreso.Properties.Maximum = dtgValServicios.RowCount;
                    pgbProgreso.Position = 0;
                    
                    for (int x = 0; x < dtgValServicios.RowCount; x++)
                    {
                        int xRow = dtgValServicios.GetVisibleRowHandle(x);
                        pgbProgreso.Position = x + 1;
                        Application.DoEvents();
                        string vFecha = dtgValServicios.GetRowCellValue(xRow, "col_Fecha").ToString();
                        string vTimeOut = dtgValServicios.GetRowCellValue(xRow, "col_TimeOut").ToString();
                        string vET = dtgValServicios.GetRowCellValue(xRow, "col_ET").ToString();
                        string vRain = dtgValServicios.GetRowCellValue(xRow, "col_Rain").ToString();
                        
                       /* if (!BuscarRegistro(vFecha, vODC))
                        {
                            CLS_Estacion ins = new CLS_Estacion();
                            DateTime DFecha = Convert.ToDateTime(vFecha);
                            vFecha = DFecha.Year.ToString() + DosCeros(DFecha.Month.ToString()) + DosCeros(DFecha.Day.ToString());
                            ins.PSC_Fecha = vFecha;
                            ins.PSC_ODC = vODC;
                            ins.PSC_Ubicacion = vUbicacion;
                            ins.PSC_Pesada = vPesada;
                            ins.PSC_Placas = vPlacas;
                            ins.PSC_Huertas = vHuertas;
                            ins.PSC_Productor = vProductor;                                                         LO COMENTE POR QUE MARCABA ERROR
                            ins.PSC_Cajas = vCajas;
                            ins.PSC_Kilos = vKilos;
                            ins.PSC_Variedad = vVariedad;
                            ins.PSC_JefeCuadrilla = vJefeCuadrilla;
                            ins.PSC_CajasZ = vCajasZ;
                            ins.PSC_FolioZ = vFolioZ;
                            ins.PSC_JefeArea = vJefeArea;
                            ins.PSC_ClaveDia = txtClave.Text;
                            ins.MtdInsertarServiciosCortes();
                            if (!ins.Exito)
                            {
                                XtraMessageBox.Show(ins.Mensaje);
                            }
                            else
                            {
                                contadorins++;
                            }
                        }*/
                    }
                    XtraMessageBox.Show("Se importaron " + contadorins + " de " + dtgValServicios.RowCount);
                    btnLimpiar.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("No existen registros para importar");
                }
            }
            else
            {
                XtraMessageBox.Show("Se debe capturar Hoja y Clave");
            }
        }

        private bool BuscarRegistro(string vFecha, string vODC)
        {
            Boolean Valor = false;
            DateTime fecha = Convert.ToDateTime(vFecha);
            vFecha = fecha.Year.ToString() + DosCeros(fecha.Month.ToString()) + DosCeros(fecha.Day.ToString());
            CLS_Estacion sel = new CLS_Estacion();
            /*sel.PSC_Fecha = vFecha;
            sel.PSC_ODC = vODC;     COMENTE POR QUE MARCABA ERROR
            sel.MtdSeleccionarServicioCorteODC();*/
            if(sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    Valor = true;
                }
            }
            return Valor;
        }

        private void btnExaminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CargarPosicionColumnas())
            {
                OpenDialog.Filter = "Formato de Excel XLSX (*.xlsx)|*.xlsx|Formato de Excel XLS (*.xls)|*.xls";
                OpenDialog.FilterIndex = 1;
                OpenDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
                OpenDialog.Title = "Cargar Documento Excel";
                OpenDialog.CheckFileExists = false;
                OpenDialog.Multiselect = false;
                DialogResult result = OpenDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtRutaArchivo.Text = OpenDialog.FileName;
                    var str = string.Empty;
                    rCnt = Row_PSC_Inicio;
                    cCnt = 0;
                    try
                    {
                        rCnt = Row_PSC_Inicio;
                        SLDocument s1 = new SLDocument(OpenDialog.FileName);
                        int celdas = 0;
                        while (!String.IsNullOrEmpty(s1.GetCellValueAsString(rCnt, 1)))
                        {
                            celdas++;
                            rCnt++;
                        }
                        pgbProgreso.Properties.Maximum = celdas;
                        rCnt = Row_PSC_Inicio;
                        while (!String.IsNullOrEmpty(s1.GetCellValueAsString(rCnt, 1)))
                        {
                            pgbProgreso.Position = rCnt;
                            Application.DoEvents();
                            string vFecha = s1.GetCellValueAsDateTime(rCnt, Col_Fecha).ToString();
                            string vTimeOut = s1.GetCellValueAsString(rCnt, Col_TimeOut);
                            string vET = s1.GetCellValueAsString(rCnt, Col_ET);
                            string vRain = s1.GetCellValueAsString(rCnt, Col_Rain);
                           
                            CreatNewRowArticulo(vFecha, vTimeOut, vET, vRain);
                            rCnt++;
                        }
                        pgbProgreso.Position = 0;
                    }
                    catch (Exception EX)
                    {
                        XtraMessageBox.Show(EX.Message);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No se pudo tener acceso a los parametros para las posiciones de Excel");
            }
        }

        private void btnBuscarServicios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}