using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monedas;

namespace form23
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AcceptButton ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(txtEuro.Text, out cantidad);
            if (cantidad <= 0)
            {
                return;
            }
            Euro euro = new Euro(cantidad);
            txtEuroAPeso.Text = ((Pesos)euro).GetCantidad().ToString();
            txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(txtDolar.Text, out cantidad);
            if (cantidad <= 0)
            {
                return;
            }
            Dolar dolar = new Dolar(cantidad);
            txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            txtDolarAPeso.Text = ((Pesos)dolar).GetCantidad().ToString();
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(txtPeso.Text, out cantidad);
            if (cantidad <= 0)
            {
                return;
            }
            Pesos pesos = new Pesos(cantidad);
            txtPesoAEuro.Text = ((Euro)pesos).GetCantidad().ToString();
            txtPesoADolar.Text = ((Dolar)pesos).GetCantidad().ToString();
        }

        private void txtEuro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
