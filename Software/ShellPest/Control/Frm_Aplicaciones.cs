using CapaDeDatos;
using CapaDeDatos.Control;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridLookUpEditCBMultipleSelection;
using DevExpress.XtraEditors.Repository;

namespace ShellPest
{
    public partial class Frm_Aplicaciones : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Usuario { get; set; }
        public string v_huerta { get; set; }
        public Frm_Aplicaciones()
        {
            InitializeComponent();
        }
        //Variables Bloques
        GridCheckMarksSelection gridCheckMarksBloques;
        StringBuilder sb = new StringBuilder();
        string CadenaBloques = string.Empty;
        string CadenaEspBloques= string.Empty;
        int TotalRegFloracion = 0;
        //Variables Bloques Fin
        
        private void InicializaGrigCombos()
        {
            cmb_Bloques.CustomDisplayText += cboGridBloques_CustomDisplayText;
            cmb_Bloques.Properties.PopulateViewColumns();
            gridCheckMarksBloques = new GridCheckMarksSelection(cmb_Bloques.Properties);
            gridCheckMarksBloques.SelectionChanged += gridCheckMarksBloques_SelectionChanged;
            cmb_Bloques.Properties.Tag = gridCheckMarksBloques;
        }
        //Bloques Eventos
        void gridCheckMarksBloques_SelectionChanged(object sender, EventArgs e)
        {
            CadenaBloques = string.Empty;
            if (ActiveControl is GridLookUpEdit)
            {
                CadenaEspBloques = string.Empty;
                foreach (DataRowView rv in (sender as GridCheckMarksSelection).Selection)
                {
                    if (sb.ToString().Length > 0) { sb.Append(", "); }
                    sb.AppendFormat("{0}", rv["Id_Bloque"]);

                    if (CadenaBloques != string.Empty)
                    {
                        CadenaBloques = string.Format("{0},{1}", CadenaBloques, rv["Id_Bloque"]);
                    }
                    else
                    {
                        CadenaBloques = rv["Id_Bloque"].ToString();
                    }
                }
                int TotalSelect = gridCheckMarksBloques.SelectedCount;
                if (TotalSelect == TotalRegFloracion)
                {
                    CadenaEspBloques = "Todas";
                }
                (ActiveControl as GridLookUpEdit).Text = sb.ToString();
            }
        }
        void cboGridBloques_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            GridCheckMarksSelection gridCheckMark = sender is GridLookUpEdit ? (sender as GridLookUpEdit).Properties.Tag as GridCheckMarksSelection : (sender as RepositoryItemGridLookUpEdit).Tag as GridCheckMarksSelection;
            if (gridCheckMark == null) return;
            foreach (DataRowView rv in gridCheckMark.Selection)
            {
                if (sb.ToString().Length > 0) { sb.Append(", "); }
                sb.AppendFormat("{0}", rv["Id_Bloque"]);


            }
            e.DisplayText = sb.ToString();
            if (sb.ToString() == string.Empty)
            {
                e.DisplayText = "-Seleccionar-";
            }
        }
        private void CargarBloques()
        {
            try
            {
                v_huerta = cmb_Huerta.EditValue.ToString();
            }
            catch (Exception)
            {
                v_huerta = string.Empty;
            }
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Huerta = v_huerta;
            Clase.MtdSeleccionarBloquesXHuerta();
            if (Clase.Exito)
            {
                gridCheckMarksBloques.ClearSelection(cmb_BloquesView);
                TotalRegFloracion = Clase.Datos.Rows.Count;
                cmb_Bloques.Properties.DataSource = Clase.Datos;
            }
        }
        //Bloques Eventos Fin
        private static Frm_Aplicaciones m_FormDefInstance;
        public static Frm_Aplicaciones DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Aplicaciones();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        
        private void Frm_Aplicaciones_Shown(object sender, EventArgs e)
        {
            v_huerta=string.Empty;
            CargarEmpresa();
            CargarHuerta();
            InicializaGrigCombos();
        }

        private void CargarEmpresa()
        {
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarEmpresaXUsuario();
            if (Clase.Exito)
            {
                cmb_Empresas.Properties.DisplayMember = "v_nombre_usuemp";
                cmb_Empresas.Properties.ValueMember = "c_codigo_eps";
                cmb_Empresas.EditValue = null;
                cmb_Empresas.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {
                    cmb_Empresas.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
            }
        }
        private void CargarHuerta()
        {
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Usuario = Id_Usuario;
            Clase.MtdSeleccionarHuertaXUsuario();
            if (Clase.Exito)
            {
                cmb_Huerta.Properties.DisplayMember = "Nombre_Huerta";
                cmb_Huerta.Properties.ValueMember = "Id_Huerta";
                cmb_Huerta.EditValue = null;
                cmb_Huerta.Properties.DataSource = Clase.Datos;

                if (Clase.Datos.Rows.Count > 0)
                {
                    cmb_Huerta.EditValue = Clase.Datos.Rows[0][0].ToString();
                }
               
            }
        }
        private void cmb_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                v_huerta = cmb_Huerta.EditValue.ToString();
            }
            catch (Exception)
            {
                v_huerta = string.Empty;
            }
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Huerta = v_huerta;
            Clase.MtdSeleccionarBloquesXHuerta();
            if (Clase.Exito)
            {
                cmb_Bloques.Properties.DisplayMember = "Nombre_Bloque";
                cmb_Bloques.Properties.ValueMember = "Id_Bloque";
                cmb_Bloques.EditValue = null;
                cmb_Bloques.Properties.DataSource = Clase.Datos;
            }
        }
    }
}