using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        string name = "";

        private void button1_Click(object sender, EventArgs e)
        {
            name = boxName.Text;
            string contra = boxContra.Text;

            string validacion = Sockets.Conectar(2,name,contra,"","","","") ;
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
    }
}
