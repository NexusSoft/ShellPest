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
    public partial class Frm_Recetas : DevExpress.XtraEditors.XtraForm
    {

        public string IdBloque { get; set; }
        public string Bloque { get; set; }
        public string Id_Usuario { get; set; }

        int IdSecuencia;

        string PresentacionConvercion, IdUnidadConvercion;

        public Frm_Recetas()
        {
            InitializeComponent();
        }

        private static Frm_Recetas m_FormDefInstance;
        public static Frm_Recetas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Recetas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Boolean PaSel { get; set; }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {
            txt_Monitoreo.Visible = false;

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

            CargarAsesor();
            CargarCultivo();
            CargarTipo();
            CargarUnidad();
            LimpiarCampos();
            IdSecuencia = 0;
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void check_Monitoreo_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Monitoreo.Checked)
            {
                txt_Monitoreo.Visible = true;
                btn_Monitoreo.Visible = true;
            }
            else
            {
                txt_Monitoreo.Text = "";
                txt_Monitoreo.Visible = false;
                btn_Monitoreo.Visible = false;
            }
        }

        private void btn_Asesor_Click(object sender, EventArgs e)
        {
            Frm_AsesorTecnico Frm = new Frm_AsesorTecnico();
            Frm.PaSel = false;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            CargarAsesor();
        }

        private void CargarAsesor()
        {
            glue_Asesor.EditValue = null;
            glue_Asesor.Properties.DisplayMember = "Nombre_AsesorTecnico";
            glue_Asesor.Properties.ValueMember = "Id_AsesorTecnico";
            CLS_Asesor_Tecnico Clase = new CLS_Asesor_Tecnico();
            Clase.Activo = "1";

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarAsesor();
                if (Clase.Exito)
                {
                    glue_Asesor.Properties.DataSource = Clase.Datos;
                }
            }

            
        }

        private void CargarHuertas()
        {
            glue_Huerta.EditValue = null;
            glue_Huerta.Properties.DisplayMember = "v_nombre_hue";
            glue_Huerta.Properties.ValueMember = "c_codigo_hue";
            CLS_Huerta Clase = new CLS_Huerta();
          

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarHuertaMasCorto();
                if (Clase.Exito)
                {
                    glue_Huerta.Properties.DataSource = Clase.Datos;
                }
            }


        }

        private void CargarUnidad()
        {
            glue_Unidad.EditValue = null;
            glue_Unidad.Properties.DisplayMember = "Nombre_Unidad";
            glue_Unidad.Properties.ValueMember = "Id_Unidad";
            CLS_UnidadesMedida Clase = new CLS_UnidadesMedida();
            Clase.Activo = "1";

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarUnidadesMedida();
                if (Clase.Exito)
                {
                    glue_Unidad.Properties.DataSource = Clase.Datos;
                }
            }

            
        }

        private void btn_Cultivo_Click(object sender, EventArgs e)
        {
            Frm_Cultivo Frm = new Frm_Cultivo();
            Frm.PaSel = false;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            CargarCultivo();
        }

        private void CargarCultivo()
        {
            glue_Cultivo.EditValue = null;
            glue_Cultivo.Properties.DisplayMember = "Nombre_Cultivo";
            glue_Cultivo.Properties.ValueMember = "Id_Cultivo";
            CLS_Cultivo Clase = new CLS_Cultivo();
            Clase.Activo = "1";
            Clase.MtdSeleccionarCultivo();
            if (Clase.Exito)
            {
                glue_Cultivo.Properties.DataSource = Clase.Datos;
            }
        }

        private void btn_Tipo_Click(object sender, EventArgs e)
        {
            Frm_TipoAplicacion Frm = new Frm_TipoAplicacion();
            Frm.PaSel = false;
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            CargarTipo();
        }

        private void CargarTipo()
        {
            glue_Tipo.EditValue = null;
            glue_Tipo.Properties.DisplayMember = "Nombre_TipoAplicacion";
            glue_Tipo.Properties.ValueMember = "Id_TipoAplicacion";
            CLS_TipoAplicacion Clase = new CLS_TipoAplicacion();
            Clase.Activo = "1";

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarTipo();
                if (Clase.Exito)
                {
                    glue_Tipo.Properties.DataSource = Clase.Datos;
                }
            }

            
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

        private void InsertarReceta()
        {
            CLS_Receta Clase = new CLS_Receta();

            Clase.Id_Receta = txtId.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(date_Fecha.EditValue.ToString());
            
            Clase.Fecha_Receta = Fecha.Year.ToString() + DosCero(Fecha.Month.ToString()) + DosCero(Fecha.Day.ToString());
            Clase.Id_TipoAplicacion = glue_Tipo.EditValue.ToString();
            Clase.Id_AsesorTecnico = glue_Asesor.EditValue.ToString();
            Clase.Id_Cultivo = glue_Cultivo.EditValue.ToString();
            Clase.Id_MonitoreoPE = txt_Monitoreo.Text.ToString().Trim();
            Clase.Id_Presentacion = text_Presentacion.Tag.ToString().Trim();
            Clase.Observaciones = memo_Observaciones.Text.Trim();
            Clase.Intervalo_Seguridad = Convert.ToDecimal( text_ISeguridad.Text);
            Clase.Intervalo_Reingreso = Convert.ToDecimal(text_IReingreso.Text);
            Clase.Usuario = Id_Usuario;
            Clase.Id_Huerta = glue_Huerta.EditValue.ToString();
            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertarReceta();

                if (Clase.Exito)
                {
                    //groupControl2.Enabled = true;
                    XtraMessageBox.Show("Se ha Insertado el registro con exito");
                    //LimpiarCampos();
                }
                else
                {
                    XtraMessageBox.Show(Clase.Mensaje);
                }
            }

            
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txt_Monitoreo.Tag = "";
            txt_Monitoreo.Text = "";
            text_Presentacion.Tag = "";
            text_Presentacion.Text = "";
            memo_Observaciones.Text = "";
            text_ISeguridad.Text = "0";
            text_IReingreso.Text = "0";
            if (check_Monitoreo.Checked)
            {
                check_Monitoreo.Checked = false;
            }
        }

        private void btn_Presentacion_Click(object sender, EventArgs e)
        {
            if (glue_Tipo.EditValue != null)
            {
                Frm_Presentacion Frm = new Frm_Presentacion();
                Frm.PaSel = true;
                Frm.IdTipo = glue_Tipo.EditValue.ToString();
                Frm.Id_Usuario = Id_Usuario;
                Frm.ShowDialog();
                text_Presentacion.Tag = Frm.IdPresentacion;
                text_Presentacion.Text = Frm.Tipo + " de " + Frm.Presentacion + " " + Frm.Unidad;
                PresentacionConvercion = Frm.Presentacion;
                IdUnidadConvercion = Frm.IdUnidad;
                label_Unitario.Text = "Cantidad Por " + Frm.Unidad;
            }
            
        }

        private void btn_Ingrediente_Click(object sender, EventArgs e)
        {
            Frm_NombreComercial Frm = new Frm_NombreComercial();
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            text_Comercial.Tag = Frm.IdNombreComercial;
            text_Comercial.Text = Frm.NombreComercial;
            glue_Unidad.EditValue = Frm.IdUnidad;
        }

        private void text_Dosis_EditValueChanged(object sender, EventArgs e)
        {
            if (text_Dosis.Text.Trim().Length > 0)
            {
                if (Convert.ToDecimal(PresentacionConvercion) > 0 && Convert.ToDecimal(text_Dosis.Text) > 0)
                {
                    text_Unitario.Text = Convert.ToString(Convert.ToDecimal(text_Dosis.Text) / Convert.ToDecimal(PresentacionConvercion));
                }
            }
           
           
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (text_Presentacion.Text.ToString().Trim().Length > 0)
            {
                InsertarReceta();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de la presentación.");
            }
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Frm_AbrirReceta Frm = new Frm_AbrirReceta();
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            if (!Frm.vId_Receta.Equals(""))
            {
                txtId.Text = Frm.vId_Receta;
                date_Fecha.EditValue = Frm.vFecha_Receta;
                glue_Asesor.EditValue = Frm.vId_AsesorTecnico;
                if (Frm.vId_MonitoreoPE.Trim().Length > 0)
                {
                    txt_Monitoreo.Text = Frm.vId_MonitoreoPE.Trim();
                    txt_Monitoreo.Visible = true;
                    btn_Monitoreo.Visible = true;
                }
               
                glue_Cultivo.EditValue = Frm.vId_Cultivo;
                glue_Tipo.EditValue = Frm.vId_TipoAplicacion;
                text_Presentacion.Tag = Frm.vId_Presentacion;
                text_Presentacion.Text = Frm.vNombre_TipoAplicacion + " de " + Frm.vNombre_Presentacion + " " + Frm.vv_nombre_uni; ;
                memo_Observaciones.Text = Frm.vObservaciones;
                text_ISeguridad.Text = Frm.vIntervalo_Seguridad;
                text_IReingreso.Text = Frm.vIntervalo_Reingreso;
                IdUnidadConvercion = Frm.vId_Unidad;
                PresentacionConvercion = Frm.vNombre_Presentacion;
                if (Frm.vActivo)
                {
                    btnEliminar.Caption = "Inhabilitar";
                    groupControl1.Enabled = true;
                    groupControl2.Enabled = true;
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnEliminar.Caption = "Habilitar";
                    groupControl1.Enabled = false;
                    groupControl2.Enabled = false;
                    btnGuardar.Enabled = false;
                }
               // groupControl2.Enabled = true;

                CargarRecetaDet(Frm.vId_Receta.Trim());


            }
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            InsertarRecetaDet();
        }

        private void CargarRecetaDet(string Receta)
        {
            dtgBloque.DataSource = null;
            CLS_RecetaDet Clase = new CLS_RecetaDet();
            Clase.Id_Receta = Receta;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarReceta();
                if (Clase.Exito)
                {
                    dtgBloque.DataSource = Clase.Datos;
                }
            }

           
        }

        private void InsertarRecetaDet()
        {
            CLS_RecetaDet Clase = new CLS_RecetaDet();

            Clase.Id_Receta = txtId.Text.Trim();
            DateTime Fecha = Convert.ToDateTime(date_Fecha.EditValue.ToString());

            Clase.Secuencia = IdSecuencia;
            Clase.c_codigo_pro = text_Comercial.Tag.ToString();
            Clase.v_nombre_pro = text_Comercial.Text.ToString();
            Clase.c_codigo_cac = text_Ingrediente.Tag.ToString();
            Clase.v_nombre_cac = text_Ingrediente.Text.ToString().Trim();
            Clase.c_codigo_uni = glue_Unidad.EditValue.ToString().Trim();
            Clase.Dosis = Convert.ToDecimal(text_Dosis.Text);
            Clase.Cantidad_Unitaria = Convert.ToDecimal(text_Unitario.Text);
            Clase.Descripcion = memo_Descripcion.Text;
            Clase.Id_Usuario = Id_Usuario;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertarReceta();
            }
               

            if (Clase.Exito)
            {
                //groupControl2.Enabled = true;
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCamposDet();
                CargarRecetaDet(txtId.Text.Trim());
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void dtgBloque_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValBloque.GetSelectedRows())
                {
                    DataRow row = this.dtgValBloque.GetDataRow(i);

                    IdSecuencia = Convert.ToInt32(row["Secuencia"]);
                    text_Comercial.Tag = row["c_codigo_pro"].ToString();
                    text_Comercial.Text = row["v_nombre_pro"].ToString();
                    text_Ingrediente.Tag = row["c_codigo_cac"].ToString();
                    text_Ingrediente.Text = row["v_nombre_cac"].ToString();
                    glue_Unidad.EditValue = row["c_codigo_uni"].ToString();
                    text_Dosis.Text = row["Dosis"].ToString();
                    text_Unitario.Text = row["Cantidad_Unitaria"].ToString();
                    memo_Descripcion.Text = row["Descripcion"].ToString();
                    
                }
                if (txtId.Text.Trim().Length > 0)
                {
                    glue_Empresa.Enabled = false;
                }
                else
                {
                    glue_Empresa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
            LimpiarCamposDet();
            dtgBloque.DataSource = null;
            groupControl1.Enabled = true;
            btnGuardar.Enabled = true;
            glue_Empresa.Enabled = true;
        }

        private void LimpiarCamposDet()
        {
            text_Comercial.Text = "";
            text_Comercial.Tag = "";
            text_Ingrediente.Text = "";
            text_Ingrediente.Tag = "";
            text_Dosis.Text = "0";
            text_Unitario.Text = "0";
            memo_Descripcion.Text = "";
            IdSecuencia = 0;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCamposDet();
        }

        private void txtId_EditValueChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                groupControl2.Enabled = true;
            }
            else
            {
                groupControl2.Enabled = false;
            }
        }

        private void btn_Monitoreo_Click(object sender, EventArgs e)
        {
            Frm_AbrirMonitoreoPE Frm = new Frm_AbrirMonitoreoPE();
            Frm.ShowDialog();
            txt_Monitoreo.Text = Frm.vId_PuntoControl+ Frm.vFecha.Year.ToString() + DosCero(Frm.vFecha.Month.ToString()) + DosCero(Frm.vFecha.Day.ToString());
            
        }

        private void dtgBloque_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                foreach (int i in this.dtgValBloque.GetSelectedRows())
                {
                    DataRow row = this.dtgValBloque.GetDataRow(i);

                  
                    Eliminardetalle(Convert.ToInt32(row["Secuencia"]));

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
        }

        private void Eliminardetalle(int secuencia)
        {
            CLS_RecetaDet Clase = new CLS_RecetaDet();
            Clase.Id_Receta = txtId.Text.Trim();
            Clase.Secuencia = secuencia;
            Clase.MtdEliminarReceta();
            if (Clase.Exito)
            {
                CargarRecetaDet(txtId.Text.Trim());
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCamposDet();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtId.Text.Trim().Length > 0)
            {
                InhabilitarReceta();
            }
            
                
        }

        private void InhabilitarReceta()
        {
            CLS_Receta Clase = new CLS_Receta();
            Clase.Id_Receta = txtId.Text.Trim();
            Clase.Usuario = Id_Usuario;
            if (btnEliminar.Caption.Equals("Habilitar"))
            {
                Clase.Activo = "1";
            }
            else
            {
                Clase.Activo = "0";
            }
            Clase.MtdEliminarReceta();
            if (Clase.Exito)
            {
                if (btnEliminar.Caption.Equals("Habilitar"))
                {
                    btnEliminar.Caption = "Inhabilitar";
                    groupControl1.Enabled = true;
                    groupControl2.Enabled = true;
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnEliminar.Caption = "Habilitar";
                    groupControl1.Enabled = false;
                    groupControl2.Enabled = false;
                    btnGuardar.Enabled = false;
                }
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarAsesor();
            CargarCultivo();
            CargarTipo();
            CargarUnidad();
            CargarHuertas();
        }

       

        private void btn_Ingrediente_Click_1(object sender, EventArgs e)
        {
            Frm_IngredienteActivo Frm = new Frm_IngredienteActivo();
            Frm.Id_Usuario = Id_Usuario;
            Frm.ShowDialog();
            text_Ingrediente.Tag = Frm.IdIngrediente;
            text_Ingrediente.Text = Frm.Ingrediente;
        }
    }
}