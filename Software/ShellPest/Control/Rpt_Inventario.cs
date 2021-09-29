using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


namespace ShellPest
{
    public partial class Rpt_Inventario : DevExpress.XtraReports.UI.XtraReport
    {
        
        public Rpt_Inventario()
        {
            InitializeComponent();

            Fecha.Value = "20210927";

           
        }

    }
}
