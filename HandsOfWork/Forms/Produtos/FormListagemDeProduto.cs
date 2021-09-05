using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Produtos
{
    public partial class FormListagemDeProduto : Form
    {
        private readonly FormCadastroProduto _formCadastroProduto;

        public FormListagemDeProduto(FormCadastroProduto formCadastroProduto)
        {
            _formCadastroProduto = formCadastroProduto;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _formCadastroProduto.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
