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

namespace ShellPest
{
    public partial class Frm_Recetas : DevExpress.XtraEditors.XtraForm
    {

        public string IdBloque { get; set; }
        public string Bloque { get; set; }
        public string Id_Usuario { get; set; }

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
            }
            else
            {
                txt_Monitoreo.Text = "";
                txt_Monitoreo.Visible = false;
            }
        }
    }
}