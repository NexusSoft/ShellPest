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
    public partial class Frm_IngredienteActivo : DevExpress.XtraEditors.XtraForm
    {
        public Frm_IngredienteActivo()
        {
            InitializeComponent();
        }
        public string IdIngrediente { get; set; }
        public string Ingrediente { get; set; }

        private void Frm_IngredienteActivo_Load(object sender, EventArgs e)
        {
            CargarIngrediente();
        }

        private void CargarIngrediente()
        {
            dtgControl.DataSource = null;
            CLS_IngredienteActivo Clase = new CLS_IngredienteActivo();
            
            Clase.MtdSeleccionarIngrediente();
            if (Clase.Exito)
            {
                dtgControl.DataSource = Clase.Datos;
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dtgControl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValControl.GetSelectedRows())
                {
                    DataRow row = this.dtgValControl.GetDataRow(i);
           
                    IdIngrediente = row["c_codigo_cac"].ToString();
                    Ingrediente = row["v_nombre_cac"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void dtgControl_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}