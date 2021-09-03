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
using DevExpress.XtraEditors.Mask;

namespace ShellPest
{
    public partial class Frm_Huertas : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }

        public string IdHuerta { get; set; }
        public string Huerta { get; set; }
        public string Id_Usuario { get; set; }

        public Frm_Huertas()
        {
            InitializeComponent();
        }
        private static Frm_Huertas m_FormDefInstance;
        public static Frm_Huertas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Huertas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public void CargarEstado(string Valor)
        {
            CLS_Estado comboEstado = new CLS_Estado();
            comboEstado.MtdSeleccionarEstado();
            if (comboEstado.Exito)
            {
                CargarComboEstado(comboEstado.Datos, Valor);
            }
        }
        private void CargarComboEstado(DataTable Datos, string Valor)
        {
            cboEstado.Properties.DisplayMember = "Nombre_Estado";
            cboEstado.Properties.ValueMember = "Id_Estado";
            cboEstado.EditValue = Valor;
            cboEstado.Properties.DataSource = Datos;
        }
        public void CargarCiudad(string Valor)
        {
            CLS_Ciudades comboCiudad = new CLS_Ciudades();
            comboCiudad.MtdSeleccionarCiudad();
            if (comboCiudad.Exito)
            {
                CargarComboCiudad(comboCiudad.Datos, Valor);
            }
        }
        private void CargarComboCiudad(DataTable Datos, string Valor)
        {
            cboCiudad.Properties.DisplayMember = "Nombre_Ciudad";
            cboCiudad.Properties.ValueMember = "Id_Ciudad";
            cboCiudad.EditValue = Valor;
            cboCiudad.Properties.DataSource = Datos;
        }
        public void CargarCalidad(string Valor)
        {
            CLS_Calidades comboCalidad = new CLS_Calidades();
            comboCalidad.MtdSeleccionarCalidad();
            if (comboCalidad.Exito)
            {
                CargarComboCalidad(comboCalidad.Datos, Valor);
            }
        }
        private void CargarComboCalidad(DataTable Datos, string Valor)
        {
            cboCalidad.Properties.DisplayMember = "Nombre_Calidad";
            cboCalidad.Properties.ValueMember = "Id_Calidad";
            cboCalidad.EditValue = Valor;
            cboCalidad.Properties.DataSource = Datos;
        }
        public void CargarCultivo(string Valor)
        {
            CLS_Cultivo comboCultivo = new CLS_Cultivo();
            comboCultivo.MtdSeleccionarCultivo();
            if (comboCultivo.Exito)
            {
                CargarComboCultivo(comboCultivo.Datos, Valor);
            }
        }
        public void CargarTratamiento(string Valor)
        {
            CLS_Tratamiento comboTratamiento = new CLS_Tratamiento();
            comboTratamiento.MtdSeleccionarTratamiento();
            if (comboTratamiento.Exito)
            {
                CargarComboTratamiento(comboTratamiento.Datos, Valor);
            }
        }
        public void CargarZona(string Valor)
        {
            CLS_Zona comboZona = new CLS_Zona();
            comboZona.MtdSeleccionarZona();
            if (comboZona.Exito)
            {
                CargarComboZona(comboZona.Datos, Valor);
            }
        }
        private void CargarComboZona(DataTable Datos, string Valor)
        {
            cboZona.Properties.DisplayMember = "Nombre_zona";
            cboZona.Properties.ValueMember = "Id_zona";
            cboZona.EditValue = Valor;
            cboZona.Properties.DataSource = Datos;
        }
        private void CargarComboCultivo(DataTable Datos, string Valor)
        {
            cboCultivo.Properties.DisplayMember = "Nombre_Cultivo";
            cboCultivo.Properties.ValueMember = "Id_Cultivo";
            cboCultivo.EditValue = Valor;
            cboCultivo.Properties.DataSource = Datos;
        }
        private void CargarComboTratamiento(DataTable Datos, string Valor)
        {
            cboTratamiento.Properties.DisplayMember = "Nombre_Tratamiento";
            cboTratamiento.Properties.ValueMember = "Id_Tratamiento";
            cboTratamiento.EditValue = Valor;
            cboTratamiento.Properties.DataSource = Datos;
        }
        private void DarFormatoCampos()
        {
            txtZona.Text = "0";
            txtZona.Properties.Mask.MaskType = MaskType.Numeric;
            txtZona.Properties.Mask.EditMask = "###,###0.00";
            txtZona.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtEste.Text = "0";
            txtEste.Properties.Mask.MaskType = MaskType.Numeric;
            txtEste.Properties.Mask.EditMask = "###,###0.00";
            txtEste.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtNorte.Text = "0";
            txtNorte.Properties.Mask.MaskType = MaskType.Numeric;
            txtNorte.Properties.Mask.EditMask = "###,###0.00";
            txtNorte.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtASMN.Text = "0";
            txtASMN.Properties.Mask.MaskType = MaskType.Numeric;
            txtASMN.Properties.Mask.EditMask = "###,###0.00";
            txtASMN.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtLatitud.Text = "0";
            txtLatitud.Properties.Mask.MaskType = MaskType.Numeric;
            txtLatitud.Properties.Mask.EditMask = "###,###0.00000";
            txtLatitud.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtLonguitud.Text = "0";
            txtLonguitud.Properties.Mask.MaskType = MaskType.Numeric;
            txtLonguitud.Properties.Mask.EditMask = "###,###0.00000";
            txtLonguitud.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void Frm_Huertas_Shown(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarEstado(null);
            CargarCiudad(null);
            CargarCalidad(null);
            CargarCultivo(null);
            CargarTratamiento(null);
            CargarZona(null);
            DarFormatoCampos();
            CargarHuertas("1");
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
            glue_Empresa.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCodigo.Enabled = false;
            txtRegistro.Text = string.Empty;
            txtNombreHuerta.Text = string.Empty;
            txtNombreProductor.Text = string.Empty;
            cboCalidad.Text = null;
            cboCiudad.Text = null;
            cboCultivo.Text = null;
            cboTratamiento.Text = null;
            cboZona.Text = null;
            cboEstado.Text = null;
            txtZona.Text = string.Empty;
            txtBanda.Text = string.Empty;
            txtEste.Text = string.Empty;
            txtNorte.Text = string.Empty;
            txtASMN.Text = string.Empty;
            txtLonguitud.Text = string.Empty;
            txtLatitud.Text = string.Empty;
        }

        private void btnProductor_Click(object sender, EventArgs e)
        {
            Frm_Productor frm = new Frm_Productor();
            frm.IdProductor = string.Empty;
            frm.Productor = string.Empty;
            frm.PaSel = true;
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            txtNombreProductor.Tag = frm.IdProductor;
            txtNombreProductor.Text = frm.Productor;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            Frm_Estado frm = new Frm_Estado();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarEstado(null);
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            Frm_Ciudad frm = new Frm_Ciudad();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarCiudad(null);
        }

        private void btnCalidad_Click(object sender, EventArgs e)
        {
            Frm_Calidad frm = new Frm_Calidad();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarCalidad(null);
        }

        private void btnCultivo_Click(object sender, EventArgs e)
        {
            Frm_Cultivo frm = new Frm_Cultivo();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarCultivo(null);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtRegistro.Text!=string.Empty)
            {
                if (txtNombreHuerta.Text != string.Empty)
                {
                    if (txtNombreProductor.Text != string.Empty)
                    {
                        if (cboEstado.EditValue != null)
                        {
                            if (cboCiudad.EditValue != null)
                            {
                                if (cboCalidad.EditValue != null)
                                {
                                    if (cboCultivo.EditValue != null)
                                    {
                                        if (cboTratamiento.EditValue != null)
                                        {
                                            if (cboZona.EditValue != null)
                                            {
                                                InsertarHuerta();
                                            }
                                            else
                                            {
                                                XtraMessageBox.Show("Falta de seleccionar un Zona Clima");
                                            }
                                        }
                                        else
                                        {
                                            XtraMessageBox.Show("Falta de seleccionar un Tratamiento");
                                        }
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Falta de seleccionar un Cultivo");
                                    }
                                }
                                else
                                {
                                    XtraMessageBox.Show("Falta de seleccionar una Calidad");
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Falta de seleccionar una Ciudad");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Falta de seleccionar un Estado");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Falta de seleccionar un Productor");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Falta de colocar el nombre de la huerta");
                }
            }
            else
            {
                XtraMessageBox.Show("Falta de colocar un registro de huerta");
            }
        }
        void CargarHuertas(string Activo)
        {
            dtgHuertas.DataSource = null;
            CLS_Huerta Clase = new CLS_Huerta();
            Clase.Activo = Activo;
            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarHuerta();
                if (Clase.Exito)
                {
                    dtgHuertas.DataSource = Clase.Datos;
                }
            }
           
            
           
        }
        private void InsertarHuerta()
        {
            CLS_Huerta Clase = new CLS_Huerta();
            Clase.Id_Huerta = txtCodigo.Text;
            Clase.Nombre_Huerta = txtNombreHuerta.Text;
            Clase.Registro_Huerta = txtRegistro.Text;
            Clase.Id_Productor = txtNombreProductor.Tag.ToString();
            Clase.Id_Estado = cboEstado.EditValue.ToString();
            Clase.Id_Ciudad = cboCiudad.EditValue.ToString();
            Clase.Id_Calidad = cboCalidad.EditValue.ToString();
            Clase.Id_Cultivo = cboCultivo.EditValue.ToString();
            Clase.Id_Tratamiento= cboTratamiento.EditValue.ToString();
            Clase.Id_zona = cboZona.EditValue.ToString();
            Clase.zona_Huerta =Convert.ToDecimal(txtZona.Text);
            Clase.banda_Huerta = txtBanda.Text;
            Clase.este_Huerta =Convert.ToDecimal(txtEste.Text);
            Clase.norte_Huerta =Convert.ToDecimal(txtNorte.Text);
            Clase.asnm_Huerta = Convert.ToDecimal(txtASMN.Text);
            Clase.latitud_Huerta = Convert.ToDecimal(txtLatitud.Text);
            Clase.longitud_Huerta = Convert.ToDecimal(txtLonguitud.Text);
            Clase.Id_Usuario = Id_Usuario;
            Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
            Clase.MtdInsertarHuerta();

            if (Clase.Exito)
            {
                CargarHuertas("1");
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        void Eliminarhuerta()
        {
            CLS_Huerta Clase = new CLS_Huerta();
            Clase.Id_Huerta = txtCodigo.Text.Trim();
            Clase.MtdEliminarHuerta();
            if (Clase.Exito)
            {
                CargarHuertas("1");
                XtraMessageBox.Show("Se ha modificado el estado del registro con exito");
                LimpiarCampos();
                bloquear(true);
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }
        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCodigo.Text.Trim().Length > 0)
            {
                Eliminarhuerta();
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un cultivo.");
            }
        }

        void bloquear(bool value)
        {
            txtCodigo.Enabled = value;
            txtNombreHuerta.Enabled = value;
            txtRegistro.Enabled = value;
            txtNombreProductor.Enabled = value;
            cboEstado.Enabled = value;
            cboCiudad.Enabled = value;
            cboCalidad.Enabled = value;
            cboCultivo.Enabled = value;
            txtZona.Enabled = value;
            txtBanda.Enabled = value;
            txtEste.Enabled = value;
            txtNorte.Enabled = value;
            txtASMN.Enabled = value;
            txtLatitud.Enabled = value;
            txtLonguitud.Enabled = value;
            btnGuardar.Enabled = value;
            
            //btnEliminar.Enabled = value;
            if (PaSel == true)
            {
                if (value == true)
                {
                    btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
        private void dtgHuertas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValHuertas.GetSelectedRows())
                {
                    DataRow row = this.dtgValHuertas.GetDataRow(i);
                    txtCodigo.Text = row["Id_Huerta"].ToString();
                    txtNombreHuerta.Text = row["Nombre_Huerta"].ToString();
                    txtRegistro.Text = row["Registro_Huerta"].ToString();
                    txtNombreProductor.Tag = row["Id_Productor"].ToString();
                    CargarProductor(row["Id_Productor"].ToString());
                    cboEstado.EditValue = row["Id_Estado"].ToString();
                    cboCiudad.EditValue = row["Id_Ciudad"].ToString();
                    cboCalidad.EditValue = row["Id_Calidad"].ToString();
                    cboCultivo.EditValue = row["Id_Cultivo"].ToString();
                    cboTratamiento.EditValue = row["Id_Tratamiento"].ToString();
                    cboZona.EditValue = row["Id_zona"].ToString();
                    txtZona.Text= row["zona_Huerta"].ToString();
                    txtBanda.Text = row["banda_Huerta"].ToString();
                    txtEste.Text= row["este_Huerta"].ToString();
                    txtNorte.Text= row["norte_Huerta"].ToString();
                    txtASMN.Text= row["asnm_Huerta"].ToString();
                    txtLatitud.Text = row["latitud_Huerta"].ToString();
                    txtLonguitud.Text = row["longitud_Huerta"].ToString();
                    if (row["Activa_Huerta"].ToString().Equals("True"))
                    {
                        labelActivo.Text = "Activo";
                        btnEliminar.Caption = "Dar de Baja";
                        labelActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                        bloquear(true);
                    }
                    else
                    {
                        labelActivo.Text = "Inactivo";
                        btnEliminar.Caption = "Dar de Alta";
                        labelActivo.ForeColor = System.Drawing.Color.Maroon;
                        bloquear(false);
                    }
                    if (txtCodigo.Text.Trim().Length > 0)
                    {
                        glue_Empresa.Enabled = false;
                    }
                    else
                    {
                        glue_Empresa.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            txtCodigo.Enabled = false;
        }

        private void CargarProductor(string v)
        {
            CLS_Productor sel = new CLS_Productor();
            sel.Id_Productor = v;
            sel.MtdSeleccionarProductor();
            if(sel.Exito)
            {
                if(sel.Datos.Rows.Count>0)
                {
                    txtNombreProductor.Text = sel.Datos.Rows[0]["Nombre_Productor"].ToString();
                }
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IdHuerta = txtCodigo.Text.Trim();
            Huerta = txtNombreHuerta.Text.Trim();
            this.Close();
        }

        private void btnZona_Click(object sender, EventArgs e)
        {
            Frm_Zona frm = new Frm_Zona();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarZona(null);
        }

        private void btnTratamiento_Click(object sender, EventArgs e)
        {
            Frm_Tratamiento frm = new Frm_Tratamiento();
            frm.Id_Usuario = Id_Usuario;
            frm.ShowDialog();
            CargarTratamiento(null);
        }

        private void chkInactiva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactiva.Checked == true)
            {
                CargarHuertas("0");
            }
            else
            {
                CargarHuertas("1");
            }

        }

        private void Frm_Huertas_Load(object sender, EventArgs e)
        {
            WS_Catalogos_Empresas Clase = new WS_Catalogos_Empresas();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                glue_Empresa.Properties.DisplayMember = "v_nombre_eps";
                glue_Empresa.Properties.ValueMember = "c_codigo_eps";
                glue_Empresa.EditValue = null;
                glue_Empresa.Properties.DataSource = Clase.Datos;
              
                if (Clase.Datos.Rows.Count > 0)
                {


                    glue_Empresa.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
            }

            
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            if (chkInactiva.Checked)
            {
                CargarHuertas("0");
            }
            else
            {
                CargarHuertas("1");
            }
            
        }
    }
}
