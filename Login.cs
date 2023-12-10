using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Security;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string conexionABDDADMIN = "Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=;";

            creacionInicial(conexionABDDADMIN);
            insertarDatosIniciales(conexionABDDADMIN);
          //  crearLogin(conexionABDDADMIN);
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }



        public static void creacionInicial(string con)
        {
            using (SqlConnection conexion = new SqlConnection(con))
            {

                string[] consultas = new string[7];
                consultas[0] = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'proyectoFinalTBDD')" +
                 "BEGIN " +
                 "CREATE DATABASE ProyectoFinalTBDD;" +
                 "END";
                consultas[1] = "use ProyectoFinalTBDD;";
                consultas[2] = "IF NOT EXISTS ( SELECT * FROM sys.schemas WHERE name = 'proyecto' ) " +
                    "BEGIN " +
                    "EXEC ('CREATE SCHEMA proyecto AUTHORIZATION [dbo]')" +
                    "END";
                consultas[3] = "IF OBJECT_ID('proyecto.Tienda','U') IS NULL " +
                    "CREATE TABLE proyecto.Tienda(" +
                    "IdJuego int primary key NOT NULL," +
                    "Portada varchar(2083)," +
                    "Nombre varchar(50) NOT NULL," +
                    "Precio money NOT NULL," +
                    "Descripcion varchar(200)" +
                    ")";
                consultas[4] = "IF OBJECT_ID('proyecto.Usuario','U') IS NULL " +
                    "CREATE TABLE proyecto.Usuario(" +
                    "IdUsuario int primary key IDENTITY(1,1)," +
                    "Nombre varchar(50) not null," +
                   "Apellido_usuario varchar(50)," +
                   "Email_usuario varchar(50) not null," +
                   "Dinero MONEY not null," +
                   "Rol CHAR DEFAULT '0');";

                consultas[5] = "IF OBJECT_ID('proyecto.Libreria','U') IS NULL " +
                    "CREATE TABLE proyecto.Libreria(" +
                    "IdLibreria int primary key Identity(1,1)," +
                    "IdUsuario int not null," +
                    "constraint IdUsuario FOREIGN KEY (IdUsuario) REFERENCES proyecto.Usuario (IdUsuario)," +
                    "IdJuego INT NOT NULL," +
                    "constraint IdJuego FOREIGN KEY (IdJuego) REFERENCES proyecto.Tienda (IdJuego)" +
                    ")";
                consultas[6] = "IF OBJECT_ID('proyecto.Auditoria','U') IS NULL " +
                    "CREATE TABLE proyecto.Auditoria(" +
                    "id_evento int IDENTITY (1,1) NOT NULL PRIMARY KEY," +
                    "tipo_evento char(10) not null," +
                    "fecha datetime not null," +
                    "descripcion nvarchar(200) null," +
                    "usuario nvarchar(100) null," +
                    "terminal nvarchar (30) null," +
                    "aplicacion nvarchar(500) not null)";



                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa");

                    for (int i = 0; i < consultas.Length; i++)
                    {

                        using (SqlCommand command = new SqlCommand(consultas[i], conexion))
                        {
                            // Ejecutar la consulta
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Creado exitosamente las tablas {i}");
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

        public static void crearLogin(string con)
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
                Console.WriteLine("Inserte nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Inserte psswd");
                string pass = Console.ReadLine();
                Console.WriteLine("Inserte código de administrador"); ;
                string codigoSecreto = Console.ReadLine();


                //AQUI PROBAR CON HACER EL USER EN OTRA CONSULTA, O SEA, EJECUTAR EL USING COPYPASTE POR SEGUNDA VEZ A VER SI FUNCIONA

                string[] consultas = new string[3];
                consultas[0] = "use ProyectoFinalTBDD";
                consultas[1] = $"CREATE LOGIN {nombre} WITH PASSWORD = '{pass}'";
                consultas[2] = $"create user {nombre} for login {nombre} with default_schema = proyecto";

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
                            MessageBox.Show($"Creado exitosamente {i}");
                        }

                    }


                    string[] permisosConsulta = new string[3];
                    permisosConsulta[0] = "use ProyectoFinalTBDD";
                    //Dar permisos

                   // Console.WriteLine("-----dAR PERMISOS");
                    if (codigoSecreto == "administrador")
                    {
                        //Si es admin puede hacer todo incluso crear backup y restaurar
                        permisosConsulta[1] = $"GRANT EXECUTE, INSERT, UPDATE, DELETE, SELECT, ALTER TO {nombre}";
                        permisosConsulta[2] = $"EXEC sp_addrolemember 'db_backupoperator', {nombre}";



                    }
                    else
                    {
                        //Si no lo es, entonces solo puede ver
                        permisosConsulta[1] = $"GRANT SELECT TO {nombre}";
                        permisosConsulta[2] = $"DENY SELECT ON proyecto.Auditoria TO {nombre}";
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

        public static void insertarDatosIniciales(string con)
        {
            string[] consultas = new string[5];
            consultas[0] = "use ProyectoFinalTBDD";
            consultas[1] = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('proyecto.proce_BaseTienda'))" +
                "BEGIN " +
                "EXEC('" +
                "CREATE PROCEDURE proyecto.proce_BaseTienda(" +
                "@IdJuego INT,         " +
                "@Portada VARCHAR(2083),         " +
                "@Nombre VARCHAR(50),         " +
                "@Precio MONEY,        " +
                "@Descripcion VARCHAR(200)) " +
                "AS  " +
                "BEGIN         " +
                "INSERT INTO proyecto.Tienda  (" +
                "IdJuego," +
                "Portada," +
                "Nombre," +
                "Precio, " +
                "Descripcion) " +
                "VALUES ( " +
                "@IdJuego," +
                "@Portada, " +
                "@Nombre, " +
                "@Precio, " +
                "@Descripcion)" +
                "END')" +
                "END;";
            consultas[2] = "exec proyecto.proce_BaseTienda " +
                "@IdJuego = 1, " +
                "@Portada = 'https://m.media-amazon.com/images/I/51IEdiDwpUL._AC_UF894,1000_QL80_.jpg'," +
                " @Nombre = 'Super Mario Bros.', " +
                "@Precio = 50, " +
                "@Descripcion = 'Un clásico juego de plataformas de Nintendo.';";
            consultas[3] = "exec proyecto.proce_BaseTienda " +
                "@IdJuego = 2, " +
                "@Portada = 'https://image.api.playstation.com/vulcan/ap/rnd/202111/3013/cKZ4tKNFj9C00giTzYtH8PF1.png'," +
                "@Nombre = 'Cyberpunk 2077', " +
                "@Precio = 1000, " +
                "@Descripcion = 'Es un juego de rol de acción y aventura de mundo abierto ambientado en Night City, una megalópolis obsesionada con el poder, el glamour y la modificación del cuerpo. Juega como V, un mercenario ciberpunk, y enfréntate a las fuerzas más poderosas de la ciudad en una lucha por la gloria y la supervivencia..';";
            consultas[4] = "exec proyecto.proce_BaseTienda " +
             "@IdJuego = 3, " +
             "@Portada = 'https://i0.wp.com/eisenhowerlibrary.org/wp-content/uploads/2023/02/Kirby-and-the-forgotten-land-blog-image.png?fit=1080%2C1080&ssl=1'," +
             " @Nombre = 'Kirby and the forgotten land', " +
             "@Precio = 1000, " +
             "@Descripcion = 'Únete a Kirby en una travesía inolvidable a través de un misterioso mundo en esta encantadora aventura de plataformas en 3D. Toma control de la bola rosada conocida como Kirby y muévete con libertad en escenarios en 3D mientras descubres un misterioso mundo con estructuras abandonadas de una civilización pasada… ¡¿como un centro comercial? Copia las habilidades de los enemigos, tales como Espada y Hielo, y úsalas para atacar y explorar tus alrededores. ¿Qué le espera a Kirby en su travesía? ¡Respira profundamente y prepárate para una aventura inolvidable.';";

            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    for (int i = 0; i < consultas.Length; i++)
                    {
                        using (SqlCommand command = new SqlCommand(consultas[i], conexion))
                        {
                            // Ejecutar la consulta
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Creado exitosamente los datos de las tablas{i}");
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
    }
}

