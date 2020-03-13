namespace Sis_Supermercado_TallerV
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation13 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation14 = new BunifuAnimatorNS.Animation();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbRestore = new System.Windows.Forms.PictureBox();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.ptbmaxi = new System.Windows.Forms.PictureBox();
            this.PtbMinimizar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.ptbSideBar = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbRestore);
            this.panel2.Controls.Add(this.ptbCerrar);
            this.panel2.Controls.Add(this.ptbmaxi);
            this.panel2.Controls.Add(this.PtbMinimizar);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 900);
            this.panel2.TabIndex = 7;
            // 
            // ptbRestore
            // 
            this.ptbRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ptbRestore, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbRestore, BunifuAnimatorNS.DecorationType.None);
            this.ptbRestore.Image = global::Sis_Supermercado_TallerV.Properties.Resources.expand;
            this.ptbRestore.Location = new System.Drawing.Point(1047, 12);
            this.ptbRestore.Name = "ptbRestore";
            this.ptbRestore.Size = new System.Drawing.Size(30, 30);
            this.ptbRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRestore.TabIndex = 4;
            this.ptbRestore.TabStop = false;
            this.ptbRestore.Visible = false;
            this.ptbRestore.Click += new System.EventHandler(this.ptbMamizar_Click);
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ptbCerrar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbCerrar, BunifuAnimatorNS.DecorationType.None);
            this.ptbCerrar.Image = global::Sis_Supermercado_TallerV.Properties.Resources.close;
            this.ptbCerrar.Location = new System.Drawing.Point(1083, 12);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(30, 30);
            this.ptbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCerrar.TabIndex = 5;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // ptbmaxi
            // 
            this.ptbmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ptbmaxi, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbmaxi, BunifuAnimatorNS.DecorationType.None);
            this.ptbmaxi.Image = global::Sis_Supermercado_TallerV.Properties.Resources.minimize__1_;
            this.ptbmaxi.Location = new System.Drawing.Point(1047, 12);
            this.ptbmaxi.Name = "ptbmaxi";
            this.ptbmaxi.Size = new System.Drawing.Size(30, 30);
            this.ptbmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbmaxi.TabIndex = 1;
            this.ptbmaxi.TabStop = false;
            this.ptbmaxi.Click += new System.EventHandler(this.ptbRestaurar_Click);
            // 
            // PtbMinimizar
            // 
            this.PtbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.PtbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.PtbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PtbMinimizar.Image = global::Sis_Supermercado_TallerV.Properties.Resources.minimize;
            this.PtbMinimizar.Location = new System.Drawing.Point(1011, 12);
            this.PtbMinimizar.Name = "PtbMinimizar";
            this.PtbMinimizar.Size = new System.Drawing.Size(30, 30);
            this.PtbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMinimizar.TabIndex = 3;
            this.PtbMinimizar.TabStop = false;
            this.PtbMinimizar.Click += new System.EventHandler(this.PtbMinimizar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(131)))), ((int)(((byte)(189)))));
            this.SidebarWrapper.BackgroundImage = global::Sis_Supermercado_TallerV.Properties.Resources.paraelSliderIzquierdo;
            this.SidebarWrapper.Controls.Add(this.bunifuSeparator1);
            this.SidebarWrapper.Controls.Add(this.ptbSideBar);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton9);
            this.SidebarWrapper.Controls.Add(this.btnVentas);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton8);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton7);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton1);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton5);
            this.SidebarWrapper.Controls.Add(this.bunifuFlatButton3);
            this.bunifuTransition2.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(270, 900);
            this.SidebarWrapper.TabIndex = 6;
            // 
            // ptbSideBar
            // 
            this.bunifuTransition1.SetDecoration(this.ptbSideBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ptbSideBar, BunifuAnimatorNS.DecorationType.None);
            this.ptbSideBar.Image = global::Sis_Supermercado_TallerV.Properties.Resources.menuoficial;
            this.ptbSideBar.Location = new System.Drawing.Point(12, 38);
            this.ptbSideBar.Name = "ptbSideBar";
            this.ptbSideBar.Size = new System.Drawing.Size(40, 40);
            this.ptbSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSideBar.TabIndex = 10;
            this.ptbSideBar.TabStop = false;
            this.ptbSideBar.Click += new System.EventHandler(this.ptbSideBar_Click_1);
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
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.IcoPoductos;
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
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton9.TabIndex = 17;
            this.bunifuFlatButton9.Text = "Productos";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.IcoVentas;
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
            this.btnVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(164)))), ((int)(((byte)(213)))));
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(270, 59);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.Textcolor = System.Drawing.Color.White;
            this.btnVentas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.IcoDevolucion;
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
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton8.TabIndex = 16;
            this.bunifuFlatButton8.Text = "     Devoluciones";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.IcoClientes;
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
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton7.TabIndex = 15;
            this.bunifuFlatButton7.Text = "Clientes";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.IcoCaja;
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
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Caja";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.Icoreportes;
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
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton5.TabIndex = 14;
            this.bunifuFlatButton5.Text = " Reportes";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::Sis_Supermercado_TallerV.Properties.Resources.IcoCotizaciones;
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
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(63)))), ((int)(((byte)(105)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(270, 59);
            this.bunifuFlatButton3.TabIndex = 13;
            this.bunifuFlatButton3.Text = "  Cotizaciones";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation13.AnimateOnlyDifferences = true;
            animation13.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.BlindCoeff")));
            animation13.LeafCoeff = 0F;
            animation13.MaxTime = 1F;
            animation13.MinTime = 0F;
            animation13.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicCoeff")));
            animation13.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicShift")));
            animation13.MosaicSize = 0;
            animation13.Padding = new System.Windows.Forms.Padding(0);
            animation13.RotateCoeff = 0F;
            animation13.RotateLimit = 0F;
            animation13.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.ScaleCoeff")));
            animation13.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.SlideCoeff")));
            animation13.TimeCoeff = 0F;
            animation13.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation13;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition2.Cursor = null;
            animation14.AnimateOnlyDifferences = true;
            animation14.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.BlindCoeff")));
            animation14.LeafCoeff = 1F;
            animation14.MaxTime = 1F;
            animation14.MinTime = 0F;
            animation14.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicCoeff")));
            animation14.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicShift")));
            animation14.MosaicSize = 0;
            animation14.Padding = new System.Windows.Forms.Padding(0);
            animation14.RotateCoeff = 0F;
            animation14.RotateLimit = 0F;
            animation14.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.ScaleCoeff")));
            animation14.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.SlideCoeff")));
            animation14.TimeCoeff = 0F;
            animation14.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation14;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SidebarWrapper);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMinimizar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSideBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbRestore;
        private System.Windows.Forms.PictureBox ptbmaxi;
        private System.Windows.Forms.PictureBox PtbMinimizar;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbSideBar;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}

