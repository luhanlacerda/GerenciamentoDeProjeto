using Biblioteca.gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeProjeto
{
    public partial class TelaConsultaGerente : Form
    {
        List<Gerente> gerentes = new List<Gerente>();
        public TelaConsultaGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gerentes.Count; i++)
            {
                ListViewItem linha = listViewGerentes.Items.Add(i.ToString());
               //linha.SubItems.Add(gerentes.ElementAt(i));
            }
        }
    }
}
