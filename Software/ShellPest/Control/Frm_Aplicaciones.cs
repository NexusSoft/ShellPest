using CapaDeDatos;
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
        public Frm_Aplicaciones()
        {
            InitializeComponent();
        }
        //Variables Bloques
        GridCheckMarksSelection gridCheckMarksBloques;
        StringBuilder sb = new StringBuilder();
        string CadenaBloques = string.Empty;
        string CadenaEspBloques= string.Empty;
        int TotalRegBloques = 0;
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
                if (TotalSelect == TotalRegBloques)
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
            CLS_Aplicaciones Clase = new CLS_Aplicaciones();
            Clase.Id_Huerta = cmb_Huertas.EditValue.ToString();
            Clase.MtdSeleccionarBloquesXHuerta();
            if (Clase.Exito)
            {
                if (Clase.Datos.Rows.Count > 0)
                {
                    gridCheckMarksBloques.ClearSelection(cmb_BloquesView);
                    TotalRegBloques = Clase.Datos.Rows.Count;
                    cmb_Bloques.Properties.DataSource = Clase.Datos;
                }
            }
        }
        //Bloques Eventos Fin
        
        private void Frm_Aplicaciones_Shown(object sender, EventArgs e)
        {
            InicializaGrigCombos();
            CargarEmpresa();
            CargarHuerta();
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
            }
        }
        private void CargarHuerta()
        {
            CLS_Aplicaciones Clase2 = new CLS_Aplicaciones();
            Clase2.Id_Usuario = Id_Usuario;
            Clase2.MtdSeleccionarHuertaXUsuario();
            if (Clase2.Exito)
            {
                cmb_Huertas.Properties.DisplayMember = "Nombre_Huerta";
                cmb_Huertas.Properties.ValueMember = "Id_Huerta";
                cmb_Huertas.EditValue = null;
                cmb_Huertas.Properties.DataSource = Clase2.Datos;
            }
        }
        private void cmb_Huerta_EditValueChanged(object sender, EventArgs e)
        {
            CargarBloques();
            CargarReceta();
        }
        private void cmb_Empresas_EditValueChanged(object sender, EventArgs e)
        {
            CargarReceta();
        }
        private void CargarReceta()
        {
            CLS_Aplicaciones Clase1 = new CLS_Aplicaciones();
            Clase1.Id_Huerta = cmb_Huertas.EditValue.ToString();
            Clase1.c_codigo_eps = cmb_Empresas.EditValue.ToString();
            Clase1.MtdSeleccionarRecetas();
            if (Clase1.Exito)
            {
                cmb_Receta.Properties.DisplayMember = "Receta_Fecha";
                cmb_Receta.Properties.ValueMember = "Id_Receta";
                cmb_Receta.EditValue = null;
                cmb_Receta.Properties.DataSource = Clase1.Datos;
            }
        }
    }
}