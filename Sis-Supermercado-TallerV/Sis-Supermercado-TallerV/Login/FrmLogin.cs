﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Supermercado_TallerV
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        { 
            pictureBox1.Visible = false;
            bunifuTransition1.Show(pictureBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            bunifuCustomTextbox1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            bunifuCustomTextbox2.Visible = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
