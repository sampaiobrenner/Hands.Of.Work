using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.CategoriaDeProdutos
{
    public partial class FormCadastroCategoriaDeProduto : Form
    {
        private readonly ICrudService<CategoriaDoProduto, int> _categoriaDoProdutoService;

        public FormCadastroCategoriaDeProduto(ICrudService<CategoriaDoProduto, int> categoriaDoProdutoService)
        {
            InitializeComponent();
            _categoriaDoProdutoService = categoriaDoProdutoService;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDescricao.Text))
            {
                MessageBox.Show("O campo descrição deve ser informado.");
                txbDescricao.Focus();
                return;
            }

            var categoriaDoProduto = new CategoriaDoProduto { Descricao = txbDescricao.Text };
            _categoriaDoProdutoService.Cadastrar(categoriaDoProduto);

            MessageBox.Show("Categoria cadastrada com sucesso!");
        }
    }
}