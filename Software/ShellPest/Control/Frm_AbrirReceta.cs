using System;

using System.Data;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_AbrirReceta : DevExpress.XtraEditors.XtraForm
    {
        public Frm_AbrirReceta()
        {
            InitializeComponent();
        }

        public string vId_Receta { get; set; }
        public string vFecha_Receta { get; set; }
        public string vId_AsesorTecnico { get; set; }
        public string vNombre_AsesorTecnico { get; set; }
        public string vId_MonitoreoPE { get; set; }
        public string vId_Cultivo { get; set; }
        public string vNombre_Cultivo { get; set; }
        public string vId_TipoAplicacion { get; set; }
        public string vNombre_TipoAplicacion { get; set; }
        public string vId_Presentacion { get; set; }
        public string vNombre_Presentacion { get; set; }
        public string vId_Unidad { get; set; }
        public string vv_nombre_uni { get; set; }
        public string vObservaciones { get; set; }
        public string vIntervalo_Seguridad { get; set; }
        public string vIntervalo_Reingreso { get; set; }
        public Boolean vActivo { get; set; }
        public string vId_Huerta { get; set; }

        public string Id_Usuario { get; set; }

        private void Frm_AbrirReceta_Load(object sender, EventArgs e)
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

            CargarReceta();
        }

        private void CargarReceta()
        {
            dtgControl.DataSource = null;
            CLS_Receta Clase = new CLS_Receta();

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdSeleccionarReceta();
                if (Clase.Exito)
                {
                    dtgControl.DataSource = Clase.Datos;
                }
            }


            
        }

        private void dtgControl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValControl.GetSelectedRows())
                {
                    DataRow row = this.dtgValControl.GetDataRow(i);

                    vId_Receta = row["Id_Receta"].ToString();
                    vFecha_Receta = row["Fecha_Receta"].ToString();
                    vId_AsesorTecnico = row["Id_AsesorTecnico"].ToString();
                    vNombre_AsesorTecnico = row["Nombre_AsesorTecnico"].ToString();
                    vId_MonitoreoPE = row["Id_MonitoreoPE"].ToString();
                    vId_Cultivo = row["Id_Cultivo"].ToString();
                    vNombre_Cultivo = row["Nombre_Cultivo"].ToString();
                    vId_TipoAplicacion = row["Id_TipoAplicacion"].ToString();
                    vNombre_TipoAplicacion = row["Nombre_TipoAplicacion"].ToString();
                    vId_Presentacion = row["Id_Presentacion"].ToString();
                    vNombre_Presentacion = row["Nombre_Presentacion"].ToString();
                    vId_Unidad = row["Id_Unidad"].ToString();
                    vv_nombre_uni = row["v_nombre_uni"].ToString();
                    vObservaciones = row["Observaciones"].ToString();
                    vIntervalo_Seguridad = row["Intervalo_Seguridad"].ToString();
                    vIntervalo_Reingreso = row["Intervalo_Reingreso"].ToString();
                    vActivo= Convert.ToBoolean(row["Activo"]);
                    vId_Huerta= row["Id_Huerta"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_Receta == null)
            {
                vId_Receta = "";
            }
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vId_Receta == null)
            {
                vId_Receta = "";
            }
            this.Close();
        }

        private void dtgControl_DoubleClick(object sender, EventArgs e)
        {
            if (vId_Receta == null)
            {
                vId_Receta = "";
            }
            this.Close();
        }

        private void glue_Empresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarReceta();
        }
    }
}