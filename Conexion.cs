﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace WindowsFormsApp1
{
     class Conectarse
    {
        
        public Conectarse(string user, string pass)
        {



            string conexionABDD = $"Data Source=DESKTOP-PPMBHAK\\SQLEXPRESS;Initial Catalog=proyectoFinalTBDD;User ID={user};Password={pass};";
            using (SqlConnection conexion = new SqlConnection(conexionABDD))
            {
                try
                {
                    conexion.Open();


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error de inicio de sesión en conexion: "+ex.Message);
                }

                }

            }

        }
    }
