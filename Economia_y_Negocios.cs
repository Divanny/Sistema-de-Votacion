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
    public partial class Economia_y_Negocios : Form
    {

        string Matricula; string Voto_Ingenieria; string Voto_Ciencias_Basicas_Ambientales; string Voto_Ciencias_Salud; string Voto_Ciencias_Sociales_Humanidades; string Voto_Economia = "";
        public Economia_y_Negocios(string vMatricula, string _Voto_Ingenieria, string _Voto_Ciencias_Basicas_Ambientales, string _Voto_Ciencias_Salud, string _Voto_Ciencias_Sociales_Humanidades)
        {
            InitializeComponent();

            #region Asignación de anteriores votos realizados
            Matricula = vMatricula;
            Voto_Ingenieria = _Voto_Ingenieria;
            Voto_Ciencias_Basicas_Ambientales = _Voto_Ciencias_Basicas_Ambientales;
            Voto_Ciencias_Salud = _Voto_Ciencias_Salud;
            Voto_Ciencias_Sociales_Humanidades = _Voto_Ciencias_Sociales_Humanidades;
            #endregion

            #region Inicializar aplicación en fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
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
            #region Asignar voto realizado
            if (panel1.BackColor == Color.IndianRed)
            {
                Voto_Economia = "1107421";
            }
            else if (panel2.BackColor == Color.IndianRed)
            {
                Voto_Economia = "1106345";
            }
            else if (panel3.BackColor == Color.IndianRed)
            {
                Voto_Economia = "1108343";
            }
            else if (panel4.BackColor == Color.IndianRed)
            {
                Voto_Economia = "1101234";
            }
            else if (panel5.BackColor == Color.IndianRed)
            {
                Voto_Economia = "1105724";
            }
            else if (panel6.BackColor == Color.IndianRed)
            {
                Voto_Economia = "1104345";
            }
            #endregion;

            #region Almacenamiento de voto
            try
            {
                MySqlConnection conexion = ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("insert into Votos(Matricula, Voto_Ingenieria, Voto_Ciencias_Basicas_Ambientales, Voto_Ciencias_Salud, Voto_Ciencias_Sociales_Humanidades, Voto_Economia) values ({0}, {1}, {2}, {3}, {4}, {5});", int.Parse(Matricula), int.Parse(Voto_Ingenieria), int.Parse(Voto_Ciencias_Basicas_Ambientales), int.Parse(Voto_Ciencias_Salud), int.Parse(Voto_Ciencias_Sociales_Humanidades), int.Parse(Voto_Economia)), conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Voto registrado correctamente.");

            }
            catch
            {
                MessageBox.Show("Error");
            }
            #endregion

            #region Volver al inicio
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Retroceder de form
            Ciencias_Sociales_y_Humanidades ventana = new Ciencias_Sociales_y_Humanidades(Matricula, Voto_Ingenieria, Voto_Ciencias_Basicas_Ambientales, Voto_Ciencias_Salud);
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.IndianRed;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            #endregion
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.IndianRed;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            #endregion
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.IndianRed;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            #endregion
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.IndianRed;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            #endregion
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.IndianRed;
            #endregion
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.IndianRed;
            panel6.BackColor = Color.White;
            #endregion
        }

        private void Economia_y_Negocios_Load(object sender, EventArgs e)
        {

        }
    }
}
