using System;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Login : Form
    {
        
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

        string name = "";

        private void button1_Click(object sender, EventArgs e)
        {
            name = boxName.Text;
            string contra = boxContra.Text;

            string validacion = Sockets.Conectar(12,name,contra,"","","","") ;
            if (validacion== "false")
            {
                MessageBox.Show("El nombre de usuario o la contraseña es incorrrecta");
            }
            else
            {
                Odyssey odyssey = new Odyssey(name);
                odyssey.Show();
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
