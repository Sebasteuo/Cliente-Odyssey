using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (boxNick.TextLength > 0)
            {
                if (boxName.TextLength > 0)
                {
                    if (boxEdad.TextLength > 0) // validar que es numero
                    {
                        if (boxContra.TextLength > 0)
                        {
                            string genero = "";
                            foreach (string s in boxGenero.CheckedItems)
                            {
                                genero = genero + s + ",";
                            }
                            string nick = boxNick.Text;
                            string name = boxName.Text;
                            string edad = boxEdad.Text;
                            string contra = boxContra.Text;
                            string amigos = boxAmigos.Text;
                            string resultado = Sockets.Conectar(1, nick, name, edad, genero, contra, amigos);

                            if (resultado == "true")
                            {
                                MessageBox.Show("Se ha creado el nuevo usuario");
                                Login login = new Login();
                                login.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("El Apodo ya esta en uso");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se debe escribir una Contraseña");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se debe escribir una edad");
                    }
                }
                else
                {
                    MessageBox.Show("Se debe escribir un Nombre");
                }
            }
            else
            {
                MessageBox.Show("Se debe escribir un Apodo");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
