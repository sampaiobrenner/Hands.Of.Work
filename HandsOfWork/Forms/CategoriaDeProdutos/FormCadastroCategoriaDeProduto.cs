using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.CategoriaDeProdutos
{
    public partial class FormCadastroCategoriaDeProduto : Form
    {
        public int? Id { get; set; }

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

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbDescricao.Text))
            {
                MessageBox.Show("O campo descrição deve ser informado.");
                txbDescricao.Focus();
                return;
            }

            var categoriaDoProduto = new CategoriaDoProduto { Descricao = txbDescricao.Text };

            if (Id != null)
            {
                categoriaDoProduto.Id = Id.Value;
                await _categoriaDoProdutoService.EditarAsync(categoriaDoProduto);
                MessageBox.Show("Categoria editada com sucesso!");
            }
            else
            {
                await _categoriaDoProdutoService.CadastrarAsync(categoriaDoProduto);
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }
         
            Close();
        }

        private async void FormCadastroCategoriaDeProduto_Load(object sender, EventArgs e)
        {
            if (Id is null) return;
            
            var categoria = await _categoriaDoProdutoService.ObterPorIdAsync(Id.Value);
            txbDescricao.Text = categoria.Descricao;
        }
    }
}