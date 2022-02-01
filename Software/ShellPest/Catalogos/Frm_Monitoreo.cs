using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using DevExpress.XtraEditors;

namespace ShellPest
{
    public partial class Frm_Monitoreo : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Usuario { get; internal set; }

        public Frm_Monitoreo()
        {
            InitializeComponent();
        }
        private static Frm_Monitoreo m_FormDefInstance;
        public static Frm_Monitoreo DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Monitoreo();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public string vIdMonitoreo { get; private set; }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_IdMonitoreo.Text = string.Empty;
            CargarZonas(null);
            CargarPlagas(null);
            CargarEnfermedad(null);
            CargarDeteccion(null);
            CargarIndividuo(null);
            CargarHumbral(null);
            CargarFenologico(null);
        }
        private void CargarZonas(string Valor)
        {
            CLS_Zona Clase = new CLS_Zona();
            Clase.MtdSeleccionarZona();
            if (Clase.Exito)
            {
                cboZona.Properties.DisplayMember = "Nombre_zona";
                cboZona.Properties.ValueMember = "Id_zona";
                cboZona.EditValue = Valor;
                cboZona.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarPlagas(string Valor)
        {
            CLS_Plagas Clase = new CLS_Plagas();
            Clase.MtdSeleccionarPlagas();
            if (Clase.Exito)
            {
                cboPlaga.Properties.DisplayMember = "Nombre_Plagas";
                cboPlaga.Properties.ValueMember = "Id_Plagas";
                cboPlaga.EditValue = Valor;
                cboPlaga.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarEnfermedad(string Valor)
        {
            CLS_Enfermedad Clase = new CLS_Enfermedad();
            Clase.MtdSeleccionarEnfermedad();
            if (Clase.Exito)
            {
                cboEnfermedad.Properties.DisplayMember = "Nombre_Enfermedad";
                cboEnfermedad.Properties.ValueMember = "Id_Enfermedad";
                cboEnfermedad.EditValue = Valor;
                cboEnfermedad.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarDeteccion(string Valor)
        {
            CLS_Deteccion Clase = new CLS_Deteccion();
            Clase.MtdSeleccionarDeteccion();
            if (Clase.Exito)
            {
                cboOrgano.Properties.DisplayMember = "Nombre_Deteccion";
                cboOrgano.Properties.ValueMember = "Id_Deteccion";
                cboOrgano.EditValue = Valor;
                cboOrgano.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarIndividuo(string Valor)
        {
            CLS_Individuo Clase = new CLS_Individuo();
            Clase.MtdSeleccionarIndividuo();
            if (Clase.Exito)
            {
                cboIndoviduo.Properties.DisplayMember = "Mostrar";
                cboIndoviduo.Properties.ValueMember = "Id_Individuo";
                cboIndoviduo.EditValue = Valor;
                cboIndoviduo.Properties.DataSource = Clase.Datos;
            }
        }
        private void CargarHumbral(string Valor)
        {
            CLS_Humbral Clase = new CLS_Humbral();
            Clase.MtdSeleccionarHumbral();
            if (Clase.Exito)
            {
                cboHumbral.Properties.DisplayMember = "Nombre_Humbral";
                cboHumbral.Properties.ValueMember = "Id_Humbral";
                cboHumbral.EditValue = Valor;
                cboHumbral.Properties.DataSource = Clase.Datos;
            }
        }

        private void CargarFenologico(string Valor)
        {
            CLS_Estado_Fenologico Clase = new CLS_Estado_Fenologico();
            if(optTipo.SelectedIndex == 0)
            {
                Clase.PoE = "P";
            }
            else
            {
                Clase.PoE = "E";
            }
           
            Clase.MtdSeleccionarFenologico();
            if (Clase.Exito)
            {
                glue_Feno.Properties.DisplayMember = "Nombre_Fenologico";
                glue_Feno.Properties.ValueMember = "Id_Fenologico";
                glue_Feno.EditValue = Valor;
                glue_Feno.Properties.DataSource = Clase.Datos;
            }
        }

        private void Frm_Monitoreo_Shown(object sender, EventArgs e)
        {
            CargarZonas(null);
            CargarPlagas(null);
            CargarEnfermedad(null);
            CargarDeteccion(null);
            CargarIndividuo(null);
            CargarHumbral(null);
            CargarMonitorieo();
            vIdMonitoreo = string.Empty;
            CargarFenologico(null);
        }

        private void CargarMonitorieo()
        {
            CLS_Monitoreo sel = new CLS_Monitoreo();
            sel.MtdSeleccionarMonitoreo();
            if (sel.Exito)
            {
                dtgMonitoreo.DataSource = sel.Datos;
            }
        }


        private void optTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optTipo.SelectedIndex == 0)
            {
                CargarPlagas(null);
                CargarEnfermedad(null);
                cboPlaga.Enabled = true;
                cboEnfermedad.Enabled = false;
                
            }
            else
            {
                CargarPlagas(null);
                CargarEnfermedad(null);
                cboPlaga.Enabled = false;
                cboEnfermedad.Enabled = true;
            }
            CargarFenologico(null);
        }

        private void btnzona_Click(object sender, EventArgs e)
        {
            Frm_Zona frm = new Frm_Zona();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarZonas(null);
        }

        private void btnPlaga_Click(object sender, EventArgs e)
        {
            Frm_Plagas frm = new Frm_Plagas();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarPlagas(null);
        }

        private void btnenfermedad_Click(object sender, EventArgs e)
        {
            Frm_Enfermedades frm = new Frm_Enfermedades();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarEnfermedad(null);
        }

        private void btnOrgano_Click(object sender, EventArgs e)
        {
            Frm_Deteccion frm = new Frm_Deteccion();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarDeteccion(null);
        }

        private void btnIndividuo_Click(object sender, EventArgs e)
        {
            Frm_Individuos frm = new Frm_Individuos();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarIndividuo(null);
        }

        private void btnHumbral_Click(object sender, EventArgs e)
        {
            Frm_Humbral frm = new Frm_Humbral();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarHumbral(null);
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboZona.EditValue != null)
            {
                if (cboOrgano.EditValue != null)
                {
                    if (cboIndoviduo.EditValue != null)
                    {
                        if (cboHumbral.EditValue != null)
                        {
                            if ((optTipo.SelectedIndex==0 && cboPlaga.EditValue!= null) || (optTipo.SelectedIndex == 1 && cboEnfermedad.EditValue != null))
                            {
                                InsertarMonitoreo();
                            }
                            else
                            {
                                XtraMessageBox.Show("Falta de seleccionar una Plaga o Enfermedad");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Falta de seleccionar un Humbral");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Falta de seleccionar Individuos");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Falta de seleccionar un Organo");
                }
            }
            else
            {
                XtraMessageBox.Show("Falta de seleccionar una zona");
            }
        }

        private void InsertarMonitoreo()
        {
            CLS_Monitoreo Clase = new CLS_Monitoreo();
            Clase.Id_monitoreo = txt_IdMonitoreo.Text;
            Clase.Id_zona = cboZona.EditValue.ToString();
            if (string.IsNullOrEmpty(Convert.ToString(cboPlaga.EditValue)))
            {
                Clase.Id_Plagas = string.Empty;
            }
            else
            {
                Clase.Id_Plagas = cboPlaga.EditValue.ToString();
            }
            if (string.IsNullOrEmpty(Convert.ToString(cboEnfermedad.EditValue)))
            {
                Clase.Id_Enfermedad = string.Empty;
            }
            else
            {
                Clase.Id_Enfermedad = cboEnfermedad.EditValue.ToString();
            }
            Clase.Id_Deteccion = cboOrgano.EditValue.ToString();
            Clase.Id_Individuo = cboIndoviduo.EditValue.ToString();
            Clase.Id_Humbral = cboHumbral.EditValue.ToString();
            Clase.Id_Usuario = Id_Usuario;
            if (glue_Feno.EditValue != null)
            {
                Clase.Id_Fenologico = glue_Feno.EditValue.ToString();
            }
            else
            {
                Clase.Id_Fenologico = "";
            }
           
            Clase.MtdInsertarMonitoreo();

            if (Clase.Exito)
            {
                CargarMonitorieo();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                btnLimpiar.PerformClick();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vIdMonitoreo.Trim().Length > 0)
            {
                EliminarMonitoreo();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un monitoreo.");
            }
        }
        void EliminarMonitoreo()
        {
            CLS_Monitoreo Clase = new CLS_Monitoreo();
            Clase.Id_monitoreo = vIdMonitoreo.Trim();
            Clase.MtdEliminarMonitoreo();
            if (Clase.Exito)
            {
                CargarMonitorieo();
                XtraMessageBox.Show("Se ha eliminado el registro con exito");
                btnLimpiar.PerformClick();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgMonitoreo_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValMonitoreo.GetSelectedRows())
                {
                    DataRow row = this.dtgValMonitoreo.GetDataRow(i);
                    txt_IdMonitoreo.Text = row["Id_monitoreo"].ToString();
                    cboZona.EditValue = row["Id_zona"].ToString();
                    cboPlaga.EditValue= row["Id_Plagas"].ToString();
                    cboEnfermedad.EditValue = row["Id_Enfermedad"].ToString();
                    cboOrgano.EditValue = row["Id_Deteccion"].ToString();
                    cboIndoviduo.EditValue = row["Id_Individuo"].ToString();
                    cboHumbral.EditValue = row["Id_Humbral"].ToString();
                    glue_Feno.EditValue = row["Id_Fenologico"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_EstFen_Click(object sender, EventArgs e)
        {
            Frm_EstFenologico V = new Frm_EstFenologico();
            V.PaSel = true;
            V.ShowDialog();
            CargarFenologico(null);
        }

        
    }
}