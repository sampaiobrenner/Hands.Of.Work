using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.CategoriaDeProdutos
{
    public partial class FormCadastroCategoriaDeProduto : Form
    {
        private readonly ICrudService<CategoriaDoProduto, Guid> _categoriaDoProdutoService;

        public FormCadastroCategoriaDeProduto(ICrudService<CategoriaDoProduto, Guid> categoriaDoProdutoService)
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
            var categoriaDoProduto = new CategoriaDoProduto { Descricao = lblDescricao.Text };
            _categoriaDoProdutoService.Cadastrar(categoriaDoProduto);

            MessageBox.Show("Categoria cadastrada com sucesso!");
        }
    }
}