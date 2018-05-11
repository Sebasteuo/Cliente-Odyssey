using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Odyssey : Form
    {
        static int tipo = 0;
        public static int GetTipo()
        {
            return tipo;
        }

        public Odyssey()
        {
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
            tipo = 1;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tipo = 2;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tipo = 3;
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
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
            axWindowsMediaPlayer1.URL = (string) listBox1.SelectedItem;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label5.Text = ((int)axWindowsMediaPlayer1.currentMedia.duration).ToString();
                trackBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            catch { }
                
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string track in openFileDialog1.FileNames){
                string validacion = "true";
                if (validacion == "true")
                {
                    listBox1.Items.Add(track);
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
    }
}
