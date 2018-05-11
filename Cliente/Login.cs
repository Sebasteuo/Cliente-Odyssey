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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = boxName.Text;
            string contra = boxContra.Text;

            Boolean validacion = true;
            if (!validacion)
            {
                MessageBox.Show("El nombre de usuario o la contraseña es incorrrecta");
            }
            else
            {
                Odyssey odyssey = new Odyssey();
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
