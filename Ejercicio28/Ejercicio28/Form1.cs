using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int OrdenarDescendente(int num1, int num2)
        {
            return -num1.CompareTo(num2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> miDiccionarioPalabras = new Dictionary<string, int>();

            List<KeyValuePair<string, int>> dicLista = new List<KeyValuePair<string, int>>();

            StringBuilder s = new StringBuilder();

            string[] palabras = richTxtBox.Text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '(', ')' });


            for (int i = 0; i < palabras.Length; i++)
            {
                    
                if (!miDiccionarioPalabras.ContainsKey(palabras[i]))
                  {
                    miDiccionarioPalabras.Add(palabras[i], 1);
                  }
                else
                  {
                    miDiccionarioPalabras[palabras[i]]++;
                  }
            }
           
            dicLista = miDiccionarioPalabras.ToList();
            dicLista.Sort((x, y) => Ejercicio28.Form1.OrdenarDescendente(x.Value, y.Value));
          
            s.AppendLine("Palabras con mas apariciones: ");
            for (int i = 0; i < dicLista.Capacity; i++)
            {
                s.AppendFormat("* {0} - apariciones: {1}\n", dicLista[i].Key, dicLista[i].Value);
            }
            MessageBox.Show(s.ToString(), "TOP 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
