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
    public partial class TelaCadastroGerente : Form
    {
        public TelaCadastroGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Gerente gerente = new Gerente()
                {
                    nome = textBoxNome.Text,
                    numero = Convert.ToInt32(boxCodigos.Value)
                };

                GerenteDados conn = new GerenteDados();
                conn.Cadastrar(gerente);
                MessageBox.Show("Gerente cadastrado com sucesso!");

                textBoxNome.Text = "";
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
