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
    public partial class Frm_Rpt_InvalaFecha : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Rpt_InvalaFecha()
        {
            InitializeComponent();
        }

        public string UsuariosLogin { get; set; }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime Fecha = Convert.ToDateTime(date_Fecha.EditValue.ToString());
            string tfamini, tfamfin, tsubini, tsubfin, tincluyecero;
            if (glue_FamIni.EditValue == null)
            {
               
                tfamini = "00";
            }
            else
            {
               
                tfamini= glue_FamIni.EditValue.ToString();
            }
            if (glue_FamFin.EditValue == null)
            {
              
                tfamfin = "99";
            }
            else
            {
               
                tfamfin= glue_FamFin.EditValue.ToString();
            }
            if (glue_SubIni.EditValue == null)
            {
             
                tsubini = "0000";
            }
            else
            {
                tsubini= glue_SubIni.EditValue.ToString();

            }
            if (glue_SubFin.EditValue == null)
            {
                tsubfin = "9999";
            }
            else
            {
                tsubfin = glue_SubFin.EditValue.ToString();
            }


            if (check_Cero.Checked)
            {
                tincluyecero = "S";
            }
            else
            {
                tincluyecero = "N";
            }
            Rpt_Inventario R = new Rpt_Inventario(Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString()), glue_Empresas.EditValue.ToString(), tfamini, tfamfin, tsubini, tsubfin, tincluyecero);

           
          
            
          
            DevExpress.XtraReports.UI.ReportPrintTool Rpt = new DevExpress.XtraReports.UI.ReportPrintTool(R);
            Rpt.ShowPreviewDialog();
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

        public void CargarEmpresas()
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = UsuariosLogin;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                glue_Empresas.Properties.DisplayMember = "v_nombre_eps";
                glue_Empresas.Properties.ValueMember = "c_codigo_eps";
                glue_Empresas.EditValue = null;
                glue_Empresas.Properties.DataSource = Clase.Datos;
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        public void CargarFamilias()
        {
            CLS_Inventum MotivoSalida = new CLS_Inventum();
            MotivoSalida.c_codigo_eps = glue_Empresas.EditValue.ToString();
            MotivoSalida.MtdFamiliasSelect();
            if (MotivoSalida.Exito)
            {
                glue_FamIni.Properties.DisplayMember = "v_nombre_fam";
                glue_FamIni.Properties.ValueMember = "c_codigo_fam";
                glue_FamIni.Properties.DataSource = MotivoSalida.Datos;

                glue_FamFin.Properties.DisplayMember = "v_nombre_fam";
                glue_FamFin.Properties.ValueMember = "c_codigo_fam";
                glue_FamFin.Properties.DataSource = MotivoSalida.Datos;
            }
        }

        public void CargarSubfamilias()
        {
            CLS_Inventum MotivoSalida = new CLS_Inventum();
            MotivoSalida.c_codigo_eps = glue_Empresas.EditValue.ToString();
            MotivoSalida.cFamIni = glue_FamIni.EditValue.ToString();
            MotivoSalida.cFamFin = glue_FamFin.EditValue.ToString();
            MotivoSalida.MtdSubfamiliasSelect();
            if (MotivoSalida.Exito)
            {
                glue_SubIni.Properties.DisplayMember = "v_nombre_sfm";
                glue_SubIni.Properties.ValueMember = "c_codigo_sfm";
                glue_SubIni.Properties.DataSource = MotivoSalida.Datos;

                glue_SubFin.Properties.DisplayMember = "v_nombre_sfm";
                glue_SubFin.Properties.ValueMember = "c_codigo_sfm";
                glue_SubFin.Properties.DataSource = MotivoSalida.Datos;
            }
        }

        private void Frm_Rpt_InvalaFecha_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            date_Fecha.EditValue = DateTime.Today;

        }

        private void date_Fecha_EditValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void glue_FamIni_EditValueChanged(object sender, EventArgs e)
        {
            if (glue_FamIni.EditValue != null && glue_FamFin.EditValue != null)
            {
                CargarSubfamilias();
            }
        }

        private void glue_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            if (glue_Empresas.EditValue != null)
            {
                CargarFamilias();
            }
        }

        private void glue_FamFin_EditValueChanged(object sender, EventArgs e)
        {
            if (glue_FamIni.EditValue != null && glue_FamFin.EditValue != null)
            {
                CargarSubfamilias();
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}