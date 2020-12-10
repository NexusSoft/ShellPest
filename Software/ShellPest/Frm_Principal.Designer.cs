namespace ShellPest
{
    partial class Frm_Principal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btn_Plagas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NivelPresencia = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Bloques = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Huertas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PuntoControl = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Perfiles = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Pantallas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Usuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Permisos = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Deteccion = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Enfermedad = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cultivo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Pais = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.SkinForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.btn_Plagas,
            this.btn_NivelPresencia,
            this.btn_Bloques,
            this.btn_Huertas,
            this.btn_PuntoControl,
            this.btn_Perfiles,
            this.btn_Pantallas,
            this.btn_Usuarios,
            this.btn_Permisos,
            this.btn_Deteccion,
            this.btn_Enfermedad,
            this.btn_Cultivo,
            this.btn_Pais,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(772, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "Skin Gallery";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btn_Plagas
            // 
            this.btn_Plagas.Caption = "Plagas";
            this.btn_Plagas.Id = 2;
            this.btn_Plagas.ImageOptions.Image = global::ShellPest.Properties.Resources.editwrappoints_16x16;
            this.btn_Plagas.ImageOptions.LargeImage = global::ShellPest.Properties.Resources.editwrappoints_32x32;
            this.btn_Plagas.Name = "btn_Plagas";
            this.btn_Plagas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Plagas_ItemClick);
            // 
            // btn_NivelPresencia
            // 
            this.btn_NivelPresencia.Caption = "Humbrales";
            this.btn_NivelPresencia.Id = 3;
            this.btn_NivelPresencia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NivelPresencia.ImageOptions.Image")));
            this.btn_NivelPresencia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NivelPresencia.ImageOptions.LargeImage")));
            this.btn_NivelPresencia.Name = "btn_NivelPresencia";
            this.btn_NivelPresencia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NivelPresencia_ItemClick);
            // 
            // btn_Bloques
            // 
            this.btn_Bloques.Caption = "Bloques";
            this.btn_Bloques.Id = 4;
            this.btn_Bloques.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bloques.ImageOptions.Image")));
            this.btn_Bloques.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Bloques.ImageOptions.LargeImage")));
            this.btn_Bloques.Name = "btn_Bloques";
            this.btn_Bloques.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Bloques_ItemClick);
            // 
            // btn_Huertas
            // 
            this.btn_Huertas.Caption = "Huertas";
            this.btn_Huertas.Id = 5;
            this.btn_Huertas.ImageOptions.Image = global::ShellPest.Properties.Resources.defaultmap_16x16;
            this.btn_Huertas.ImageOptions.LargeImage = global::ShellPest.Properties.Resources.defaultmap_32x32;
            this.btn_Huertas.Name = "btn_Huertas";
            this.btn_Huertas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Huertas_ItemClick);
            // 
            // btn_PuntoControl
            // 
            this.btn_PuntoControl.Caption = "Puntos de Control";
            this.btn_PuntoControl.Id = 6;
            this.btn_PuntoControl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_PuntoControl.ImageOptions.Image")));
            this.btn_PuntoControl.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PuntoControl.ImageOptions.LargeImage")));
            this.btn_PuntoControl.Name = "btn_PuntoControl";
            this.btn_PuntoControl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PuntoControl_ItemClick);
            // 
            // btn_Perfiles
            // 
            this.btn_Perfiles.Caption = "Perfiles";
            this.btn_Perfiles.Id = 7;
            this.btn_Perfiles.ImageOptions.Image = global::ShellPest.Properties.Resources.contact_16x16;
            this.btn_Perfiles.ImageOptions.LargeImage = global::ShellPest.Properties.Resources.contact_32x32;
            this.btn_Perfiles.Name = "btn_Perfiles";
            this.btn_Perfiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Perfiles_ItemClick);
            // 
            // btn_Pantallas
            // 
            this.btn_Pantallas.Caption = "Pantallas";
            this.btn_Pantallas.Id = 8;
            this.btn_Pantallas.ImageOptions.Image = global::ShellPest.Properties.Resources.image_16x16;
            this.btn_Pantallas.ImageOptions.LargeImage = global::ShellPest.Properties.Resources.image_32x32;
            this.btn_Pantallas.Name = "btn_Pantallas";
            this.btn_Pantallas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Pantallas_ItemClick);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Caption = "Usuarios";
            this.btn_Usuarios.Id = 9;
            this.btn_Usuarios.ImageOptions.Image = global::ShellPest.Properties.Resources.bouser_16x16;
            this.btn_Usuarios.ImageOptions.LargeImage = global::ShellPest.Properties.Resources.bouser_32x32;
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Usuarios_ItemClick);
            // 
            // btn_Permisos
            // 
            this.btn_Permisos.Caption = "Permisos";
            this.btn_Permisos.Id = 10;
            this.btn_Permisos.ImageOptions.Image = global::ShellPest.Properties.Resources.editrangepermission_16x16;
            this.btn_Permisos.ImageOptions.LargeImage = global::ShellPest.Properties.Resources.editrangepermission_32x32;
            this.btn_Permisos.Name = "btn_Permisos";
            this.btn_Permisos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Permisos_ItemClick);
            // 
            // btn_Deteccion
            // 
            this.btn_Deteccion.Caption = "Detección";
            this.btn_Deteccion.Id = 11;
            this.btn_Deteccion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deteccion.ImageOptions.Image")));
            this.btn_Deteccion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Deteccion.ImageOptions.LargeImage")));
            this.btn_Deteccion.Name = "btn_Deteccion";
            this.btn_Deteccion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeteccion_ItemClick);
            // 
            // btn_Enfermedad
            // 
            this.btn_Enfermedad.Caption = "Enfermedades";
            this.btn_Enfermedad.Id = 12;
            this.btn_Enfermedad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Enfermedad.ImageOptions.Image")));
            this.btn_Enfermedad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Enfermedad.ImageOptions.LargeImage")));
            this.btn_Enfermedad.Name = "btn_Enfermedad";
            this.btn_Enfermedad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnfermedad_ItemClick);
            // 
            // btn_Cultivo
            // 
            this.btn_Cultivo.Caption = "Cultivo";
            this.btn_Cultivo.Id = 13;
            this.btn_Cultivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cultivo.ImageOptions.Image")));
            this.btn_Cultivo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Cultivo.ImageOptions.LargeImage")));
            this.btn_Cultivo.Name = "btn_Cultivo";
            this.btn_Cultivo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCultivo_ItemClick);
            // 
            // btn_Pais
            // 
            this.btn_Pais.Caption = "Paises";
            this.btn_Pais.Id = 14;
            this.btn_Pais.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pais.ImageOptions.Image")));
            this.btn_Pais.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Pais.ImageOptions.LargeImage")));
            this.btn_Pais.Name = "btn_Pais";
            this.btn_Pais.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPais_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.ImageOptions.Image = global::ShellPest.Properties.Resources.grandtotalsoffrowscolumnspivottable_16x16;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Catalogos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Plagas);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_NivelPresencia);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Deteccion);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Enfermedad);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Catalogos de deteccion";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.ImageOptions.Image = global::ShellPest.Properties.Resources.documentmap_16x16;
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Control";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = global::ShellPest.Properties.Resources.groupbyresource_16x16;
            this.ribbonPage3.ImageOptions.ImageUri.Uri = "Up;Size16x16;Office2013";
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Seguridad";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Perfiles);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Pantallas);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Permisos);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Usuarios);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Asignacion de Permisos";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 389);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(772, 32);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // SkinForm
            // 
            this.SkinForm.EnableBonusSkins = true;
            this.SkinForm.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Pais);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Catalogos de Localidad";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Estados";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ciudad";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Huertas);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Bloques);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_PuntoControl);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Cultivo);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Catalogos de Ubicacion";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 421);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_Plagas;
        private DevExpress.XtraBars.BarButtonItem btn_NivelPresencia;
        private DevExpress.XtraBars.BarButtonItem btn_Bloques;
        private DevExpress.XtraBars.BarButtonItem btn_Huertas;
        private DevExpress.XtraBars.BarButtonItem btn_PuntoControl;
        private DevExpress.XtraBars.BarButtonItem btn_Perfiles;
        private DevExpress.XtraBars.BarButtonItem btn_Pantallas;
        private DevExpress.XtraBars.BarButtonItem btn_Usuarios;
        private DevExpress.XtraBars.BarButtonItem btn_Permisos;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel SkinForm;
        private DevExpress.XtraBars.BarButtonItem btn_Deteccion;
        private DevExpress.XtraBars.BarButtonItem btn_Enfermedad;
        private DevExpress.XtraBars.BarButtonItem btn_Cultivo;
        private DevExpress.XtraBars.BarButtonItem btn_Pais;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

