﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MenuPrincipal;
using Sis_Supermercado_TallerV.RegistroUsers;
using MySql.Data.MySqlClient;

namespace Sis_Supermercado_TallerV
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        { 
            pictureBox1.Visible = false;
            bunifuTransition1.Show(pictureBox1);
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void InicioDeSesion_db_usuarios(string condicion)
        {
            string sql;
            //MySqlCommand comando;
            sql = "select * from db_usuarios where usuario = '"+txtusuario.Text+"' and password = '"+ txtpass.Text+"'" + condicion;
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
             
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    FrmMenuPrincipal2 menu = new FrmMenuPrincipal2();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            InicioDeSesion_db_usuarios("");

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuarios menu = new FrmRegistroUsuarios();
            menu.Show();
            this.Hide();
        }
    }
}
