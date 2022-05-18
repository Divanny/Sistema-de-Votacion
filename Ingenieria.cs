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
    public partial class Ingenieria : Form
    {
        string Matricula; string Voto_Ingenieria = "";
        public Ingenieria(string vMatricula)
        {
            InitializeComponent();

            #region Asignación de matricula
            Matricula = vMatricula;
            #endregion
            
            #region Inicializar aplicación en fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            #endregion
        }

        private void EleccionesPrimera_KeyDown(object sender, KeyEventArgs e)
        {
            #region Cerrar aplicación con ESC.
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            #endregion
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            #region Cambiar fondo de selección a ROJO.
            //pictureBox4.BackColor = Color.IndianRed;
            //pictureBox6.BackColor = Color.Teal;
            //pictureBox8.BackColor = Color.Teal;
            #endregion
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            #region Cambiar fondo de selección a ROJO.
            //pictureBox4.BackColor = Color.Teal;
            //pictureBox6.BackColor = Color.IndianRed;
            //pictureBox8.BackColor = Color.Teal;
            #endregion
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            #region Cambiar fondo de selección a ROJO.
            //pictureBox4.BackColor = Color.Teal;
            //pictureBox6.BackColor = Color.Teal;
            //pictureBox8.BackColor = Color.IndianRed;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Retroceder de form
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            #region Asignar voto realizado
            if (panel1.BackColor == Color.IndianRed)
            {
                Voto_Ingenieria = "1106045";
            }
            else if (panel2.BackColor == Color.IndianRed)
            {
                Voto_Ingenieria = "1101231";
            }
            else if (panel3.BackColor == Color.IndianRed)
            {
                Voto_Ingenieria = "1102324";
            }
            else if (panel4.BackColor == Color.IndianRed)
            {
                Voto_Ingenieria = "1102534";
            }
            else if (panel5.BackColor == Color.IndianRed)
            {
                Voto_Ingenieria = "1103534";
            }
            #endregion;

            #region Pasar de form
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

        private void label3_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            #region Cambiar color de selección
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.IndianRed;
            panel5.BackColor = Color.White;
            #endregion
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
