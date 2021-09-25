using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Produtos
{
    public partial class FormCadastroProduto : Form
    {
        private readonly ICrudService<CategoriaDoProduto, int> _categoriaDeProdutoService;
        private readonly ICrudService<Produto, int> _produtoService;

        public FormCadastroProduto(ICrudService<CategoriaDoProduto, int> categoriaDeProdutoService, ICrudService<Produto, int> produtoService)
        {
            _categoriaDeProdutoService = categoriaDeProdutoService;
            _produtoService = produtoService;
            InitializeComponent();
        }

        public int? Id { get; set; }

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

            if (cboCategorias.SelectedValue is null)
            {
                MessageBox.Show("O campo categoria deve ser informado.");
                cboCategorias.Focus();
                return;
            }

            var categoriaDoProduto = new CategoriaDoProduto { Id = int.Parse(cboCategorias.SelectedValue.ToString()) };
            var produto = new Produto { Descricao = txbDescricao.Text, CategoriaDoProduto = categoriaDoProduto };

            if (Id != null)
            {
                produto.Id = Id.Value;
                await _produtoService.EditarAsync(produto);
                MessageBox.Show("Produto editado com sucesso!");
            }
            else
            {
                await _produtoService.CadastrarAsync(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }

            Close();
        }

        private async void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            cboCategorias.DataSource = await _categoriaDeProdutoService.ListarAsync();

            if (Id is null)
            {
                txbDescricao.Text = null;
                return;
            }

            var produto = await _produtoService.ObterPorIdAsync(Id.Value);
            txbDescricao.Text = produto.Descricao;
            cboCategorias.SelectedValue = produto.CategoriaDoProduto.Id;
        }
    }
}