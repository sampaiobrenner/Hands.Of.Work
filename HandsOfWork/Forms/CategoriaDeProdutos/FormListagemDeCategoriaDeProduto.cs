using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.CategoriaDeProdutos
{
    public partial class FormListagemDeCategoriaDeProduto : Form
    {
        private readonly FormCadastroCategoriaDeProduto _formCadastroCategoriaDeProduto;

        public FormListagemDeCategoriaDeProduto(FormCadastroCategoriaDeProduto formCadastroCategoriaDeProduto)
        {
            _formCadastroCategoriaDeProduto = formCadastroCategoriaDeProduto;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _formCadastroCategoriaDeProduto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}