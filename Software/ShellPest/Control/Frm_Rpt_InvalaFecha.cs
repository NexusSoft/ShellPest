﻿using System;
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
            Rpt_Inventario R = new Rpt_Inventario();
            DateTime Fecha = Convert.ToDateTime(date_Fecha.Text.Trim());
            
            R.SFecha= Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            R.SEmpresa = glue_Empresas.EditValue.ToString();
            R.SFamIni = glue_FamIni.EditValue.ToString();
            R.SFamFin = glue_FamFin.EditValue.ToString();
            R.SSubIni = glue_SubIni.EditValue.ToString();
            R.SSubFin = glue_SubFin.EditValue.ToString();
            if (check_Cero.Checked)
            {
                R.SIncluyeCero = "S";
            }
            else
            {
                R.SIncluyeCero = "N";
            }
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
        }

        private void date_Fecha_EditValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void glue_FamIni_EditValueChanged(object sender, EventArgs e)
        {
            if (glue_FamIni.EditValue != null)
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
    }
}