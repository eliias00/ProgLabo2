using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ej_40
{
    public partial class FormLlamador : Form
    {
        Centralita centralita;  
        public FormLlamador(Centralita centrilita)
        {
            InitializeComponent();
            this.centralita = centralita;
                
        }
        public Centralita Centralita
        {
            get { return this.centralita; }
        }   

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
