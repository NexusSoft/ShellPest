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
    public partial class Frm_Aplicaciones : DevExpress.XtraEditors.XtraForm
    {
        public string Id_Usuario { get; set; }
        public Frm_Aplicaciones()
        {
            InitializeComponent();
        }
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
    }
}