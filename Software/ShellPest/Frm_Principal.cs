using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;

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
                Frm_Huertas Ventana = new Frm_Huertas();
                Frm_Huertas.DefInstance.MdiParent = this;
                Frm_Huertas.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_Huertas.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [005]");
            }
        }
        private void btn_Bloques_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("006"))
            {
                Frm_Bloques Ventana = new Frm_Bloques();
                Frm_Bloques.DefInstance.MdiParent = this;
                Frm_Bloques.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_Bloques.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [006]");
            }

        }

        private void btn_Plagas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("007"))
            {
                Frm_Plagas Ventana = new Frm_Plagas();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [007]");
            }
        }

        private void btn_NivelPresencia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("011"))
            {
                Frm_Humbral Ventana = new Frm_Humbral();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [011]");
            }
        }

        private void btn_PuntoControl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("009"))
            {
                Frm_PuntoControl Ventana = new Frm_PuntoControl();
                Frm_PuntoControl.DefInstance.MdiParent = this;
                Frm_PuntoControl.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_PuntoControl.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [009]");
            }
        }

        private void btnDeteccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("012"))
            {
                Frm_Deteccion Ventana = new Frm_Deteccion();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [012]");
            }

        }

        private void btnEnfermedad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("013"))
            {
                Frm_Enfermedades Ventana = new Frm_Enfermedades();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [013]");
            }
        }

        private void btnCultivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("010"))
            {
                Frm_Cultivo Ventana = new Frm_Cultivo();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [010]");
            }
        }

        private void btnPais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("014"))
            {
                Frm_Pais Ventana = new Frm_Pais(false);
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [014]");
            }
        }

        private void btnEstados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("015"))
            {
                Frm_Estado Ventana = new Frm_Estado();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [015]");
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            CargarAccesos();
        }

        private void btnCiudad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("016"))
            {
                Frm_Ciudad Ventana = new Frm_Ciudad();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [016]");
            }
        }

        private void btnProductor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("017"))
            {
                Frm_Productor Ventana = new Frm_Productor();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [017]");
            }
        }

        private void btnCalidades_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("018"))
            {
                Frm_Calidad Ventana = new Frm_Calidad();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [018]");
            }
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMonitoreo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("020"))
            {
                Frm_Monitoreo Ventana = new Frm_Monitoreo();
                Frm_Monitoreo.DefInstance.MdiParent = this;
                Frm_Monitoreo.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_Monitoreo.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [020]");
            }
        }

        private void btnIndividuos_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("021"))
            {
                Frm_Individuos Ventana = new Frm_Individuos();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [021]");
            }
        }

        private void btnZonasClima_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("019"))
            {
                Frm_Zona Ventana = new Frm_Zona();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [019]");
            }
        }

        private void btn_Recetas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("020"))
            {
                Frm_Recetas Ventana = new Frm_Recetas();
                Frm_Recetas.DefInstance.MdiParent = this;
                Frm_Recetas.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_Recetas.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [020]");
            }
        }

        private void btnAlmacen_Huerta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("019"))
            {
                Frm_Almacen_Huerto Ventana = new Frm_Almacen_Huerto();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [019]");
            }
        }

        private void btn_ImpInv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("019"))
            {
                Frm_ImportarMovimientos Ventana = new Frm_ImportarMovimientos();
                Ventana.Id_Usuario = UsuariosLogin;
                Ventana.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [019]");
            }
        }



        private void btn_Salidas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("019"))
            {
                Frm_Rpt_Salidas Ventana = new Frm_Rpt_Salidas();
                Frm_Rpt_Salidas.DefInstance.MdiParent = this;
                Frm_Rpt_Salidas.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_Rpt_Salidas.DefInstance.Show();
            }
            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [019]");
            }
        }

        private void btn_rpt_invXfecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Rpt_InvalaFecha V = new Frm_Rpt_InvalaFecha();
            V.UsuariosLogin = UsuariosLogin;
            V.ShowDialog();


        }

        private void btn_EstFenologico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_EstFenologico V = new Frm_EstFenologico();
            V.PaSel = false;
            V.ShowDialog();
        }

        private void btn_Podas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Podas Ventana = new Frm_Podas();
            Frm_Podas.DefInstance.MdiParent = this;
            Frm_Podas.DefInstance.Id_Usuario = UsuariosLogin;
            Frm_Podas.DefInstance.Show();

        }

        private void btn_Aplicaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TieneAcceso("022"))
            {
                Frm_AplicacionHue Ventana = new Frm_AplicacionHue();
                Frm_AplicacionHue.DefInstance.MdiParent = this;
                Frm_AplicacionHue.DefInstance.Id_Usuario = UsuariosLogin;
                Frm_AplicacionHue.DefInstance.Show();
            }

            else
            {
                XtraMessageBox.Show("No Cuentas con acceso a esta Opcion [022]");
            }
        }

        private void btn_Combustibles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Combustibles Ventana = new Frm_Combustibles();
            Frm_Combustibles.DefInstance.MdiParent = this;
            Frm_Combustibles.DefInstance.Id_Usuario = UsuariosLogin;
            Frm_Combustibles.DefInstance.Show();
        }

        private void btn_LugarCampo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Lugar_Campo Ventana = new Frm_Lugar_Campo();
            Ventana.ShowDialog();
        }

        private void btn_Riego_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Riego Ventana = new Frm_Riego();
            Frm_Riego.DefInstance.MdiParent = this;
            Frm_Riego.DefInstance.Id_Usuario = UsuariosLogin;
            Frm_Riego.DefInstance.Show();
        }
    }

}
