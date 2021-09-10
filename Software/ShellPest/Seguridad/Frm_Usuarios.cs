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
//using GridLookUpEditCBMultipleSelection;
using GridControlEditCBMultipleSelection;
using DevExpress.XtraEditors.Repository;

namespace ShellPest
{
    public partial class Frm_Usuarios : DevExpress.XtraEditors.XtraForm
    {
        //GridCheckMarksSelection gridCheckMarksHuerta;
        //StringBuilder sb = new StringBuilder();
        string CadenaHuerta = string.Empty, vCodigoEmpresa;
        int TotalRegHuerta = 0;
        string CadenaEspHuerta = string.Empty;

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

        public string vCodigoHuerta { get; private set; }

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
            }
            else
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
        private void CargarHuerta(string Usuario, string c_codigo_eps)
        {
            CLS_Huerta Clase = new CLS_Huerta();
            Clase.Id_Usuario = Usuario;

            if (c_codigo_eps.Trim().Length > 0)
            {
                Clase.c_codigo_eps=c_codigo_eps;
                Clase.MtdSeleccionarHuertaUsuarios();
                if (Clase.Exito)
                {
                    cmbHuerta.Properties.DisplayMember = "Nombre_Huerta";
                    cmbHuerta.Properties.ValueMember = "Id_Huerta";
                    cmbHuerta.EditValue = null;
                    cmbHuerta.Properties.DataSource = Clase.Datos;
                }
            }

                
        }
        private void InsertarUsuarios()
        {
            Crypto encryp = new Crypto();
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();
            Clase.Nombre_Usuario = textNombre.Text.Trim();
            Clase.Contrasena = encryp.Encriptar(textContrasena.Text.Trim());
            Clase.Id_Perfil = cmbPerfil.EditValue.ToString();
            

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
            BloquearSecHuertas(false);
        }

        private void BloquearSecHuertas(Boolean Habilitar)
        {
            cmbHuerta.Enabled = Habilitar;
            btnHuerta.Enabled = Habilitar;
            btnAgregar.Enabled = Habilitar;
            btnEliminarHue.Enabled = Habilitar;
            dtgHuertas.Enabled = Habilitar;


            glue_Empresas.Enabled = Habilitar;
            
            btnAgregarE.Enabled = Habilitar;
            btnEliminarE.Enabled = Habilitar;
            gridControl2.Enabled = Habilitar;
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
            
            CargarEmpresas();
            
           // CargarHuerta(null);

        }

        private void CargarEmpresas()
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Fecha = "19000101";
            Clase.MtdSeleccionarEmpresa();
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
                    textContrasena.Text = desencryp.Desencriptar(row["Contrasena"].ToString());
                    textConfirmaContra.Text = desencryp.Desencriptar(row["Contrasena"].ToString());
                    cmbPerfil.EditValue = row["Id_Perfil"].ToString();
                    //cmbHuerta.EditValue = row["Id_Huerta"].ToString();

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
                        
                        CargarGridEmpresas(row["Id_Usuario"].ToString());

                        if (gridView3.RowCount > 0)
                        {
                            gridView3.SelectRow(gridView3.GetRowHandle(0));

                            foreach (int j in gridView3.GetSelectedRows())
                            {
                                Crypto desencryp2 = new Crypto();
                                DataRow row2 = this.gridView3.GetDataRow(j);
                                CargarGridHuertas(row["Id_Usuario"].ToString(), row2["c_codigo_eps"].ToString());
                                CargarHuerta(row["Id_Usuario"].ToString(), row2["c_codigo_eps"].ToString());
                            }

                        }

                        
                        

                        BloquearSecHuertas(true);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void CargarGridHuertas(string id_usuario,string c_codigo_eps)
        {
            CLS_Usuarios sel = new CLS_Usuarios();
            sel.Id_Usuario = id_usuario;

            if (c_codigo_eps.Trim().Length>0)
            {
                sel.c_codigo_eps = c_codigo_eps;
                sel.MtdSeleccionarUsuariosHuerta();
                if (sel.Exito)
                {
                    dtgHuertas.DataSource = sel.Datos;
                }
            }

           
        }


        private void CargarGridEmpresas(string id_usuario)
        {
            CLS_Usuarios sel = new CLS_Usuarios();
            sel.Id_Usuario = id_usuario;
            sel.MtdSeleccionarUsuariosEmpresa();
            if (sel.Exito)
            {
                gridControl2.DataSource = sel.Datos;
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textUsuario.Text != String.Empty)
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
            if (textUsuario.Text != String.Empty)
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
            CargarHuerta(textUsuario.Text, vCodigoEmpresa);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();
            if (cmbHuerta.EditValue != null)
            {
                Clase.Id_Huerta = cmbHuerta.EditValue.ToString();
                Clase.Id_Usuario_Crea = UsuariosLogin;
                if (vCodigoEmpresa.Trim().Length > 0)
                {
                    Clase.c_codigo_eps = vCodigoEmpresa;
                    Clase.MtdInsertarUsuariosHuerta();
                    if (Clase.Exito)
                    {
                        XtraMessageBox.Show("Se ha Insertado la huerta con exito");
                        CargarGridHuertas(textUsuario.Text.Trim(), vCodigoEmpresa);
                        CargarHuerta(textUsuario.Text.Trim(), vCodigoEmpresa);
                    }
                    else
                    {
                        XtraMessageBox.Show(Clase.Mensaje);
                    }
                }
            }
            
            
            
        }

        private void btnEliminarHue_Click(object sender, EventArgs e)
        {
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();
            Clase.Id_Huerta = vCodigoHuerta;
            if (vCodigoEmpresa.Trim().Length > 0)
            {
                Clase.c_codigo_eps = vCodigoEmpresa;
                Clase.MtdEliminarUsuariosHuerta();
                if (Clase.Exito)
                {
                    XtraMessageBox.Show("Se ha Eliminado la huerta con exito");
                    CargarGridHuertas(textUsuario.Text.Trim(), vCodigoEmpresa);
                    CargarHuerta(textUsuario.Text.Trim(), vCodigoEmpresa);
                }
                else
                {
                    XtraMessageBox.Show(Clase.Mensaje);
                }
            }
                
        }

        private void dtgHuertas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValHuertas.GetSelectedRows())
                {
                    DataRow row = this.dtgValHuertas.GetDataRow(i);
                    vCodigoHuerta = row["Id_Huerta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();
            if (glue_Empresas.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresas.EditValue.ToString();
                Clase.Id_Usuario_Crea = UsuariosLogin;
                Clase.MtdInsertarUsuariosEmpresa();
                if (Clase.Exito)
                {
                    XtraMessageBox.Show("Se ha Insertado la empresa con exito");
                    CargarGridEmpresas(textUsuario.Text.Trim());
                    if (vCodigoEmpresa == String.Empty || vCodigoEmpresa == null)
                    {
                        CargarHuerta(textUsuario.Text.Trim(), glue_Empresas.EditValue.ToString());
                    }
                    else
                    {
                        CargarHuerta(textUsuario.Text.Trim(), vCodigoEmpresa);
                    }

                }
                else
                {
                    XtraMessageBox.Show(Clase.Mensaje);
                }
            }
            
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            CLS_Usuarios Clase = new CLS_Usuarios();
            Clase.Id_Usuario = textUsuario.Text.Trim();
            Clase.c_codigo_eps = vCodigoEmpresa;
            Clase.MtdEliminarUsuariosEmpresa();
            if (Clase.Exito)
            {
                XtraMessageBox.Show("Se ha Eliminado la huerta con exito");
                CargarGridEmpresas(textUsuario.Text.Trim());
                //CargarHuerta(textUsuario.Text.Trim());
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.gridView3.GetSelectedRows())
                {
                    DataRow row = this.gridView3.GetDataRow(i);
                    vCodigoEmpresa = row["c_codigo_eps"].ToString();
                    CargarHuerta(textUsuario.Text.Trim(), vCodigoEmpresa);
                    CargarGridHuertas(textUsuario.Text.Trim(), vCodigoEmpresa);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}