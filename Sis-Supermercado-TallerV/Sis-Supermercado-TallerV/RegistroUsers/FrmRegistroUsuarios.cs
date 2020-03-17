using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Supermercado_TallerV.RegistroUsers
{
    public partial class FrmRegistroUsuarios : Form
    {
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_usuarios " + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                dataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            bunifuTransition1.Show(pictureBox1);
            GetAll("");
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
