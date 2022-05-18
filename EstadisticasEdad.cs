using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Voto___Proyecto_Final
{
    public partial class EstadisticasEdad : Form
    {
        int minimo, maximo;
        public EstadisticasEdad()
        {
            InitializeComponent();

            #region Inicializar aplicación en fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            chart1.Titles.Add("Votos");
            #endregion

            
        }

        #region Conexión Base de Datos
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = Votacion; Uid = root; pwd = 1234;");
            conectar.Open();
            return conectar;
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();

                string Nombre, Apellido; int Cantidad_Votos;
                string[] series = new string[5];
                int[] puntos = new int[5];

                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Ingenieria) from Votos where Voto_Ingenieria = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Ingenieria join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Edad >= {0} and Usuario.Edad <= {1};", minimo, maximo), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                int Length = 0;

                while (reader.Read())
                {
                    Nombre = reader.GetString(0);
                    Apellido = reader.GetString(1);
                    Cantidad_Votos = reader.GetInt32(2);

                    series[Length] = Nombre + " " + Apellido;
                    puntos[Length] = Cantidad_Votos;

                    Length++;
                }
                conexion.Close();

                for (int i = 0; i < Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(series[i], puntos[i]);
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar datos");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            minimo = 29;
            maximo = 38;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            minimo = 39;
            maximo = 48;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            minimo = 49;
            maximo = 58;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            minimo = 59;
            maximo = 9999;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();

                string Nombre, Apellido; int Cantidad_Votos;
                string[] series = new string[5];
                int[] puntos = new int[5];

                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Ciencias_Basicas_Ambientales) from Votos where Voto_Ciencias_Basicas_Ambientales = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Ciencias_Basicas_Ambientales join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Edad >= {0} and Usuario.Edad <= {1};", minimo, maximo), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                int Length = 0;

                while (reader.Read())
                {
                    Nombre = reader.GetString(0);
                    Apellido = reader.GetString(1);
                    Cantidad_Votos = reader.GetInt32(2);

                    series[Length] = Nombre + " " + Apellido;
                    puntos[Length] = Cantidad_Votos;

                    Length++;
                }
                conexion.Close();

                for (int i = 0; i < Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(series[i], puntos[i]);
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();

                string Nombre, Apellido; int Cantidad_Votos;
                string[] series = new string[5];
                int[] puntos = new int[5];

                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Ciencias_Salud) from Votos where Voto_Ciencias_Salud = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Ciencias_Salud join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Edad >= {0} and Usuario.Edad <= {1};", minimo, maximo), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                int Length = 0;

                while (reader.Read())
                {
                    Nombre = reader.GetString(0);
                    Apellido = reader.GetString(1);
                    Cantidad_Votos = reader.GetInt32(2);

                    series[Length] = Nombre + " " + Apellido;
                    puntos[Length] = Cantidad_Votos;

                    Length++;
                }
                conexion.Close();

                for (int i = 0; i < Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(series[i], puntos[i]);
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar datos");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();

                string Nombre, Apellido; int Cantidad_Votos;
                string[] series = new string[5];
                int[] puntos = new int[5];

                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Ciencias_Sociales_Humanidades) from Votos where Voto_Ciencias_Sociales_Humanidades = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Ciencias_Sociales_Humanidades join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Edad >= {0} and Usuario.Edad <= {1};", minimo, maximo), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                int Length = 0;

                while (reader.Read())
                {
                    Nombre = reader.GetString(0);
                    Apellido = reader.GetString(1);
                    Cantidad_Votos = reader.GetInt32(2);

                    series[Length] = Nombre + " " + Apellido;
                    puntos[Length] = Cantidad_Votos;

                    Length++;
                }
                conexion.Close();

                for (int i = 0; i < Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(series[i], puntos[i]);
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar datos");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();

                string Nombre, Apellido; int Cantidad_Votos;
                string[] series = new string[5];
                int[] puntos = new int[5];

                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Candidatos.Nombre), Candidatos.Apellido, (select count(Voto_Economia) from Votos where Voto_Economia = Candidatos.Matricula) from Candidatos join Votos on Candidatos.Matricula = Votos.Voto_Economia join Usuario on Votos.Matricula = Usuario.Matricula where Usuario.Edad >= {0} and Usuario.Edad <= {1};", minimo, maximo), conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                int Length = 0;

                while (reader.Read())
                {
                    Nombre = reader.GetString(0);
                    Apellido = reader.GetString(1);
                    Cantidad_Votos = reader.GetInt32(2);

                    series[Length] = Nombre + " " + Apellido;
                    puntos[Length] = Cantidad_Votos;

                    Length++;
                }
                conexion.Close();

                for (int i = 0; i < Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(series[i], puntos[i]);
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Retroceder de form
            Administrador inicio = new Administrador();
            inicio.Show();
            this.Hide();
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Reiniciar form
            EstadisticasEdad ventana = new EstadisticasEdad();
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void button8_Click(object sender, EventArgs e)
        {
            minimo = 18;
            maximo = 28;
        }
    }
}
