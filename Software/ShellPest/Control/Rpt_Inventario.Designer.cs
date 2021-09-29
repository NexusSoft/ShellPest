namespace ShellPest
{
    partial class Rpt_Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings5 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Fecha = new DevExpress.XtraReports.Parameters.Parameter();
            this.Empresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.FamIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.FamFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Constructor = objectConstructorInfo1;
            this.objectDataSource1.DataMember = "Datos";
            this.objectDataSource1.DataSource = typeof(CapaDeDatos.CLS_InventarioAlaFecha);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 18.75F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[v_abrevia_uni]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(689F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 16.74999F);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Existencia]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(589F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 16.74999F);
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextFormatString = "{0:#.00}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[v_nombre_pro]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(155.2083F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(381.25F, 16.74999F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[c_codigo_pro]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(42.29164F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 16.74999F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3});
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(217.7083F, 38.87499F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(328.125F, 23.00001F);
            this.xrLabel4.Text = "Reporte de inventario valorizado por familia de productos ";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(179.1667F, 10.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(396.875F, 17.79167F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "ALEJANDRO GUERRERO VAZQUEZ";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Fecha
            // 
            this.Fecha.Name = "Fecha";
            this.Fecha.Type = typeof(System.DateTime);
            // 
            // Empresa
            // 
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = null;
            dynamicListLookUpSettings1.DataSource = this.objectDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "v_nombre_eps";
            dynamicListLookUpSettings1.ValueMember = "c_codigo_eps";
            this.Empresa.LookUpSettings = dynamicListLookUpSettings1;
            this.Empresa.Name = "Empresa";
            this.Empresa.ValueInfo = "12";
            // 
            // FamIni
            // 
            this.FamIni.Description = "Familia del";
            dynamicListLookUpSettings2.DataAdapter = null;
            dynamicListLookUpSettings2.DataMember = null;
            dynamicListLookUpSettings2.DataSource = this.objectDataSource1;
            dynamicListLookUpSettings2.DisplayMember = "v_nombre_fam";
            dynamicListLookUpSettings2.ValueMember = "c_codigo_fam";
            this.FamIni.LookUpSettings = dynamicListLookUpSettings2;
            this.FamIni.Name = "FamIni";
            this.FamIni.ValueInfo = "01";
            // 
            // FamFin
            // 
            this.FamFin.Description = "Familia al";
            dynamicListLookUpSettings3.DataAdapter = null;
            dynamicListLookUpSettings3.DataMember = null;
            dynamicListLookUpSettings3.DataSource = this.objectDataSource1;
            dynamicListLookUpSettings3.DisplayMember = "v_nombre_fam";
            dynamicListLookUpSettings3.ValueMember = "c_codigo_fam";
            this.FamFin.LookUpSettings = dynamicListLookUpSettings3;
            this.FamFin.Name = "FamFin";
            this.FamFin.ValueInfo = "99";
            // 
            // SubIni
            // 
            this.SubIni.Description = "Subfamilia del";
            dynamicListLookUpSettings4.DataAdapter = null;
            dynamicListLookUpSettings4.DataMember = null;
            dynamicListLookUpSettings4.DataSource = this.objectDataSource1;
            dynamicListLookUpSettings4.DisplayMember = "v_nombre_sfm";
            dynamicListLookUpSettings4.ValueMember = "c_codigo_sfm";
            this.SubIni.LookUpSettings = dynamicListLookUpSettings4;
            this.SubIni.Name = "SubIni";
            this.SubIni.ValueInfo = "0001";
            // 
            // SubFin
            // 
            this.SubFin.Description = "Subfamilia al";
            dynamicListLookUpSettings5.DataAdapter = null;
            dynamicListLookUpSettings5.DataMember = null;
            dynamicListLookUpSettings5.DataSource = this.objectDataSource1;
            dynamicListLookUpSettings5.DisplayMember = "v_nombre_sfm";
            dynamicListLookUpSettings5.ValueMember = "c_codigo_sfm";
            this.SubFin.LookUpSettings = dynamicListLookUpSettings5;
            this.SubFin.Name = "SubFin";
            this.SubFin.ValueInfo = "9999";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("c_codigo_sfm", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 19.79167F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[v_nombre_sfm]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(303.125F, 18.12499F);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("c_codigo_fam", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.HeightF = 19.79167F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[v_nombre_fam]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(253.125F, 14.99999F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // Rpt_Inventario
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.FilterString = "[c_codigo_eps] = ?Empresa And [c_codigo_fam] Between(?FamIni, ?FamFin) And [c_cod" +
    "igo_sfm] Between(?SubIni, ?SubFin) And [Fecha] <= ?Fecha";
            this.Margins = new System.Drawing.Printing.Margins(25, 26, 100, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Fecha,
            this.Empresa,
            this.FamIni,
            this.FamFin,
            this.SubIni,
            this.SubFin});
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.Parameters.Parameter Fecha;
        private DevExpress.XtraReports.Parameters.Parameter Empresa;
        private DevExpress.XtraReports.Parameters.Parameter FamIni;
        private DevExpress.XtraReports.Parameters.Parameter FamFin;
        private DevExpress.XtraReports.Parameters.Parameter SubIni;
        private DevExpress.XtraReports.Parameters.Parameter SubFin;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    }
}
