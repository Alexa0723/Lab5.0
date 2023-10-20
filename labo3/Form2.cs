using System;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form2 : Form
    {
        public Jugador[] jugadores;
        private int indice = 0;
        int cantidadDeJugadores = 10;
        DateTime fechaInicio = new DateTime(2023, 10, 1);
        DateTime fechaFin = new DateTime(2023, 10, 31);
        int numeroDeEndulzadas = 5;
        int frecuenciaDeEndulzadasEnDias = 7;
        float valorDeLaEndulzada = 2.5f;
        float valorDelRegalo = 30.0f;
        public Form Form3Instance { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int cantidadJugadores)
        {
            InitializeComponent();
            jugadores = new Jugador[cantidadJugadores];
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            if (indice >= jugadores.Length)
            {
                MessageBox.Show("Has alcanzado el número máximo de jugadores.");
                return;
            }

            string nombre = nombreTextBox.Text;
            string correo = emailTextBox.Text;
            string endulzadaIdeal = dulcesFavoritosTextBox.Text;
            string regaloIdeal = regaloIdealTextBox.Text;

            // Crear una instancia de Jugador y agregarlo a la lista
            Jugador nuevoJugador = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal);
            jugadores[indice] = nuevoJugador;
            indice++;

            // Limpiar los TextBoxes para el siguiente jugador
            nombreTextBox.Clear();
            emailTextBox.Clear();
            dulcesFavoritosTextBox.Clear();
            regaloIdealTextBox.Clear();

            MessageBox.Show("Jugador guardado correctamente.");
        }

        private void LimpiarCampos()
        {
            nombreTextBox.Text = "";
            emailTextBox.Text = "";
            dulcesFavoritosTextBox.Text = "";
            regaloIdealTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }
}