using Ejercicio1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar();
            txtResultado.Text = suma.operar(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text)).ToString();    
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            txtResultado.Text = resta.operar(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Restar multiplicacion = new Restar();
            txtResultado.Text = multiplicacion.operar(int.Parse(txtValor1.Text), int.Parse(txtValor2.Text)).ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtValor1.Text = "";
            txtValor2.Text = "";
        }
    }
}
