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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            #region Inicializar aplicación en fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            #endregion
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Retroceder de form
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
            #endregion
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            #region Pasar de form
            EstadisticasCantidad ventana = new EstadisticasCantidad();
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            #region Pasar de form
            EstadisticasPorcentuales ventana = new EstadisticasPorcentuales();
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            #region Pasar de form
            EstadisticasGenero ventana = new EstadisticasGenero();
            ventana.Show();
            this.Hide();
            #endregion
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            #region Pasar de form
            EstadisticasEdad ventana = new EstadisticasEdad();
            ventana.Show();
            this.Hide();
            #endregion
        }
    }
}
