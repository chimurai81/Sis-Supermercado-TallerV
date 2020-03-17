using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Supermercado_TallerV.RegistroUsers
{
    public class Consultas
    {
        public void Consulta_db_usuarios(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            int c, n;
            sql = $"select * from db_usuarios" + condicion;
            string nombre;
            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsDetalle");
                n = resultado.Tables["rsDetalle"].Rows.Count;
                c = 0;
                while (c < n)
                {
                    nombre = Convert.ToString(resultado.Tables["rsDetalle"].Rows[c]["Nombre"]);
                    FrmRegistroUsuarios users = new FrmRegistroUsuarios();
                    users.txtprueba.Text = nombre;

                    c++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
            
        }
        
        
    }
}
