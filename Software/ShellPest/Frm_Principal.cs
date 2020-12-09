using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<string> Lista = new List<string>();

        public string UsuariosLogin { get; set; }
        public string IdPerfil { get; set; }
        public Frm_Principal()
        {
            InitializeComponent();
        }
        
        
        private Boolean TieneAcceso(String valor)
        {
            foreach (string x in Lista)
            {
                if (x == valor)
                {
                    return true;
                }

            }
            return false;
        }
        private void CargarAccesos()
        {
            CLS_Perfiles_Pantallas Clase = new CLS_Perfiles_Pantallas();
            Clase.Id_Perfil = IdPerfil;
            Clase.MtdSeleccionarAccesosPermisos();
            if (Clase.Exito)
            {

                for (int x = 0; x < Clase.Datos.Rows.Count; x++)
                {
                    Lista.Add(Clase.Datos.Rows[x][0].ToString());
                }
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }
        

        private void btn_Perfiles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("001"))
            {
                Frm_Perfiles Ventana = new Frm_Perfiles();
                Ventana.UsuariosLogin = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [001]");
            }
        }

        private void btn_Pantallas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("002"))
            {
                Frm_Pantallas Ventana = new Frm_Pantallas();
                Ventana.UsuariosLogin = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [002]");
            }
        }

        private void btn_Permisos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("003"))
            {
                Frm_Permisos Ventana = new Frm_Permisos();
                Frm_Permisos.DefInstance.MdiParent = this;
                Frm_Permisos.DefInstance.UsuariosLogin = UsuariosLogin;
                Frm_Permisos.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [003]");
            }
        }

        private void btn_Usuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("004"))
            {
                Frm_Usuarios Ventana = new Frm_Usuarios();
                Frm_Usuarios.DefInstance.MdiParent = this;
                Frm_Usuarios.DefInstance.UsuariosLogin = UsuariosLogin;
                Frm_Usuarios.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [004]");
            }
        }
        private void btn_Huertas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("005"))
            {
                Frm_Pantallas Ventana = new Frm_Pantallas();
                Frm_Pantallas.DefInstance.MdiParent = this;
                Frm_Pantallas.DefInstance.UsuariosLogin = UsuariosLogin;
                Frm_Pantallas.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [005]");
            }
        }
        private void btn_Bloques_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (TieneAcceso("006"))
            //{
            //    Frm_Usuarios Ventana = new Frm_Usuarios();
            //    Frm_Usuarios.DefInstance.MdiParent = this;
            //    Frm_Usuarios.DefInstance.UsuariosLogin = UsuariosLogin;
            //    Frm_Usuarios.DefInstance.Show();
            //}
            //else
            //{
            //    XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [006]");
            //}
            Frm_Bloques Ventana = new Frm_Bloques();
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
        }

        private void btn_Plagas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (TieneAcceso("007"))
            //{
            Frm_Plagas Ventana = new Frm_Plagas();
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [007]");
            //}
        }

        private void btn_NivelPresencia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (TieneAcceso("008"))
            //{
                Frm_Humbral Ventana = new Frm_Humbral();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [008]");
            //}
        }

        private void btn_PuntoControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (TieneAcceso("009"))
            //{
            Frm_PuntoControl Ventana = new Frm_PuntoControl();
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [009]");
            //}
        }

        private void btnDeteccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Deteccion Ventana = new Frm_Deteccion();
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
            

        }

        private void btnEnfermedad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Enfermedades Ventana = new Frm_Enfermedades();
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
        }

        private void btnCultivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Cultivo Ventana = new Frm_Cultivo();
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
        }

        private void btnPais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Pais Ventana = new Frm_Pais(false);
            Ventana.Id_Usuario = UsuariosLogin;
            Ventana.ShowDialog();
        }
    }
}
