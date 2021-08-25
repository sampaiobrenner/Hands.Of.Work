using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Threading.Tasks;
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
            await ListarCategorias();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvListagemCategoriaProduto.CurrentRow is null) return;

            var dialogResult = MessageBox.Show("Você realmente deseja excluir a categoria selecionada?", "Confirmação de exclusão", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;

            var id = int.Parse(dgvListagemCategoriaProduto.CurrentRow.Cells["Id"].Value.ToString());
            await _categoriaDoProdutoService.ExcluirAsync(id);
            MessageBox.Show("Categoria excluida com sucesso!");

            await ListarCategorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormListagemDeCategoriaDeProduto_Load(object sender, EventArgs e)
        {
            await ListarCategorias();
        }

        private async Task ListarCategorias()
        {
            dgvListagemCategoriaProduto.DataSource = await _categoriaDoProdutoService.ListarAsync();
        }
    }
}