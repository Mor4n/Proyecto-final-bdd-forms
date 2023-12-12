using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        bool expansionMenu= true;

        public string cUser="";
        public string cPassword="";

         string conexionABDD = "";
        public Principal()
        {
            InitializeComponent();

            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {


    }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Conexion de bdd en todo el form
           // Conectarse c = new Conectarse(cUser,cPassword);
            //Si el usuario no es admin, no podrá ver esto
            string c = $"Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=proyectoFinaltbdd;User ID=sa;Password=;";
            int admin=0;
            using (SqlConnection conexion = new SqlConnection(c))
            {
                try
                {
                    conexion.Open();
                    string consulta =  $"SELECT Rol FROM proyecto.Usuario where Nombre_Usuario='{cUser}' ";
                    SqlCommand command = new SqlCommand(consulta, conexion);
                    var esAdmin = command.ExecuteScalar();
                    admin = Convert.ToInt32(esAdmin);
                    if(admin == 0)
                    {
                        btnAuditoria.Visible = false;
                        btnReporte.Visible = false;
                        btnAdministrar.Visible = false;
                        
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error XD: " + ex.Message);
                }
                conexion.Close();

            }
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (expansionMenu)
            {
                //Si el menú está expandido, minimizalo
                menu.Width -= 10;
                if(menu.Width == menu.MinimumSize.Width) {
                    expansionMenu = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                menu.Width += 10;
                if(menu.Width == menu.MaximumSize.Width)
                {
                    expansionMenu = true;
                    timerMenu.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                timerMenu.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //Hacer visible manda el numero del caso de lo que quiero hacer visible
        //Primero ejecutar el ocultarTodo y luego el hacer visible
        public void hacerVisible()
        {

        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            // Para agarrar el imagen pbImagenJuego.Load("https://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");
        }
    }
}
