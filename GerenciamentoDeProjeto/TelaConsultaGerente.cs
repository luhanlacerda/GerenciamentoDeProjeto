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
       
        public TelaConsultaGerente()
        {
            InitializeComponent();
        }


        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            listViewGerentes.Items.Clear();
            try
            {
                List<Gerente> gerentes = TelaPrincipal.GerenteNegocio.Selecionar(new Gerente());

                foreach (Gerente gerente in gerentes)
                {
                    ListViewItem linha = listViewGerentes.Items.Add(gerente.Nr_Gerente.ToString());
                    linha.SubItems.Add(gerente.Nm_Gerente.ToString());
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (listViewGerentes.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewGerentes.SelectedItems.Cast<ListViewItem>().ToList().ElementAt(0);
                Gerente gerente = new Gerente()
                {
                    Nr_Gerente = Convert.ToInt32(selected.Text)
                };

                try
                {
                    TelaPrincipal.GerenteNegocio.Remover(gerente);
                    listViewGerentes.Items.Remove(selected);
                    MessageBox.Show("Gerente excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
