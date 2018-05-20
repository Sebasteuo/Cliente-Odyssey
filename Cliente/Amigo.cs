using System;
using System.Windows.Forms;

namespace Cliente
{
    /// <summary>
    /// logica del form amigo
    /// </summary>
    public partial class Amigo : Form
    {
        string name = "";
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> nombre de usuario en sesion </param>
        public Amigo(string name)
        {
            this.name = name;
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
        /// Cierra el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Envia la solicitud para agregar un nuevo amigo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (boxNameAmigo.Text.Length != 0)
            {
                string amigo = boxNameAmigo.Text;
                string validacion = Sockets.Conectar(23,name,amigo,"","","","");
                if(validacion.Equals("true")){
                    MessageBox.Show("Se ha agregado el usuario");
                }
                else if(validacion.Equals("ya"))
                {
                    MessageBox.Show("Ya tienes este usuario como amigo");
                }
                else
                {
                    MessageBox.Show("No existe ese usuario");
                }
               
            }
            else
            {
                MessageBox.Show("No se ha escrito un nombre");
            }
        }

        private void Amigo_Load(object sender, EventArgs e)
        {

        }
    }
}
