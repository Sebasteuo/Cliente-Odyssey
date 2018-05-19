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

        public Login Login
        {
            get => default(Login);
            set
            {
            }
        }

        internal Sockets Sockets
        {
            get => default(Sockets);
            set
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxNick.TextLength > 0)
            {
                if (boxName.TextLength > 0)
                {
                    if (boxEdad.TextLength > 0)
                    {
                        try
                        {
                            Int32.Parse(boxEdad.Text);
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
                                string amigos = "";
                                foreach (string s in box.CheckedItems)
                                {
                                    amigos = amigos + s + ",";
                                }
                                string resultado = Sockets.Conectar(10, nick, name, edad, genero, contra, amigos);

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
                        catch {
                            MessageBox.Show("La edad ingresada debe ser un numero");
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
            string nombre = Sockets.Conectar(00, "", "", "", "", "", "");
            string[] gen = new string[10];
            int z = 0;
            int j = 0;
            int n = 1;
            for (int c = 0; nombre.Length > c; c++)
            {
                if (nombre.Substring(c, 1) == "/")
                {
                    gen[z] = nombre.Substring(j, n - 1);
                    Console.WriteLine(gen[z]);
                    z++;
                    j = c + 1;
                    n = 0;
                }
                n++;
            }
            foreach (string usuario in gen)
            {
                if (usuario != null)
                {
                    box.Items.Add(usuario);
                }
            }
        }
    }
}
