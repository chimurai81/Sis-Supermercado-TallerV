using System;
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

        
        private void ptbSideBar_Click(object sender, EventArgs e)
        {
          
        }

        private void ptbSideBar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ptbSideBar_MouseDown(object sender, MouseEventArgs e)
        {

            if(SidebarWrapper.Width == 202)
            {
                SidebarWrapper.Visible = false;
                SidebarWrapper.Width = 58;
                bunifuTransition1.Show(SidebarWrapper);
            }
            else
            {
                SidebarWrapper.Visible = false;
                SidebarWrapper.Width = 202;
                bunifuTransition2.Show(SidebarWrapper);
            }

           


        }

        private void ptbSideBar_Click_1(object sender, EventArgs e)
        {
 
        }
    }
}
