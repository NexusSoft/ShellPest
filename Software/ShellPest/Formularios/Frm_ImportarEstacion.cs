using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaDeDatos;
using SpreadsheetLight;
using System.Data;

namespace ShellPest
{

    public partial class Frm_ImportarEstacion : DevExpress.XtraEditors.XtraForm
    {
        int rCnt = 0;
        public int Row_PSC_Inicio { get; set; }
        public int Col_PSC_Fecha { get;  set; }
        public int Col_PSC_Time { get;  set; }
        public int Col_PSC_TempOut { get; set; }
        public int Col_PSC_ET { get; set; }
        public int Col_PSC_Rain { get; private set; }
       

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
            column.ColumnName = "F_Estacion";
            column.AutoIncrement = false;
            column.Caption = "Fecha";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "T_Estacion";
            column.AutoIncrement = false;
            column.Caption = "ODC";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Temp_Out_Estacion";
            column.AutoIncrement = false;
            column.Caption = "Ubicacion";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "ET_Estacion";
            column.AutoIncrement = false;
            column.Caption = "Pesada";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Rain_Estacion";
            column.AutoIncrement = false;
            column.Caption = "Placas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgEstacion.DataSource = table;
        }
        private void CreatNewRowArticulo(string Col_Fecha , string Col_Hora ,string Col_TimeOut,string Col_ET ,string Col_Rain)
        {
            dtgValEstacion.AddNewRow();

            int rowHandle = dtgValEstacion.GetRowHandle(dtgValEstacion.DataRowCount);
            if (dtgValEstacion.IsNewItemRow(rowHandle))
            {
                dtgValEstacion.SetRowCellValue(rowHandle, dtgValEstacion.Columns["F_Estacion"], Col_Fecha);
                dtgValEstacion.SetRowCellValue(rowHandle, dtgValEstacion.Columns["T_Estacion"], Col_Hora);
                dtgValEstacion.SetRowCellValue(rowHandle, dtgValEstacion.Columns["Temp_Out_Estacion"], Col_TimeOut);
                dtgValEstacion.SetRowCellValue(rowHandle, dtgValEstacion.Columns["ET_Estacion"], Col_ET);
                dtgValEstacion.SetRowCellValue(rowHandle, dtgValEstacion.Columns["Rain_Estacion"], Col_Rain);
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
                    Row_PSC_Inicio= Convert.ToInt32(sel.Datos.Rows[0]["Row_Est_Inicio"].ToString());
                    Col_PSC_Fecha = Convert.ToInt32(sel.Datos.Rows[0]["Col_Est_Fecha"].ToString());
                    Col_PSC_Time = Convert.ToInt32(sel.Datos.Rows[0]["Col_Est_Hora"].ToString());
                    Col_PSC_TempOut = Convert.ToInt32(sel.Datos.Rows[0]["Col_Est_TempOut"].ToString());
                    Col_PSC_ET = Convert.ToInt32(sel.Datos.Rows[0]["Col_Est_ET"].ToString());
                    Col_PSC_Rain = Convert.ToInt32(sel.Datos.Rows[0]["Col_Est_Rain"].ToString());
                   
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
            
        }

        private void btnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int contadorins = 0;
            
                if (dtgValEstacion.RowCount > 0)
                {
                    pgbProgreso.Properties.Maximum = dtgValEstacion.RowCount;
                    pgbProgreso.Position = 0;
                    
                    for (int x = 0; x < dtgValEstacion.RowCount; x++)
                    {
                        int xRow = dtgValEstacion.GetVisibleRowHandle(x);
                        pgbProgreso.Position = x + 1;
                        Application.DoEvents();
                        string vFecha = dtgValEstacion.GetRowCellValue(xRow, "col_Fecha").ToString();
                        string vTimeOut = dtgValEstacion.GetRowCellValue(xRow, "col_TimeOut").ToString();
                        string vET = dtgValEstacion.GetRowCellValue(xRow, "col_ET").ToString();
                        string vRain = dtgValEstacion.GetRowCellValue(xRow, "col_Rain").ToString();
                        
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
                    XtraMessageBox.Show("Se importaron " + contadorins + " de " + dtgValEstacion.RowCount);
                    btnLimpiar.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("No existen registros para importar");
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
                            string vFecha = s1.GetCellValueAsDateTime(rCnt, Col_PSC_Fecha).ToString();
                            string vHora = s1.GetCellValueAsString(rCnt, Col_PSC_Time).ToString();
                            string vTempOut = s1.GetCellValueAsString(rCnt, Col_PSC_TempOut);
                            string vET = s1.GetCellValueAsString(rCnt, Col_PSC_ET);
                            string vRain = s1.GetCellValueAsString(rCnt, Col_PSC_Rain);
                           
                            CreatNewRowArticulo(vFecha,vHora, vTempOut, vET, vRain);
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