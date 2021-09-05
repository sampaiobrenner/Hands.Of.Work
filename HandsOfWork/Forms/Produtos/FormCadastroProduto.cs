using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Produtos
{
    public partial class FormCadastroProduto : Form
    {
        private readonly ICrudService<CategoriaDoProduto, int> _categoriaDeProdutoService;

        public FormCadastroProduto(ICrudService<CategoriaDoProduto, int> categoriaDeProdutoService)
        {
            _categoriaDeProdutoService = categoriaDeProdutoService;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            cboCategorias.DataSource = await _categoriaDeProdutoService.ListarAsync();
        }
    }
}
