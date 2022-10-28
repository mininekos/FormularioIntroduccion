using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void rdAscendente_CheckedChanged(object sender, EventArgs e)
        {
            txtTabla.Text = "";
            for (int ind = 0; ind <= 10; ind++) {
                txtTabla.Text += Numero.Value +" X " + ind+" = "+(Numero.Value*ind) +"\r\n";
            }

        }

        private void rdDescente_CheckedChanged(object sender, EventArgs e)
        {
            txtTabla.Text = "";
            for (int ind = 10; ind >=0; ind--)
            {
                txtTabla.Text += Numero.Value + " X " + ind + " = " + (Numero.Value * ind) + "\r\n";
            }
        }
    }
}
