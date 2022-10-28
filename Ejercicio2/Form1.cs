using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int cont;
            if (txtCadena.Text.Length > 0)
            {
                cont = txtCadena.Text.Count(c => c.Equals(Char.Parse(comboCaracter.Text)));
                txtResultado.Text = "Condidencias de "+comboCaracter.Text + " en la cadena: "+cont;
            }
            else {
                MessageBox.Show("Cadena no valida");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCadena.Text.Count(c => c.Equals(Char.Parse(comboCaracter.Text))) != 0)
            {
                txtResultado.Text= txtCadena.Text.Replace(comboCaracter.Text,"");
            }
            else {
                MessageBox.Show("No hay vocal");
            }
        }
    }
}
