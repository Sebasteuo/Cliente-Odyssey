using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Mensaje : Form
    {
        string emisor = "";
        string remitente = "";
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="emisor"></param>
        /// <param name="remitente"></param>
        public Mensaje(string emisor, string remitente)
        {
            this.emisor = emisor;
            this.remitente = remitente;
            InitializeComponent();
        }

        internal Sockets Sockets
        {
            get => default(Sockets);
            set
            {
            }
        }
        /// <summary>
        /// Modifica el texto del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mensaje_Load(object sender, EventArgs e)
        {
            label1.Text = "Para " + remitente + " :";
        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Verifica que la cancion a enviar exista en la biblioteca del usuario en sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
