using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Odyssey : Form
    {
        string name = "";
        static int tipo = 0;
        public static int GetTipo()
        {
            return tipo;
        }

        public Odyssey(string ob)
        {
            this.name = ob;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Odyssey_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Amigo amigo = new Amigo();
            amigo.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
            general.Show();
            tipo = 1;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
            general.Show();
            tipo = 2;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
            general.Show();
            tipo = 3;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
            general.Show();
            tipo = 4;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.balance = trackBar3.Value;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = (string) Biblioteca.SelectedItem;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string track in openFileDialog1.FileNames){
                string validacion = "true";
                if (validacion == "true")
                {
                    Biblioteca.Items.Add(track);
                    MessageBox.Show("Se ha agregado la nueva cancion");
                }
                else if (validacion == "ya")
                {
                    MessageBox.Show("Ya tienes esta cancion en la biblioteca");
                }
                else
                {
                    MessageBox.Show("El archivo elegido no es mp3");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //try
            //{
            //    trackBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            //    trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            //}
            //catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            mensajes.Hide();
            string nombre = "hack/david/sebas/";// Sockets.Conectar(9, name, "", "", "", "", "");
            if (nombre.Length != 0)
            {
                string[] gen = new string[10];
                int z = 0;
                int j = 0;
                int n = 1;
                for (int c = 0; nombre.Length > c; c++)
                {
                    if (nombre.Substring(c, 1) == "/")
                    {
                        gen[z] = nombre.Substring(j, n - 1);
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
                        lista.Items.Add(usuario);
                    }
                }
            }
            else
            {
                lista.Items.Add("No tienes amigos");
            }

            lista.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Items.Clear();
            string nombre = "hola/data/david/data/sebas/data/hack/data/";// Sockets.Conectar(8, "", name, "", "", "", "");
            int x = 0;
            int z = 0;
            int j = 0;
            if (nombre.Length != 0)
            {
                for (int i = 0; nombre.Length > i; i++)
                {
                    if (nombre.Substring(i, 1).Equals("/"))
                    {
                        if (x == 1)
                        {
                            x = 0;
                            j = 0 - 1;
                            z = i + 1;
                        }
                        else
                        {
                            mensajes.Items.Add(nombre.Substring(z, j));
                            x++;
                        }
                    }
                    j++;
                }
            }
            else
            {
                mensajes.Items.Add("No tienes nuevos mensajes");
            }
            mensajes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.Hide();
            mensajes.Hide();
        }

        private void general_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enviar_msj(object sender, EventArgs e)
        {
            Mensaje mensaje = new Mensaje(name, (string)lista.SelectedItem);
            mensaje.Show();
        }

        private void leer_msj(object sender, EventArgs e)
        {
            Recomendacion recomendacion = new Recomendacion(name, (string)mensajes.SelectedItem);
            recomendacion.Show();
        }
    }
}
