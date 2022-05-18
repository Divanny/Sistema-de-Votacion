using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Voto___Proyecto_Final
{
    public partial class Ciencias_Sociales_y_Humanidades : Form
    {
        string Matricula; string Voto_Ingenieria; string Voto_Ciencias_Basicas_Ambientales; string Voto_Ciencias_Salud; string Voto_Ciencias_Sociales_Humanidades = "";

        public Ciencias_Sociales_y_Humanidades(string vMatricula, string _Voto_Ingenieria, string _Voto_Ciencias_Basicas_Ambientales, string _Voto_Ciencias_Salud)
        {
            InitializeComponent();

            #region Asignación de anteriores votos realizados
            Matricula = vMatricula;
            Voto_Ingenieria = _Voto_Ingenieria;
            Voto_Ciencias_Basicas_Ambientales = _Voto_Ciencias_Basicas_Ambientales;
            Voto_Ciencias_Salud = _Voto_Ciencias_Salud;
            #endregion

            #region Inicializar aplicación en fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Asignar voto realizado
            if (panel1.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Sociales_Humanidades = "1108344";
            }
            else if (panel2.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Sociales_Humanidades = "1101223";
            }
            else if (panel3.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Sociales_Humanidades = "1104653";
            }
            #endregion;

            #region Pasar de form
            Economia_y_Negocios ventana = new Economia_y_Negocios(Matricula, Voto_Ingenieria, Voto_Ciencias_Basicas_Ambientales, Voto_Ciencias_Salud, Voto_Ciencias_Sociales_Humanidades);
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Retroceder de form
            Ciencias_de_la_Salud ventana = new Ciencias_de_la_Salud(Matricula, Voto_Ingenieria, Voto_Ciencias_Basicas_Ambientales);
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.IndianRed;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;

            #endregion
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.IndianRed;
            panel3.BackColor = Color.White;

            #endregion
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.IndianRed;
            #endregion
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            #endregion
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            #endregion
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            #endregion
        }
    }
}
