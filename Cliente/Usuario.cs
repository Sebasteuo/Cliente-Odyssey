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
            string[] genero = new string[boxGenero.CheckedItems.Count];
            if (boxGenero.CheckedItems.Count > 0)
            {
                int i = 0;
                foreach (string s in boxGenero.CheckedItems)
                {
                    genero[i] = s;
                    i++;
                }
            }
            string nick = boxNick.Text;
            string name = boxName.Text;
            string edad = boxEdad.Text;
            string contra = boxContra.Text;
            string amigos = boxAmigos.Text;
            // crear(nick,name,edad,genero,contra,amigos)

            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
