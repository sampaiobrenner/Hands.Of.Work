using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.CategoriaDeProdutos
{
    public partial class FormListagemDeCategoriaDeProduto : Form
    {
        private readonly ICrudService<CategoriaDoProduto, int> _categoriaDoProdutoService;
        private readonly FormCadastroCategoriaDeProduto _formCadastroCategoriaDeProduto;

        public FormListagemDeCategoriaDeProduto(FormCadastroCategoriaDeProduto formCadastroCategoriaDeProduto, ICrudService<CategoriaDoProduto, int> categoriaDoProdutoService)
        {
            _formCadastroCategoriaDeProduto = formCadastroCategoriaDeProduto;
            _categoriaDoProdutoService = categoriaDoProdutoService;
            InitializeComponent();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            _formCadastroCategoriaDeProduto.ShowDialog();
            dgvListagemCategoriaProduto.DataSource = await _categoriaDoProdutoService.ListarAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormListagemDeCategoriaDeProduto_Load(object sender, EventArgs e)
        {
            dgvListagemCategoriaProduto.DataSource = await _categoriaDoProdutoService.ListarAsync();
        }
    }
}