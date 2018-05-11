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
    public partial class Amigo : Form
    {
        public Amigo()
        {
            InitializeComponent();
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
                string validacion = "true";
                if(validacion == "true"){
                    MessageBox.Show("Se ha agregado el usuario");
                }
                else if(validacion == "ya")
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
    }
}
