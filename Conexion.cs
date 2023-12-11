using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
     class Conectarse
    {
        public Conectarse(string con)
        {
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    
                    Principal p = new Principal();
                    p.Show();
                    Login l = new Login();
                    l.Hide();
                   


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error de inicio de sesión: "+ex.Message);
                }

                }

            }

        }
    }
