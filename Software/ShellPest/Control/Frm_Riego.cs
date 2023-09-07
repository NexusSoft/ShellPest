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
    public partial class Frm_Riego : DevExpress.XtraEditors.XtraForm
    {

        public string Id_Usuario { get; set; }
        public Frm_Riego()
        {
            InitializeComponent();
        }

        int[,] arreglo;

        private static Frm_Riego m_FormDefInstance;
        public static Frm_Riego DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Riego();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        private void Frm_Riego_Load(object sender, EventArgs e)
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;
            time_Fin.EditValue = DateTime.Parse("01/01/1900 13:00:00");
            time_Ini.EditValue = DateTime.Parse("01/01/1900 12:00:00");
           

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

                
            }
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

        private void glue_Huertas_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void CargarBloques()
        {
            glue_Bloques.Properties.DataSource = null;
            CLS_Bloque Clase = new CLS_Bloque();

            if (glue_Empresas.EditValue != null)
            {
                Clase.Id_Huerta = glue_Huertas.EditValue.ToString();
                Clase.TipoBloque = "R";
                Clase.MtdSeleccionarBloquesHuerta();
                if (Clase.Exito)
                {
                    glue_Bloques.Properties.DataSource = Clase.Datos;
                }
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS_Riego C = new CLS_Riego();
            C.Id_Bloque = glue_Bloques.EditValue.ToString().Trim();
            C.Hora = DosCero(time_Ini.Time.Hour.ToString())+":"+ DosCero(time_Ini.Time.Minute.ToString())+":"+ DosCero(time_Ini.Time.Second.ToString());
            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());

           
            C.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            C.Precipitacion_Sistema = Decimal.Parse(text_Lluvia.Text.Trim());
            C.Caudal_Inicio= Decimal.Parse(text_CauIni.Text.ToString());
            C.Caudal_Fin = Decimal.Parse(text_CauFin.Text.ToString());
            C.Horas_riego = Decimal.Parse(text_Horas.Text.Trim());
            C.Id_Usuario_Crea=Id_Usuario;
            C.c_codigo_eps=glue_Empresas.EditValue.ToString();
            C.Temperatura= Decimal.Parse(text_Temp.Text.Trim());
            C.ET = Decimal.Parse(text_ET.Text);
            Fecha = Convert.ToDateTime(DateTime.Now.ToString());
            C.F_UsuCrea= Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            C.Hora_Fin = DosCero(time_Fin.Time.Hour.ToString()) + ":" + DosCero(time_Fin.Time.Minute.ToString()) + ":" + DosCero(time_Fin.Time.Second.ToString());
            C.Id_Cambio=Int32.Parse(glue_Cambios.EditValue.ToString());
            C.MtdInsertarRiegoV2();
            if (C.Exito)
            {
                for (int n = 0; n < checkedListBox1.Items.Count; n++)
                {
                    if (checkedListBox1.GetItemChecked(n))
                    {
                        C.Id_Valvula = arreglo[n, 0];
                        C.MtdInsertRiegoV2Valvulas();
                        if (C.Exito)
                        {

                        }
                        else
                        {
                            XtraMessageBox.Show(C.Mensaje);
                        }
                    }

                }

                CargarRiego();

                

                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(C.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            text_Lluvia.Text = "0";
            text_CauIni.Text = "0";
            text_CauFin.Text = "0";
            text_ET.Text = "0";
            text_Temp.Text = "0";
        }

        private void CargarRiego()
        {
            gridControl1.DataSource = null;
            CLS_Riego C = new CLS_Riego();
            C.Id_Bloque=glue_Bloques.EditValue.ToString();
            DateTime Fecha = Convert.ToDateTime(de_Fecha.EditValue.ToString());


            C.Fecha = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            C.MtdSelectRiegoV2();
            if (C.Exito)
            {
                gridControl1.DataSource = C.Datos;
            }
        }

        private void time_Fin_EditValueChanged(object sender, EventArgs e)
        {
            //DateTime.Now.ToString("hh:mm:ss tt");
            DateTime Fini, Ffin;
            Fini = DateTime.Parse("01/01/1900 "+time_Ini.Time.ToShortTimeString());
            Ffin = DateTime.Parse("01/01/1900 " + time_Fin.Time.ToShortTimeString());
            if (Fini > Ffin)
            {
                MessageBox.Show("La fecha de Final no debe ser menor a la de inicio");
            }
            TimeSpan difHor = Ffin.Subtract(Fini);
            text_Horas.Text = difHor.TotalHours.ToString();
        }

        private void time_Ini_EditValueChanged(object sender, EventArgs e)
        {
            DateTime Fini, Ffin;
            Fini = DateTime.Parse("01/01/1900 " + time_Ini.Time.ToShortTimeString());
            Ffin = DateTime.Parse("01/01/1900 " + time_Fin.Time.ToShortTimeString());
            if (Fini.Hour > Ffin.Hour)
            {
                MessageBox.Show("La fecha de Final no debe ser menor a la de inicio");
            }
            TimeSpan difHor = Ffin.Subtract(Fini);
            text_Horas.Text = difHor.TotalHours.ToString();
        }

        private void glue_Bloques_EditValueChanged(object sender, EventArgs e)
        {
            glue_Cambios.Properties.DataSource = null;
            CLS_Riego Clase = new CLS_Riego();

            if (glue_Bloques.EditValue != null)
            {
                Clase.Id_Bloque = glue_Bloques.EditValue.ToString();
               
                Clase.MtdCargarCambiosXblq();
                if (Clase.Exito)
                {
                    glue_Cambios.Properties.DataSource = Clase.Datos;
                }
            }
            CargarRiego();
            if (gridView2.RowCount == 0)
            {
                gridControl2.DataSource = null;
            }
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            try
            {
                
                foreach (int i in this.gridView2.GetSelectedRows())
                {
                    DataRow row = this.gridView2.GetDataRow(i);
                    
                    gridControl2.DataSource = null;
                    CLS_Riego C = new CLS_Riego();
                    C.Id_Bloque = row["Id_bloque"].ToString();
                    
                    C.Hora = row["Hora"].ToString();

                    C.Fecha = DateTime.Parse(row["Fecha"].ToString()).Year.ToString()+ DosCero(DateTime.Parse(row["Fecha"].ToString()).Month.ToString())+ DosCero(DateTime.Parse(row["Fecha"].ToString()).Day.ToString());
                    C.MtdSelectRiegoValvulas();
                    if (C.Exito)
                    {
                        gridControl2.DataSource = C.Datos;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            
        }

        private void de_Fecha_EditValueChanged(object sender, EventArgs e)
        {
            if (glue_Bloques.EditValue.ToString().Length > 0)
            {
                CargarRiego();
                if (gridView2.RowCount == 0)
                {
                    gridControl2.DataSource = null;
                }
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta accion ELIMINARA el riego seleccionado en el grid, ¿Estas seguro?", " Esta accion no se puede revertir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    foreach (int i in this.gridView2.GetSelectedRows())
                    {
                        DataRow row = this.gridView2.GetDataRow(i);
                        CLS_Riego Clase = new CLS_Riego();

                        Clase.Id_Bloque = row["Id_bloque"].ToString();
                        Clase.Hora = row["Hora"].ToString();
                        Clase.Fecha = DateTime.Parse(row["Fecha"].ToString()).Year.ToString() + DosCero(DateTime.Parse(row["Fecha"].ToString()).Month.ToString()) + DosCero(DateTime.Parse(row["Fecha"].ToString()).Day.ToString());

                        Clase.MtdEliminarRiegoV2();
                        CargarRiego();
                        
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }

                

            }
        }

        private void glue_Cambios_EditValueChanged(object sender, EventArgs e)
        {
            CargarValvulasCambio();
            //checkedListBox1.SetItemChecked(0, true);
        }

        private void CargarValvulasCambio()
        {
            checkedListBox1.Items.Clear();
            CLS_Riego C = new CLS_Riego();
            C.Id_Cambio = Int32.Parse(glue_Cambios.EditValue.ToString());
            C.Id_Bloque = glue_Bloques.EditValue.ToString();

            C.MtdSelectRiegoV2Valvulas();
            if (C.Exito)
            {
                arreglo= new int[C.Datos.Rows.Count+1, 2];
                for (int n=0; n< C.Datos.Rows.Count; n++)
                {
                    checkedListBox1.Items.Add ( C.Datos.Rows[n][1].ToString());
                    arreglo[n, 0] = Int32.Parse(C.Datos.Rows[n][0].ToString());
                    arreglo[n, 1] = Int32.Parse(C.Datos.Rows[n][1].ToString());
                    checkedListBox1.SetItemChecked(n, true);
                }
                
            }
        }
    }
}