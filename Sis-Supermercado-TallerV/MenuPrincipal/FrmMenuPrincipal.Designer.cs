﻿namespace MenuPrincipal
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.PtbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbRestore = new System.Windows.Forms.PictureBox();
            this.ptbmaxi = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ptbSideBar = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmaxi)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 1;
            animation5.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 2F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation5;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.ptbCerrar);
            this.PanelContenedor.Controls.Add(this.PtbMinimizar);
            this.PanelContenedor.Controls.Add(this.ptbRestore);
            this.PanelContenedor.Controls.Add(this.ptbmaxi);
            this.bunifuTransition2.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.PanelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(270, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1130, 900);
            this.PanelContenedor.TabIndex = 8;
            this.PanelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ptbCerrar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbCerrar, BunifuAnimatorNS.DecorationType.None);
            this.ptbCerrar.Image = global::MenuPrincipal.Properties.Resources.close;
            this.ptbCerrar.Location = new System.Drawing.Point(1083, 12);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(30, 30);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCerrar.TabIndex = 5;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // PtbMinimizar
            // 
            this.PtbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.PtbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.PtbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PtbMinimizar.Image = global::MenuPrincipal.Properties.Resources.minimize;
            this.PtbMinimizar.Location = new System.Drawing.Point(1011, 12);
            this.PtbMinimizar.Name = "PtbMinimizar";
            this.PtbMinimizar.Size = new System.Drawing.Size(30, 30);
            this.PtbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizar.TabIndex = 3;
            this.PtbMinimizar.TabStop = false;
            this.PtbMinimizar.Click += new System.EventHandler(this.PtbMinimizar_Click);
            // 
            // ptbRestore
            // 
            this.ptbRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ptbRestore, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbRestore, BunifuAnimatorNS.DecorationType.None);
            this.ptbRestore.Image = global::MenuPrincipal.Properties.Resources.expand;
            this.ptbRestore.Location = new System.Drawing.Point(1047, 12);
            this.ptbRestore.Name = "ptbRestore";
            this.ptbRestore.Size = new System.Drawing.Size(30, 30);
            this.ptbRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRestore.TabIndex = 4;
            this.ptbRestore.TabStop = false;
            this.ptbRestore.Visible = false;
            this.ptbRestore.Click += new System.EventHandler(this.ptbRestore_Click);
            // 
            // ptbmaxi
            // 
            this.ptbmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ptbmaxi, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbmaxi, BunifuAnimatorNS.DecorationType.None);
            this.ptbmaxi.Image = global::MenuPrincipal.Properties.Resources.minimize__1_;
            this.ptbmaxi.Location = new System.Drawing.Point(1047, 12);
            this.ptbmaxi.Name = "ptbmaxi";
            this.ptbmaxi.Size = new System.Drawing.Size(30, 30);
            this.ptbmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbmaxi.TabIndex = 1;
            this.ptbmaxi.TabStop = false;
            this.ptbmaxi.Click += new System.EventHandler(this.ptbmaxi_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(131)))), ((int)(((byte)(189)))));
            this.SidebarWrapper.BackgroundImage = global::MenuPrincipal.Properties.Resources.paraelSliderIzquierdo2;
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton2);
            this.SidebarWrapper.Controls.Add(this.bunifuSeparator1);
            this.SidebarWrapper.Controls.Add(this.ptbSideBar);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton9);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton8);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton7);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton1);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton5);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton3);
            this.SidebarWrapper.Controls.Add(this.btnVentas);
            this.bunifuTransition2.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(270, 900);
            this.SidebarWrapper.TabIndex = 7;
            this.SidebarWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SidebarWrapper_Paint);
            this.SidebarWrapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidebarWrapper_MouseDown);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = " Usuarios";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::MenuPrincipal.Properties.Resources.IcoUsers;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 679);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton2.TabIndex = 19;
            this.bunifuFlatButton2.Text = " Usuarios";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 85);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(270, 43);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 150;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ptbSideBar
            // 
            this.ptbSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.bunifuTransition1.SetDecoration(this.ptbSideBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbSideBar, BunifuAnimatorNS.DecorationType.None);
            this.ptbSideBar.Image = global::MenuPrincipal.Properties.Resources.menuoficial2;
            this.ptbSideBar.Location = new System.Drawing.Point(12, 50);
            this.ptbSideBar.Name = "ptbSideBar";
            this.ptbSideBar.Size = new System.Drawing.Size(35, 35);
            this.ptbSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSideBar.TabIndex = 10;
            this.ptbSideBar.TabStop = false;
            this.ptbSideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbSideBar_MouseDown);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "Productos";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = global::MenuPrincipal.Properties.Resources.IcoPoductos;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 70D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(0, 237);
            this.bunifuFlatButton9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton9.TabIndex = 17;
            this.bunifuFlatButton9.Text = "Productos";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "     Devoluciones";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::MenuPrincipal.Properties.Resources.IcoDevolucion;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 70D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 312);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton8.TabIndex = 16;
            this.bunifuFlatButton8.Text = "     Devoluciones";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Clientes";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::MenuPrincipal.Properties.Resources.IcoClientes;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 70D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 387);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton7.TabIndex = 15;
            this.bunifuFlatButton7.Text = "Clientes";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Caja";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::MenuPrincipal.Properties.Resources.IcoCaja;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 462);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Caja";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = " Reportes";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::MenuPrincipal.Properties.Resources.Icoreportes;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 612);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton5.TabIndex = 14;
            this.bunifuFlatButton5.Text = " Reportes";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "  Cotizaciones";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::MenuPrincipal.Properties.Resources.IcoCotizaciones;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 70D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 537);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton3.TabIndex = 13;
            this.bunifuFlatButton3.Text = "  Cotizaciones";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "Ventas";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = global::MenuPrincipal.Properties.Resources.IcoVentas;
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = null;
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 70D;
            this.btnVentas.IsTab = false;
            this.btnVentas.Location = new System.Drawing.Point(0, 162);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(86)))), ((int)(((byte)(98)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(270, 59);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition2.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation6;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.SidebarWrapper);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmaxi)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSideBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox ptbSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox ptbRestore;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.PictureBox ptbmaxi;
        private System.Windows.Forms.PictureBox PtbMinimizar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

