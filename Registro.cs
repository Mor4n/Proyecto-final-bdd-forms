using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string email = txtEmail.Text;
            string codigo = txtAdmin.Text;

            string conexionABDDADMIN = "Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=;";
            crearLogin(conexionABDDADMIN, user,pass,email,codigo);
            //  crearUsuario(conexionABDDADMIN);

            this.Close();


        }

        public static void crearLogin(string con,string user, string pass, string email, string codigo)
        {
            //LOGIN
            //Añadir capa de seguridad
            /*  SecureString theSecureString = new NetworkCredential("sa", "").SecurePassword;
              theSecureString.MakeReadOnly(); //Necesario
              SqlCredential credencial = new SqlCredential("", theSecureString);*/

            //Conexion siendo SA porque SA puede crear usuarios
            // string connectionString = "Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=;";

            using (SqlConnection conexion = new SqlConnection(con))
            {


                //AQUI PROBAR CON HACER EL USER EN OTRA CONSULTA, O SEA, EJECUTAR EL USING COPYPASTE POR SEGUNDA VEZ A VER SI FUNCIONA

                string[] consultas = new string[3];
                consultas[0] = "use ProyectoFinalTBDD";
                consultas[1] = $"CREATE LOGIN {user} WITH PASSWORD = '{pass}'";
                consultas[2] = $"create user {user} for login {user} with default_schema = proyecto";

                try
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Realizar operaciones en la base de datos aquí

                    //Console.WriteLine("-----Conexión exitosa para crear login");
                    for (int i = 0; i < consultas.Length; i++)
                    {

                        using (SqlCommand command = new SqlCommand(consultas[i], conexion))
                        {
                            // Ejecutar la consulta
                            command.ExecuteNonQuery();
                            // MessageBox.Show($"Creado exitosamente {i}");
                        }

                    }


                    string[] permisosConsulta = new string[3];
                    permisosConsulta[0] = "use ProyectoFinalTBDD";
                    //Dar permisos

                    // Console.WriteLine("-----dAR PERMISOS");
                    if (codigo == "administrador")
                    {
                        //Si es admin puede hacer todo incluso crear backup y restaurar
                        permisosConsulta[1] = $"GRANT EXECUTE, INSERT, UPDATE, DELETE, SELECT, ALTER TO {user}";
                        permisosConsulta[2] = $"EXEC sp_addrolemember 'db_backupoperator', {user}";



                    }
                    else
                    {
                        //Si no lo es, entonces solo puede ver
                        permisosConsulta[1] = $"GRANT SELECT TO {user}";
                        permisosConsulta[2] = $"DENY SELECT ON proyecto.Auditoria TO {user}";
                    }
                    for (int i = 0; i < permisosConsulta.Length; i++)
                    {
                        using (SqlCommand command = new SqlCommand(permisosConsulta[i], conexion))
                        {
                            // Ejecutar la consulta
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Creado exitosamente los permisos y el usuario{i}");
                            
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                conexion.Close();
            }
            
        }


        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
