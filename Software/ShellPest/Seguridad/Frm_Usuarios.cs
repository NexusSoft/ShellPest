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
    public partial class Frm_Usuarios : DevExpress.XtraEditors.XtraForm
    {
        public string UsuariosLogin { get; set; }


        private static Frm_Usuarios m_FormDefInstance;
        public static Frm_Usuarios DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Usuarios();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            gridControl1.DataSource = null;
            CLS_Usuarios Clase = new CLS_Usuarios();

            if (checkActivo.Checked)
            {
                Clase.Activo = "0";
            }else
            {
                Clase.Activo = "1";
            }

            Clase.MtdSeleccionarUsuarios();
            if (Clase.Exito)
            {
                gridControl1.DataSource = Clase.Datos;
            }
        }
        private void CargarPerfiles(string Valor)
        {
            CLS_Perfiles Clase = new CLS_Perfiles();

            Clase.MtdSeleccionarPerfiles();
            if (Clase.Exito)
            {
                cmbPerfil.Properties.DisplayMember = "Nombre_Perfil";
                cmbPerfil.Properties.ValueMember = "Id_Perfil";
                cmbPerfil.EditValue = Valor;
                cmbPerfil.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarHuerta()
        {
            CLS_Huerta Clase = new CLS_Huerta();
            
            Clase.MtdSeleccionarHuertaCorto();
            if (Clase.Exito)
            {
                cmbHuerta.Properties.DisplayMember = "Nombre_Huerta";
                cmbHuerta.Properties.ValueMember = "Id_Huerta";
                cmbHuerta.EditValue = null;
                cmbHuerta.Properties.DataSource = Clase.Datos;
            }
        }
        private void InsertarUsuarios()
        {
            Crypto encryp = new Crypto();
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();
            Clase.Nombre_Usuario =textNombre.Text.Trim();
            Clase.Contrasena =encryp.Encriptar(textContrasena.Text.Trim());
            Clase.Id_Perfil = cmbPerfil.EditValue.ToString();
            Clase.Id_Huerta = cmbHuerta.EditValue.ToString();
            Clase.Id_Usuario_Crea = UsuariosLogin;
            Clase.MtdInsertarUsuarios();
            if (Clase.Exito)
            {
               
                    CargarUsuarios();
                    XtraMessageBox.Show("Se ha Insertado el registro con exito");
                    LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarUsuarios()
        {
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();

            Clase.MtdEliminarUsuarios();
            if (Clase.Exito)
            {
                CargarUsuarios();
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
            textUsuario.Text = "";
            textNombre.Text = "";
            textContrasena.Text = "";
            textConfirmaContra.Text = "";
            cmbPerfil.EditValue = null;
            labelActivo.Visible = false;
            inabilitar(true);
        }

        private void inabilitar(Boolean sino)
        {
            groupControl1.Enabled = sino;
            btnGuardar.Enabled = sino;
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            CargarPerfiles(null);
            CargarUsuarios();
            CargarHuerta();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView1.GetSelectedRows())
                {
                    Crypto desencryp = new Crypto();
                    DataRow row = this.gridView1.GetDataRow(i);
                    textUsuario.Text = row["Id_Usuario"].ToString();
                    textNombre.Text = row["Nombre_Usuario"].ToString();
                    textContrasena.Text =desencryp.Desencriptar(row["Contrasena"].ToString());
                    textConfirmaContra.Text= desencryp.Desencriptar(row["Contrasena"].ToString());
                    cmbPerfil.EditValue = row["Id_Perfil"].ToString();
                    cmbHuerta.EditValue = row["Id_Huerta"].ToString();

                    labelActivo.Visible = true;

                    if (checkActivo.Checked)
                    {
                        labelActivo.ForeColor = System.Drawing.Color.Maroon;
                        labelActivo.Text = "Inactivo";
                        btnEliminar.Caption = "Abilitar";
                        inabilitar(false);
                    }
                    else
                    {
                        labelActivo.ForeColor = System.Drawing.Color.OliveDrab;
                        labelActivo.Text = "Activo";
                        btnEliminar.Caption = "Inabilitar";
                        inabilitar(true);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textUsuario.Text!=String.Empty)
            {
                if (textContrasena.Text.Trim().Equals(textConfirmaContra.Text.Trim()))
                {
                    InsertarUsuarios();
                }
                else
                {
                    XtraMessageBox.Show("La contraseña no coincide con la ingresada");
                }
                
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un usuario.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textUsuario.Text!=String.Empty)
            {
                EliminarUsuarios();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un registro de la lista.");
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

        private void checkActivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Frm_Perfiles frm = new Frm_Perfiles();
            frm.PaSel = true;
            frm.ShowDialog();
            CargarPerfiles(null);
        }

        private void btnHuerta_Click(object sender, EventArgs e)
        {
            Frm_Huertas frm = new Frm_Huertas();
            frm.PaSel = true;
            frm.ShowDialog();
            CargarHuerta();
        }
    }
}