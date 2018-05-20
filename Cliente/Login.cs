using System;
using System.Windows.Forms;

namespace Cliente
{
    /// <summary>
    /// Logica del form login
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        internal Sockets Sockets
        {
            get => default(Sockets);
            set
            {
            }
        }

        internal Properties.Settings Settings
        {
            get => default(Properties.Settings);
            set
            {
            }
        }

        public Odyssey Odyssey
        {
            get => default(Odyssey);
            set
            {
            }
        }

        internal Sockets Sockets1
        {
            get => default(Sockets);
            set
            {
            }
        }

        public Usuario Usuario
        {
            get => default(Usuario);
            set
            {
            }
        }

        string name = "";
        /// <summary>
        /// Valida el inicio de sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            name = boxName.Text;
            string contra = boxContra.Text;

            string validacion = Sockets.Conectar(12,name,contra,"","","","") ;
            if (validacion== "false")
            {
                Sockets.Conectar(33, "", "", "", "", "", "");
                MessageBox.Show("El nombre de usuario o la contraseña es incorrrecta");
            }
            else
            {
                Odyssey odyssey = new Odyssey(name);
                odyssey.Show();
                this.Close();
            }
        }
        /// <summary>
        /// Codifica el campo de texto de la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            boxContra.PasswordChar = '•';
            boxContra.CharacterCasing = CharacterCasing.Lower;
        }
        /// <summary>
        /// Cierra el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Envia al form de creacion de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
