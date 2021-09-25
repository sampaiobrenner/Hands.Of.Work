using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Produtos
{
    public partial class FormListagemDeProduto : Form
    {
        private readonly FormCadastroProduto _formCadastroProduto;
        private readonly ICrudService<Produto, int> _produtoService;

        public FormListagemDeProduto(FormCadastroProduto formCadastroProduto, ICrudService<Produto, int> produtoService)
        {
            _formCadastroProduto = formCadastroProduto;
            _produtoService = produtoService;
            InitializeComponent();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            _formCadastroProduto.Id = null;
            _formCadastroProduto.ShowDialog();
            await ListarProdutos();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListagemDeProduto.CurrentRow is null) return;
            _formCadastroProduto.Id = int.Parse(dgvListagemDeProduto.CurrentRow.Cells["Id"].Value.ToString());
            _formCadastroProduto.ShowDialog();
            await ListarProdutos();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvListagemDeProduto.CurrentRow is null) return;

            var dialogResult = MessageBox.Show("Você realmente deseja excluir o produto selecionado?", "Confirmação de exclusão", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;

            var id = int.Parse(dgvListagemDeProduto.CurrentRow.Cells["Id"].Value.ToString());
            await _produtoService.ExcluirAsync(id);
            MessageBox.Show("Produto excluido com sucesso!");

            await ListarProdutos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormListagemDeProduto_Load(object sender, EventArgs e)
        {
            await ListarProdutos();
        }

        private async Task ListarProdutos()
        {
            dgvListagemDeProduto.AutoGenerateColumns = false;
            dgvListagemDeProduto.DataSource = await _produtoService.ListarAsync();
        }
    }
}