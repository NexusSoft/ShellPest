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

namespace ShellPest
{
    public partial class Frm_Valvulas_Riego : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Valvulas_Riego()
        {
            InitializeComponent();
        }

        private static Frm_Valvulas_Riego m_FormDefInstance;
        public static Frm_Valvulas_Riego DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Valvulas_Riego();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void Frm_Valvulas_Riego_Load(object sender, EventArgs e)
        {

        }
    }
}