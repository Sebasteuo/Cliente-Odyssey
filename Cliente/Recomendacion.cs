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
    public partial class Recomendacion : Form
    {
        string name = "";
        string emisor = "";
        string data = "";
        public Recomendacion(string name, string emisor)
        {
            for (int i=0; i < emisor.Length; i++)
            {
                if (emisor.Substring(i,1)=="-")
                {
                    this.emisor = emisor.Substring(0,i-1);
                    this.data = emisor.Substring(i+1);
                }
            }
            this.name = name;
            InitializeComponent();
        }

        private void Recomendacion_Load(object sender, EventArgs e)
        {
            label1.Text = ("Tu amigo " + emisor + ", te ha recomendado esta cancion: " + data);
            if (label1.Width > 320)
            {
                button2.SetBounds(button2.Left + ((label1.Width - this.Width)/2), 89, 75, 23);
                button3.SetBounds(button3.Left + (label1.Width - this.Width), 89, 75, 23);
                this.SetClientSizeCore(this.Width + (label1.Width - this.Width)+20,124);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
