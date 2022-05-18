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
using System.Windows.Forms.DataVisualization.Charting;


namespace Sistema_de_Voto___Proyecto_Final
{
    public partial class EstadisticasPorcentuales : Form
    {
        public EstadisticasPorcentuales()
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
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Nombre), Apellido, (select count(Voto_Ingenieria) from Votos where Voto_Ingenieria = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ingenieria;"), conexion);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();

                string Nombre, Apellido; int Cantidad_Votos;
                string[] series = new string[5];
                int[] puntos = new int[5];

                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Nombre), Apellido, (select count(Voto_Ciencias_Basicas_Ambientales) from Votos where Voto_Ciencias_Basicas_Ambientales = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ciencias_Basicas_Ambientales;"), conexion);
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
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Nombre), Apellido, (select count(Voto_Ciencias_Salud) from Votos where Voto_Ciencias_Salud = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ciencias_Salud;"), conexion);
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
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Nombre), Apellido, (select count(Voto_Ciencias_Sociales_Humanidades) from Votos where Voto_Ciencias_Sociales_Humanidades = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Ciencias_Sociales_Humanidades;"), conexion);
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
                MySqlCommand comando = new MySqlCommand(String.Format("select distinct(Nombre), Apellido, (select count(Voto_Economia) from Votos where Voto_Economia = Candidatos.Matricula) from Candidatos join Votos where Candidatos.Matricula = Votos.Voto_Economia;"), conexion);
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
            Administrador administrador = new Administrador();
            administrador.Show();
            this.Hide();
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Pasar de form
            EstadisticasPorcentuales ventana = new EstadisticasPorcentuales();
            ventana.Show();
            this.Hide();
            #endregion
        }
    }
}
