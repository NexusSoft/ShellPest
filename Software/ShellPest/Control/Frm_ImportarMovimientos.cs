using System;

using DevExpress.XtraEditors;
using CapaDeDatos;

namespace ShellPest
{
    public partial class Frm_ImportarMovimientos : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ImportarMovimientos()
        {
            InitializeComponent();
        }

        public string Id_Usuario { get; set; }

        private void Frm_ImportarMovimientos_Load(object sender, EventArgs e)
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

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ImportarMovimientos();
        }

        private void ImportarMovimientos()
        {
            CLS_Inventum Clase = new CLS_Inventum();
            Clase.Id_Usuario = Id_Usuario;

            if (glue_Empresa.EditValue != null)
            {
                Clase.c_codigo_eps = glue_Empresa.EditValue.ToString();
                Clase.MtdInsertMovimientos();
                if (Clase.Exito)
                {
                    XtraMessageBox.Show("Movimientos importados Correctamente.");
                }
                else
                {
                    XtraMessageBox.Show("¡ERROR!, Ocurrio un problema al intentar comunicarnos con la BD de INVENTUM");
                }
            }

           
        }

        
    }
}