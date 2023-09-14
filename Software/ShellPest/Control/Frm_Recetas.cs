using System;

using System.Data;

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
        string VTIdHuerta;

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
            label_Modificacion.Visible = false;
            btn_LimpiaMezcla.Visible = false;

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
            //glue_Cultivo.Properties.DisplayMember = "Nombre_Cultivo";
            //glue_Cultivo.Properties.ValueMember = "Id_Cultivo";
            CLS_Cultivo Clase = new CLS_Cultivo();
            Clase.Activo = "1";
            Clase.MtdSeleccionarCultivo();
            if (Clase.Exito)
            {
                glue_Cultivo.Properties.DataSource = Clase.Datos;
            }
        }

        private void CargarListHuertas()
        {
            dtgHuertas.DataSource = null;
          
            CLS_Receta Clase = new CLS_Receta();
            Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
            Clase.Id_Receta = txtId.Text.Trim();
            Clase.MtdSeleccionarRecetaHuerta();
            if (Clase.Exito)
            {
                dtgHuertas.DataSource = Clase.Datos;
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
            Clase.Id_Huerta = "";
            //Clase.Id_Huerta = glue_Huerta.EditValue.ToString();
            if (combo_Para.SelectedIndex == 0)
            {
                Clase.Para = "A";
            }
            else
            {
                Clase.Para = "F";
            }
            
            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertarReceta();

                if (Clase.Exito)
                {
                    //groupControl2.Enabled = true;
                    XtraMessageBox.Show("Se ha Insertado el registro con exito, Vuelva a Abrir para agregar detalle");
                    if (txtId.Text.Trim().Length == 0)
                    {
                        LimpiarCampos();

                        //Todo esto es del boton de abrir, si se cambia algo del evento Abrir cambiarlo aqui tambien
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
                           // glue_Huerta.EditValue = Frm.vId_Huerta;
                            // groupControl2.Enabled = true;

                            CargarRecetaDet(Frm.vId_Receta.Trim());
                            CargarListHuertas();
                            if (Frm.vPara.Equals("A"))
                            {
                                combo_Para.SelectedIndex = 0;
                            }
                            else
                            {
                                combo_Para.SelectedIndex = 1;
                            }

                        }

                    }
                   
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
            text_ISeguridad.Text = Frm.diasseguridad;
            text_IReingreso.Text = Frm.diasingreso;
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
            Boolean valida = true;
            if (text_Presentacion.Text.ToString().Trim().Length <= 0)
            {
                valida = false;
                XtraMessageBox.Show("Es necesario Agregar un nombre de la presentación.");
            }
            if (glue_Tipo.EditValue == null)
            { 
                valida = false;
                XtraMessageBox.Show("Es necesario especificar el tipo de aplicación.");
            }
            if (glue_Asesor.EditValue == null)
            {
                valida = false;
                XtraMessageBox.Show("Es necesario seleccionar un asesor.");
            }
            if (glue_Cultivo.EditValue == null)
            {
                valida = false;
                XtraMessageBox.Show("Es necesario seleccionar un cultivo.");
            }
            
            if (valida)
            {
                InsertarReceta();
            }
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            //Se copio todo este codigo en una parte del guardado de receta, al final, si se cambia algo aqui reemplazarlo alla tambien
            Frm_AbrirReceta Frm = new Frm_AbrirReceta();
            Frm.Id_Usuario = Id_Usuario;
            Frm.vId_Receta = "";
            Frm.ShowDialog();
            if (!Frm.vId_Receta.Equals(""))
            {
                txtId.Text = Frm.vId_Receta;
                date_Fecha.EditValue = Frm.vFecha_Receta;
                glue_Asesor.EditValue = Frm.vId_AsesorTecnico;
                if (Frm.vId_MonitoreoPE.Trim().Length > 0)
                {
                    txt_Monitoreo.Text = Frm.vId_MonitoreoPE.Trim();
                    check_Monitoreo.Checked = true;
                }
                else
                {
                    check_Monitoreo.Checked = false;
                }
               
                glue_Cultivo.EditValue = Frm.vId_Cultivo;
                glue_Tipo.EditValue = Frm.vId_TipoAplicacion;
                text_Presentacion.Tag = Frm.vId_Presentacion;
                text_Presentacion.Text = Frm.vNombre_TipoAplicacion + " de " + Frm.vNombre_Presentacion + " " + Frm.vv_nombre_uni; ;
                memo_Observaciones.Text = Frm.vObservaciones;
                /* Se pasan estos datos al detalle de la receta---------------------------
                 * text_ISeguridad.Text = Frm.vIntervalo_Seguridad;
                text_IReingreso.Text = Frm.vIntervalo_Reingreso;*/
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
                //glue_Huerta.EditValue = Frm.vId_Huerta;
               // groupControl2.Enabled = true;

                CargarRecetaDet(Frm.vId_Receta.Trim());
                CargarListHuertas();
                if (Frm.vPara.Equals("A"))
                {
                    combo_Para.SelectedIndex = 0;
                }
                else
                {
                    combo_Para.SelectedIndex = 1;
                }

                LimpiarCamposDet();
               
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

        private void InsertarRecetaHuerta()
        {
            CLS_Receta Clase = new CLS_Receta();

            Clase.Id_Receta = txtId.Text.Trim();
            
            Clase.Id_Huerta = glue_Huerta.EditValue.ToString();
            
            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertarRecetaHuerta();
            }


            if (Clase.Exito)
            {
                //groupControl2.Enabled = true;

                CargarListHuertas();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
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
            //El componente activo ya no es necesario, se toma de el catalogo invproductocactivo
            //Clase.c_codigo_cac = text_Ingrediente.Tag.ToString();
            //Clase.v_nombre_cac = text_Ingrediente.Text.ToString().Trim();
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
                    if (IdSecuencia > 0)
                    {
                        label_Modificacion.Visible = true;
                        btn_LimpiaMezcla.Visible = true;
                    }
                    else
                    {
                        label_Modificacion.Visible = false;
                        btn_LimpiaMezcla.Visible = false;
                    }
                    text_Comercial.Tag = row["c_codigo_pro"].ToString();
                    text_Comercial.Text = row["v_nombre_pro"].ToString();
                    //text_Ingrediente.Tag = row["c_codigo_cac"].ToString();
                    //text_Ingrediente.Text = row["v_nombre_cac"].ToString();
                    text_ISeguridad.Text = row["v_intervaloseguridad_pro"].ToString();
                    text_IReingreso.Text = row["v_perentrada_pro"].ToString();
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
            gridControl1.DataSource = null;
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
            label_Modificacion.Visible = false;
            btn_LimpiaMezcla.Visible = false;
            text_ISeguridad.Text = "0";
            text_IReingreso.Text = "0";
            gridControl1.DataSource = null;
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
                btnAgregar.Enabled = true;
                btnEliminarHue.Enabled = true;
                dtgHuertas.Enabled = true;
                glue_Huerta.Enabled = true;
            }
            else
            {
                groupControl2.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminarHue.Enabled = false;
                dtgHuertas.Enabled = false;
                glue_Huerta.Enabled = false;
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

        private void btnEliminarHue_Click(object sender, EventArgs e)
        {
            EliminarListRecetaHuerta();
        }

        private void EliminarListRecetaHuerta()
        {
            CLS_Receta Clase = new CLS_Receta();
            Clase.Id_Receta = txtId.Text.Trim();
            Clase.Id_Huerta = VTIdHuerta;
            Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
            Clase.MtdEliminarRecetaHuerta();
            if (Clase.Exito)
            {
                CargarListHuertas();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarRecetaHuerta();
        }

        private void dtgHuertas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValHuertas.GetSelectedRows())
                {
                    DataRow row = this.dtgValHuertas.GetDataRow(i);

                    VTIdHuerta = row["Id_Huerta"].ToString();
                    
                    

                }
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btn_LimpiaMezcla_Click(object sender, EventArgs e)
        {
            LimpiarCamposDet();
            
        }

        private void text_Comercial_EditValueChanged(object sender, EventArgs e)
        {
            if (text_Comercial.Tag==null)
            {
                text_Comercial.Tag = "";
            }
                if (text_Comercial.Tag.ToString().Trim().Length > 0)
            {
                gridControl1.DataSource = null;
                CLS_Inventum Clase = new CLS_Inventum();
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.c_codigo_pro = text_Comercial.Tag.ToString().Trim();
                Clase.MtdIngredientesActSelect();
                if (Clase.Exito)
                {
                    gridControl1.DataSource = Clase.Datos;
                }

            }
                
                
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