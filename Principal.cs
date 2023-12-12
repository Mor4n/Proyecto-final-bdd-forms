using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        bool expansionMenu = true;
        string c = $"Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=proyectoFinaltbdd;User ID=sa;Password=;";
        public string cUser = "";
        public string cPassword = "";

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


            conexionABDD = $"Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=proyectoFinaltbdd;User ID={cUser};Password={cPassword};";

            int admin = 0;
            using (SqlConnection conexion = new SqlConnection(c))
            {
                try
                {
                    conexion.Open();
                    string consulta = $"SELECT Rol FROM proyecto.Usuario where Nombre_Usuario='{cUser}' ";
                    SqlCommand command = new SqlCommand(consulta, conexion);
                    var esAdmin = command.ExecuteScalar();
                    admin = Convert.ToInt32(esAdmin);
                    if (admin == 0)
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
                if (menu.Width == menu.MinimumSize.Width)
                {
                    expansionMenu = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                menu.Width += 10;
                if (menu.Width == menu.MaximumSize.Width)
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
        public void hacerVisible(int valor)
        {
            switch (valor)
            {
                case 0:
                    dataJuegos.Visible = true;

                    dataJuegos.Location = new System.Drawing.Point(298, 46);
                    dataJuegos.Size = new Size(376, 358);
                    lblNombreJuego.Visible = true;
                    pbImagenJuego.Visible = true;
                    lblDescripcion.Visible = true;
                    lblPrecio.Visible = true;
                    lblDinero.Visible = true;
                    btnComprar.Text = "Comprar";
                    btnComprar.Visible = true;
                    break;
                case 1:
                    dataJuegos.Visible = true;

                    dataJuegos.Location = new System.Drawing.Point(298, 46);
                    dataJuegos.Size = new Size(376, 358);
                    lblNombreJuego.Visible = true;
                    pbImagenJuego.Visible = true;
                    lblDescripcion.Visible = true;
                    btnComprar.Text = "Jugar";
                    btnComprar.Visible = true;
                    break;
                case 2:
                    dataJuegos.Visible = true;

                    dataJuegos.Location = new System.Drawing.Point(298, 46);
                    dataJuegos.Size = new Size(376, 358);
                    btnComprar.Visible = true;
                    btnComprar.Text = "Realizar operación";
                    lblAdNombre.Visible = true;
                    lblAdPortada.Visible = true;
                    lblAdDescripcion.Visible = true;
                    lblAdPrecio.Visible = true;
                    txtNombre.Visible = true;
                    txtPortada.Visible = true;
                    txtDescripcion.Visible = true;
                    txtPrecio.Visible = true;
                    groupBox1.Visible = true;
                    lblIdJuego.Visible = true;
                    txtId.Visible = true;




                    break;
                case 3:

                    dataJuegos.Visible = true;
                    dataJuegos.Location = new System.Drawing.Point(206, 3);
                    dataJuegos.Size = new Size(707, 445);
                    break;
                case 4:
                    break;

            }
        }
        public void ocultar()
        {
            //Tienda
            dataJuegos.Visible = false;
            dataJuegos.DataSource= null;
            lblNombreJuego.Visible = false;
            pbImagenJuego.Visible = false;
            lblDescripcion.Visible = false;
            lblPrecio.Visible = false;
            lblDinero.Visible = false;
            btnComprar.Visible = false;
            //Administrar
            btnComprar.Visible = false;
            lblAdNombre.Visible = false;
            lblAdPortada.Visible = false;
            lblAdDescripcion.Visible = false;
            lblAdPrecio.Visible = false;
            txtNombre.Visible = false;
            txtPortada.Visible = false;
            txtDescripcion.Visible = false;
            txtPrecio.Visible = false;
            groupBox1.Visible = false;
            lblIdJuego.Visible = false;
            txtId.Visible= false;


        }
        int botonElegido;
        private void btnTienda_Click(object sender, EventArgs e)
        {
            ocultar();
            hacerVisible(0);
            actualizarDinero();
            botonElegido = 0;
            using (SqlConnection conexion = new SqlConnection(conexionABDD))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT nombre as 'Nombre del videojuego' FROM proyecto.Tienda ", conexion);
                    DataTable dtbl = new DataTable();

                    sqlDA.Fill(dtbl);

                    dataJuegos.DataSource = dtbl;




                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error de inicio de sesión: " + ex.Message);
                }

            }


        }

        private void dataJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataJuegos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (botonElegido)
            {
                case 0:
                    darClickLlenar("Tienda");
                    break;
                case 1:
                    darClickLlenar("Libreria");
                    break;
                case 2:

                    darClickLlenar("Tienda");
                    break;
            }
           

        }
        public void darClickLlenar(string tabla)
        {
            string nombre = lblNombreJuego.Text = dataJuegos.CurrentRow.Cells[0].Value.ToString();

            SqlConnection conexion = new SqlConnection(conexionABDD);
            

                string[] consultas = new string[4];
                string[] datos = new string[4];



                consultas[0] = $"SELECT Portada  FROM proyecto.{tabla} where nombre = '{nombre}'";
                consultas[1] = $"SELECT precio  FROM proyecto.{tabla} where nombre = '{nombre}'";
                consultas[2] = $"SELECT descripcion  FROM proyecto.{tabla} where nombre = '{nombre}'";
                consultas[3] = $"SELECT Idjuego  FROM proyecto.{tabla} where nombre = '{nombre}'";

                conexion.Open();
                DataTable dtbl = new DataTable();

                for (int i = 0; i < consultas.Length; i++)
                {

                    SqlCommand sqlDA = new SqlCommand(consultas[i], conexion);
                    var resultado = sqlDA.ExecuteScalar();
                    datos[i] = Convert.ToString(resultado);
                }
                if (botonElegido != 2)
            {
                    lblNombreJuego.Text = nombre;
                    pbImagenJuego.Load($"{datos[0]}");
                    lblPrecio.Text = datos[1];
                    lblDescripcion.Text = datos[2];
            }
            else
            {
                txtId.Text = datos[3].ToString();
                txtNombre.Text = nombre;
                txtPortada.Text=datos[0].ToString();
                txtPrecio.Text = datos[1].ToString();
                txtDescripcion.Text = datos[2].ToString();
            }

        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            switch (botonElegido)
            {
                case 0:

                    //Seleccionar id del juego cuyo nombre sea
                    string[] consultas = new string[4];
                    string nombre = lblNombreJuego.Text = dataJuegos.CurrentRow.Cells[0].Value.ToString();
                    consultas[0] = $"SELECT IdJuego  FROM proyecto.Tienda where nombre = '{nombre}'";
                    consultas[1] = $"SELECT dinero from proyecto.Usuario where Nombre_Usuario ='{cUser}'";
                    consultas[2] = $"SELECT precio from proyecto.Tienda where nombre ='{nombre}'";
                    consultas[3] = $"Select IdUsuario from proyecto.usuario where Nombre_usuario='{cUser}'";



                    string[] resultados = new string[4];
                    double dineroUser = 0;
                    double costoJuego = 0;

                    SqlConnection conexion = new SqlConnection(conexionABDD);
                    try
                    {
                        conexion.Open();

                        for (int i = 0; i < consultas.Length; i++)
                        {

                            SqlCommand sqlDA = new SqlCommand(consultas[i], conexion);
                            var resultado = sqlDA.ExecuteScalar();
                            resultados[i] = Convert.ToString(resultado);

                        }

                        dineroUser = Convert.ToDouble(resultados[1]);
                        costoJuego = Convert.ToDouble(resultados[2]);
                        string idjuego = resultados[0].ToString();
                        string iduser = resultados[3].ToString();
                        MessageBox.Show($"{dineroUser} {costoJuego}");

                        if (dineroUser < costoJuego)
                        {
                            MessageBox.Show($"No se puede hacer la compra, no cuentas con los fondos suficientes, tienes {resultados[1]}");
                        }
                        else
                        {
                            double resta = dineroUser - costoJuego;

                            var opcion = MessageBox.Show($"Tienes {dineroUser} pesos, te quedarían" +
                                $"  {resta} ", "Aviso", MessageBoxButtons.YesNo);
                            if (opcion == DialogResult.Yes)
                            {

                                procedimientosAlmacenadosJuegos();
                                procedimientosAlmacenadosTienda();
                                //Crear procedimiento para insert para el juego añadido a su biblioteca
                                //Crear procedimiento update para el dinero retirado de su cuenta

                                //Ejecutar el procedimiento almacenado para añadir el juego a la biblioteca


                                string[] compra = new string[2];

                                compra[0] = "exec proyecto.proce_CompraJuego " +
                                    $"@IdUsuario ={iduser}," +
                                    $"@idjuego={idjuego}";
                                compra[1] = "exec proyecto.proce_RestarDinero " +
                                    $"@IdUsuario ={iduser}," +
                                    $"@Dinero={resta}";

                                for (int i = 0; i < compra.Length; i++)
                                {
                                    using (SqlCommand command = new SqlCommand(compra[i], conexion))
                                    {
                                        // Ejecutar la consulta
                                        command.ExecuteNonQuery();
                                        //   MessageBox.Show($"Creado exitosamente los datos de las tablas{i}");

                                    }
                                }
                                MessageBox.Show("Felicidades por su nueva compra");
                                actualizarDinero();
                            }


                        }



                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de inicio de sesión: " + ex.Message);
                    }
                    break;

                case 1:
                    MessageBox.Show("El juego iniciará pronto");
                    break;
                case 2:
                    string consulta="";
                    //Aqui va el de añadir
                    if (rbAdd.Checked)
                    {
                         consulta = "exec proyecto.proce_BaseTienda " +
                $"@IdJuego ={txtId.Text} , " +
                $"@Portada = '{txtPortada.Text}'," +
                $"@Nombre = '{txtNombre.Text}', " +
                $"@Precio = {txtPrecio.Text}, " +
                $"@Descripcion = '{txtDescripcion.Text}';";


                    }
                   else if (rbEliminar.Checked)
                    {
                     var op=   MessageBox.Show($"Seguro que deseas eliminar el juego con el id ={txtId.Text}","Advertencia",MessageBoxButtons.YesNo);
                        if (op==DialogResult.Yes)
                        {
                            consulta = "exec proyecto.proce_EliminarJuego " +
                              $"@IdJuego ={txtId.Text} ;";
                        }
                        


                    }
                    else if (rbModificar.Checked)
                    {
                        consulta = "exec proyecto.proce_ActualizarJuego " +
                               $"@IdJuego ={txtId.Text} , " +
                               $"@Portada = '{txtPortada.Text}'," +
                               $"@Nombre = '{txtNombre.Text}', " +
                               $"@Precio = {txtPrecio.Text}, " +
                              $"@Descripcion = '{txtDescripcion.Text}';";

                    }
                    else
                    {
                        MessageBox.Show("Elija un botón");
                    }
                    MessageBox.Show(consulta);
                    using (SqlConnection con = new SqlConnection(conexionABDD))
                    {
                        
                            con.Open();
                                using (SqlCommand command = new SqlCommand(consulta, con))
                                {
                                    // Ejecutar la consulta
                                    command.ExecuteNonQuery();
                                //   MessageBox.Show($"Creado exitosamente los datos de las tablas{i}");

                                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT nombre as 'Nombre del videojuego' FROM proyecto.Tienda ", con);
                                DataTable dtbl = new DataTable();

                                sqlDA.Fill(dtbl);

                                dataJuegos.DataSource = dtbl;
                            }
                            



                    }

                    break;
            }

        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            ocultar();
            hacerVisible(1);
            botonElegido=1;
            using (SqlConnection conexion = new SqlConnection(conexionABDD))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("select ti.Nombre" +
                        " FROM proyecto.Libreria li " +
                        "JOIN proyecto.Usuario us ON li.IdUsuario = us.IdUsuario " +
                        "JOIN proyecto.Tienda ti ON li.IdJuego = ti.IdJuego " +
                        $"where us.Nombre_Usuario='{cUser}' ", conexion);
                    DataTable dtbl = new DataTable();

                    sqlDA.Fill(dtbl);

                    dataJuegos.DataSource = dtbl;




                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error de inicio de sesión: " + ex.Message);
                }

            }




        }

        public void btnAdministrar_Click(object sender, EventArgs e)
        {
            ocultar();
            hacerVisible(2);
            

            botonElegido = 2;
            using (SqlConnection conexion = new SqlConnection(conexionABDD))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT nombre as 'Nombre del videojuego' FROM proyecto.Tienda ", conexion);
                    DataTable dtbl = new DataTable();

                    sqlDA.Fill(dtbl);

                    dataJuegos.DataSource = dtbl;




                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error de inicio de sesión: " + ex.Message);
                }

            }



        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            ocultar();
            hacerVisible(3);
            botonElegido = 3;
            using (SqlConnection conexion = new SqlConnection(c))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_evento as 'Id evento'," +
                        "tipo_evento as 'Tipo evento',fecha as 'Fecha', descripcion as 'Descripción'" +
                        ", usuario as 'Usuario', terminal as 'Terminal'," +
                        "aplicacion as 'Aplicación' FROM proyecto.Auditoria ", conexion);
                    DataTable dtbl = new DataTable();

                    sqlDA.Fill(dtbl);

                    dataJuegos.DataSource = dtbl;


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error de inicio de sesión: " + ex.Message);
                }

            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ocultar();
            hacerVisible(4);
            botonElegido = 4;

        }


        public void procedimientosAlmacenadosTienda()
        {
            string[] procedimientos = new string[2];
            procedimientos[0] = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('proyecto.proce_CompraJuego'))" +
                "BEGIN " +
                "EXEC('" +
                "CREATE PROCEDURE proyecto.proce_CompraJuego(" +
                "@IdUsuario INT," +
                "@IdJuego INT)  " +
                "AS  " +
                "BEGIN         " +
                "INSERT INTO proyecto.Libreria  (" +
                "IdUsuario," +
                "IdJuego) " +
                "VALUES ( " +
                "@IdUsuario," +
                "@IdJuego)" +
                "END')" +
                "END;";

            procedimientos[1] = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('proyecto.proce_RestarDinero'))" +
                "BEGIN " +
                "EXEC('" +
                "CREATE PROCEDURE proyecto.proce_RestarDinero(" +
                "@IdUsuario INT," +
                "@Dinero MONEY ) " +
                "AS  " +
                "BEGIN         " +
                "UPDATE proyecto.Usuario SET Dinero=@Dinero WHERE IdUsuario=@IdUsuario " +
                "END')" +
                "END;";
            SqlConnection conexion = new SqlConnection(c);
            try
            {
                conexion.Open();
                for (int i = 0; i < procedimientos.Length; i++)
                {
                    using (SqlCommand command = new SqlCommand(procedimientos[i], conexion))
                    {
                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                        //   MessageBox.Show($"Creado exitosamente los datos de las tablas{i}");
                    }
                }




            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de inicio de sesión: " + ex.Message);
            }

            conexion.Close();


        }

        public void procedimientosAlmacenadosJuegos()
        {

            string[] procedimientos = new string[2];
            procedimientos[0] = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('proyecto.proce_EliminarJuego'))" +
                                "BEGIN " +
                                "EXEC('" +
                                "CREATE PROCEDURE proyecto.proce_EliminarJuego(" +
                                "@IdJuego INT)  " +
                                "AS  " +
                                "BEGIN         " +
                                "Delete FROM proyecto.Tienda  " +
                                "WHERE " +
                                "IdJuego = @IdJuego " +
                                "END')" +
                                "END;";
            procedimientos[1] = "IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('proyecto.proce_ActualizarJuego'))" +
                                "BEGIN " +
                                "EXEC('" +
                                "CREATE PROCEDURE proyecto.proce_ActualizarJuego(" +
                                 "@IdJuego INT,         " +
                                "@Portada VARCHAR(2083),         " +
                                "@Nombre VARCHAR(50),         " +
                                "@Precio MONEY,        " +
                                "@Descripcion VARCHAR(200)) " +
                                "AS  " +
                                "BEGIN         " +
                                "UPDATE proyecto.Tienda SET Portada=@Portada, Nombre=@Nombre, Precio=@Precio, Descripcion=@Descripcion " +
                                "WHERE " +
                                "IdJuego = @IdJuego " +
                                "END')" +
                                "END;";


            SqlConnection conexion = new SqlConnection(c);
            try
            {
                conexion.Open();
                for (int i = 0; i < procedimientos.Length; i++)
                {
                    using (SqlCommand command = new SqlCommand(procedimientos[i], conexion))
                    {
                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                        //   MessageBox.Show($"Creado exitosamente los datos de las tablas{i}");
                    }
                }




            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de inicio de sesión: " + ex.Message);
            }
            conexion.Close();
        }

        public void actualizarDinero()
        {
            SqlConnection conexion = new SqlConnection(conexionABDD);

            conexion.Open();
            string consulta = $"SELECT Dinero from proyecto.Usuario where Nombre_Usuario='{cUser}'";
            using (SqlCommand command = new SqlCommand(consulta, conexion))
            {
                var resultado = command.ExecuteScalar();
                lblDinero.Text = Convert.ToString(resultado);
            }




        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }
    }

}
