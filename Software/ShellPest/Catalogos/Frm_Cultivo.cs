﻿using System;
using System.Data;
using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_Cultivo : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }

        public Frm_Cultivo()
        {
            InitializeComponent();
        }

        public string IdCultivo { get; set; }
        public string Cultivo { get; set; }
        public string Id_Usuario { get; set; }

        private void CargarCultivo(string Activo)
        {
            gridControl1.DataSource = null;
            CLS_Cultivo Clase = new CLS_Cultivo();
            Clase.Activo = Activo;
            Clase.MtdSeleccionarCultivo();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }

        private void InsertarCultivo()
        {
            CLS_Cultivo Clase = new CLS_Cultivo();

            Clase.Id_Cultivo = textId.Text.Trim();
            Clase.Nombre_Cultivo = textNombre.Text.Trim();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdInsertarCultivo();

            if (Clase.Exito)
            {
                CargarCultivo("1");
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarCultivo()
        {
            CLS_Cultivo Clase = new CLS_Cultivo();
            Clase.Id_Cultivo = textId.Text.Trim();
            Clase.Id_Usuario = Id_Usuario;
            if (check_Activo.Checked)
            {
                Clase.Activo = "1";
            }
            else
            {
                Clase.Activo = "0";
            }
            Clase.MtdEliminarCultivo();
            if (Clase.Exito)
            {
                if (check_Activo.Checked)
                {
                    CargarCultivo("0");
                }
                else
                {
                    CargarCultivo("1");
                }
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    DataRow row = this.gridView1.GetDataRow(i);
                    textId.Text = row["Id_Cultivo"].ToString();
                    textNombre.Text = row["Nombre_Cultivo"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Cultivo_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarCultivo("1");
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarCultivo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de un cultivo.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                EliminarCultivo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un cultivo.");
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdCultivo = textId.Text.Trim();
            Cultivo = textNombre.Text.Trim();
            this.Close();
        }

        private void check_Activo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Activo.Checked)
            {
                CargarCultivo("0");
                btnEliminar.Caption = "Habilitar";
            }
            else
            {
                CargarCultivo("1");
                btnEliminar.Caption = "Inhabilitar";
            }
        }
    }
}