namespace MenuPrincipal
{
    partial class FrmCodigodeBarra
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
            this.btxproveedor = new System.Windows.Forms.ComboBox();
            this.txtcodigodebarra = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btxcategoria = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtpreciominimo = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.ptximagen = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptximagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btxproveedor
            // 
            this.btxproveedor.FormattingEnabled = true;
            this.btxproveedor.Items.AddRange(new object[] {
            "LACTOLANDA",
            "OMO",
            "KOTEX",
            "MIKEY"});
            this.btxproveedor.Location = new System.Drawing.Point(136, 113);
            this.btxproveedor.Name = "btxproveedor";
            this.btxproveedor.Size = new System.Drawing.Size(256, 21);
            this.btxproveedor.TabIndex = 47;
            // 
            // txtcodigodebarra
            // 
            this.txtcodigodebarra.Location = new System.Drawing.Point(136, 23);
            this.txtcodigodebarra.MaxLength = 6;
            this.txtcodigodebarra.Name = "txtcodigodebarra";
            this.txtcodigodebarra.Size = new System.Drawing.Size(256, 20);
            this.txtcodigodebarra.TabIndex = 46;
            this.txtcodigodebarra.TextChanged += new System.EventHandler(this.txtcodigodebarra_TextChanged);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(136, 49);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(256, 50);
            this.txtdescripcion.TabIndex = 45;
            // 
            // btxcategoria
            // 
            this.btxcategoria.FormattingEnabled = true;
            this.btxcategoria.Items.AddRange(new object[] {
            "BEBIDAS",
            "CARNES",
            "LACTEOS",
            "PANIFICADOS"});
            this.btxcategoria.Location = new System.Drawing.Point(136, 175);
            this.btxcategoria.Name = "btxcategoria";
            this.btxcategoria.Size = new System.Drawing.Size(256, 21);
            this.btxcategoria.TabIndex = 44;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(511, 306);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(98, 43);
            this.btnsalir.TabIndex = 43;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(397, 306);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(98, 43);
            this.btnguardar.TabIndex = 42;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(136, 306);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(139, 20);
            this.txtcantidad.TabIndex = 41;
            // 
            // txtpreciominimo
            // 
            this.txtpreciominimo.Location = new System.Drawing.Point(136, 274);
            this.txtpreciominimo.Name = "txtpreciominimo";
            this.txtpreciominimo.Size = new System.Drawing.Size(139, 20);
            this.txtpreciominimo.TabIndex = 40;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(345, 244);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(139, 20);
            this.txtcosto.TabIndex = 39;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(136, 244);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(139, 20);
            this.txtprecio.TabIndex = 38;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(136, 214);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(256, 20);
            this.txtmarca.TabIndex = 37;
            // 
            // ptximagen
            // 
            this.ptximagen.Location = new System.Drawing.Point(456, 23);
            this.ptximagen.Name = "ptximagen";
            this.ptximagen.Size = new System.Drawing.Size(171, 111);
            this.ptximagen.TabIndex = 36;
            this.ptximagen.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio Minimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "CARACTERES INGRESADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Codigo de Barra";
            // 
            // FrmCodigodeBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 378);
            this.Controls.Add(this.btxproveedor);
            this.Controls.Add(this.txtcodigodebarra);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.btxcategoria);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtpreciominimo);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.ptximagen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCodigodeBarra";
            this.Text = "FrmCodigodeBarra";
            ((System.ComponentModel.ISupportInitialize)(this.ptximagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox btxproveedor;
        private System.Windows.Forms.TextBox txtcodigodebarra;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox btxcategoria;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtpreciominimo;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.PictureBox ptximagen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}