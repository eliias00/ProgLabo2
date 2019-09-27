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
    public partial class FormularioMenu : Form
    {
        Centralita centralita;
        public FormularioMenu()
        {
            InitializeComponent();
            centralita = new Centralita("center ;)");
        }

        private void btnGenLLam_Click(object sender, EventArgs e)
        {
            FormLlamador frmLlamador = new FormLlamador(centralita);
            frmLlamador.ShowDialog();
            this.centralita = frmLlamador.Centralita;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
