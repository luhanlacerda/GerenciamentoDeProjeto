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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        TelaTesteConexao TelaTestarConexao;
        private void testarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaTestarConexao == null)
            {
                TelaTestarConexao = new TelaTesteConexao();
                TelaTestarConexao.MdiParent = this;
                TelaTestarConexao.FormClosed += TelaTestarConexao_FormClosed;
                TelaTestarConexao.Show();
            }
            else
            {
                TelaTestarConexao.Activate();
            }
        }

        private void TelaTestarConexao_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaTestarConexao = null;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        TelaCadastroGerente TelaCadastrarGerente;
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaCadastrarGerente == null)
            {
                TelaCadastrarGerente = new TelaCadastroGerente();
                TelaCadastrarGerente.MdiParent = this;
                TelaCadastrarGerente.FormClosed += TelaCadastrarGerente_FormClosed;
                TelaCadastrarGerente.Show(); 
            }
            else
            {
                TelaCadastrarGerente.Activate();
            }
        }

        private void TelaCadastrarGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaCadastrarGerente = null;
        }

        TelaConsultaGerente TelaConsultarGerente;
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TelaConsultarGerente == null)
            {
                TelaConsultarGerente = new TelaConsultaGerente();
                TelaConsultarGerente.MdiParent = this;
                TelaConsultarGerente.FormClosed += TelaConsultarGerente_FormClosed;
                TelaConsultarGerente.Show();
            }
        }

        private void TelaConsultarGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaConsultarGerente = null;
        }
    }
}
