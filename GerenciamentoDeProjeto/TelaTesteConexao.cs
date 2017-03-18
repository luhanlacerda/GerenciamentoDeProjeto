using Biblioteca.conexao;
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
    public partial class TelaTesteConexao : Form
    {
        public TelaTesteConexao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSqlServer conn = new ConexaoSqlServer();
                conn.abrirConexao();
                conn.fecharConexao();
                MessageBox.Show("Conexão efetuada com sucesso!");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
