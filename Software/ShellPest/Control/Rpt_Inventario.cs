using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


namespace ShellPest
{
    public partial class Rpt_Inventario : DevExpress.XtraReports.UI.XtraReport
    {
        public String SFecha { get; set; }
        public String SEmpresa { get; set; }
        public String SFamIni { get; set; }
        public String SFamFin { get; set; }
        public String SSubIni { get; set; }
        public String SSubFin { get; set; }
        public String SIncluyeCero { get; set; }

        public Rpt_Inventario()
        {
            InitializeComponent();

            DevExpress.DataAccess.ObjectBinding.Parameter Fecha = new DevExpress.DataAccess.ObjectBinding.Parameter();
            Fecha.Name = "Fecha";
            Fecha.Type = typeof(string);
            Fecha.Value = SFecha;

            DevExpress.DataAccess.ObjectBinding.Parameter Empresa = new DevExpress.DataAccess.ObjectBinding.Parameter();
            Empresa.Name = "Empresa";
            Empresa.Type = typeof(string);
            Empresa.Value = SEmpresa;

            DevExpress.DataAccess.ObjectBinding.Parameter FamIni = new DevExpress.DataAccess.ObjectBinding.Parameter();
            FamIni.Name = "FamIni";
            FamIni.Type = typeof(string);
            FamIni.Value = SFamIni;

            DevExpress.DataAccess.ObjectBinding.Parameter FamFin = new DevExpress.DataAccess.ObjectBinding.Parameter();
            FamFin.Name = "FamFin";
            FamFin.Type = typeof(string);
            FamFin.Value = SFamFin;

            DevExpress.DataAccess.ObjectBinding.Parameter SubIni = new DevExpress.DataAccess.ObjectBinding.Parameter();
            SubIni.Name = "SubIni";
            SubIni.Type = typeof(string);
            SubIni.Value = SSubIni;

            DevExpress.DataAccess.ObjectBinding.Parameter SubFin = new DevExpress.DataAccess.ObjectBinding.Parameter();
            SubFin.Name = "SubFin";
            SubFin.Type = typeof(string);
            SubFin.Value = SSubFin;

            DevExpress.DataAccess.ObjectBinding.Parameter IncluyeCero = new DevExpress.DataAccess.ObjectBinding.Parameter();
            IncluyeCero.Name = "IncluyeCero";
            IncluyeCero.Type = typeof(string);
            IncluyeCero.Value = SIncluyeCero;

            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo IfoContruir = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo(Fecha, Empresa, FamIni, FamFin, SubIni, SubFin, IncluyeCero);
            objectDataSource1.Constructor = IfoContruir;


        }

    }
}
