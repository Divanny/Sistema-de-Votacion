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
    public partial class Ciencias_de_la_Salud : Form
    {
        string Matricula; string Voto_Ingenieria; string Voto_Ciencias_Basicas_Ambientales; string Voto_Ciencias_Salud = "";
        public Ciencias_de_la_Salud(string vMatricula, string _Voto_Ingenieria, string _Voto_Ciencias_Basicas_Ambientales)
        {
            InitializeComponent();

            #region Asignación de anteriores votos realizados
            Matricula = vMatricula;
            Voto_Ingenieria = _Voto_Ingenieria;
            Voto_Ciencias_Basicas_Ambientales = _Voto_Ciencias_Basicas_Ambientales;
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
                Voto_Ciencias_Salud = "1107567";
            }
            else if (panel2.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Salud = "1107432";
            }
            else if (panel3.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Salud = "1102363";
            }
            else if (panel4.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Salud = "1107345";
            }
            else if (panel5.BackColor == Color.IndianRed)
            {
                Voto_Ciencias_Salud = "1106234";
            }
            #endregion;

            #region Pasar de form
            Ciencias_Sociales_y_Humanidades ventana = new Ciencias_Sociales_y_Humanidades(Matricula, Voto_Ingenieria, Voto_Ciencias_Basicas_Ambientales, Voto_Ciencias_Salud);
            ventana.Show();
            this.Hide();
            #endregion  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Retroceder de form
            Ciencias_Basicas_y_Ambientales ventana = new Ciencias_Basicas_y_Ambientales(Matricula, Voto_Ingenieria);
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
            #endregion
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.IndianRed;
            panel5.BackColor = Color.White;
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
            #endregion
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
