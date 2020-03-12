using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuSup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ptbmaxi.Visible = false;
            ptbRestore.Visible = true;
           
            
        }

        private void PtbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ptbMamizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ptbRestore.Visible = false;
            ptbmaxi.Visible = true;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
