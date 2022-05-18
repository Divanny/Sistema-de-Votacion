using MySql.Data.MySqlClient;

namespace Sistema_de_Voto___Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region Cerrar aplicación con ESC.
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Comprobación de 7 dígitos de matrícula
            if (textBox1.Text.Length == 7)
            {
                // Comprobación de cédula ADMIN (1111111)
                if (textBox1.Text == "1111111")
                {
                    label2.Text = "ADMINISTRADOR";
                }
                // Cambio de datos a los del usuario
                else
                {
                    // MYSQL
                    try
                    {
                        string Imagen = ""; string Nombre = ""; string Apellido = "";
                        MySqlConnection conexion = ObtenerConexion();
                        MySqlCommand comando = new MySqlCommand(String.Format("select Nombre, Apellido, Foto from usuario where Matricula = {0}", textBox1.Text), conexion);
                        MySqlDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            Nombre = reader.GetString(0);
                            Apellido = reader.GetString(1); 
                            Imagen = reader.GetString(2);
                        }
                        conexion.Close();
                        
                        pictureBox3.Image = System.Drawing.Image.FromFile(Imagen);
                        label2.Text = Nombre + " " + Apellido;
                    }
                    catch
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }   
                }
                label1.Text = "CONFIRME SUS DATOS";
                textBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                // Reinicio de campos
                textBox1.Text = "";
                label1.Text = "EN ESPERA DE ELECTOR";
                pictureBox3.Image = System.Drawing.Image.FromFile("D:/Descargas/Proyecto/User-Profile-PNG.png");
                label2.Text = "NOMBRE DEL ELECTOR";
                textBox1.Enabled = true;
            }
            else
            {
                // Cerrar programa
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cambio de form
            if (textBox1.Text == "1111111")
            {
                Administrador ventana = new Administrador();
                ventana.Show();
                this.Hide();
            }
            else if (textBox1.Text.Length == 7)
            {
                Ingenieria ventana = new Ingenieria(textBox1.Text);
                ventana.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}