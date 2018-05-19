using System;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Amigo : Form
    {
        string name = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    MessageBox.Show("Ya tienes este usuario con amigo");
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
