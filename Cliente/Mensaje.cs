using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Mensaje : Form
    {
        string emisor = "";
        string remitente = "";
        public Mensaje(string emisor, string remitente)
        {
            this.emisor = emisor;
            this.remitente = remitente;
            InitializeComponent();
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            label1.Text = "Para " + remitente + " :";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string boolean=Sockets.Conectar(17,emisor,remitente,textBox1.Text,"","","");
            if (boolean.Equals("true"))
            {
                MessageBox.Show("Se ha enviado tu mensaje");
            }
            else
            {
                MessageBox.Show("No tienes esta cancion es tu biblioteca");
            }
        }
    }
}
