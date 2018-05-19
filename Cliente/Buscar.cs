using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Buscar : Form
    {
        public Buscar()
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

        private void Buscar_Load(object sender, EventArgs e)
        {
            int tipo = Odyssey.GetTipo();
            if (tipo == 1)
            {
                label1.Text ="Nombre de la cancion";
                this.SetClientSizeCore(774,210);
            }
            else if (tipo == 2)
            {
                label1.Text = "Nombre del artista";
                textBox1.SetBounds(46, 110, 612, 20);
                button1.SetBounds(631, 175, 75, 23);
                button2.SetBounds(550, 175, 75, 23);
                this.SetClientSizeCore(718, 210);
            }
            else if (tipo == 3)
            {
                label1.Text = "Nombre del album";
                textBox1.SetBounds(24, 110, 612, 20);
                button1.SetBounds(576, 175, 75, 23);
                button2.SetBounds(495, 175, 75, 23);
                this.SetClientSizeCore(663, 210);
            }
            else
            {
                label1.Text = "Letra de la cancion";
                textBox1.SetBounds(61, 110, 612, 20);
                button1.SetBounds(649, 175, 75, 23);
                button2.SetBounds(568, 175, 75, 23);
                this.SetClientSizeCore(736, 210);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
