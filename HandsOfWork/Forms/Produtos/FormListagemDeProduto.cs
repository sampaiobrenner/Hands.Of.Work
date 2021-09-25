using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Reflection;
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

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
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

        private void dgvListagemDeProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvListagemDeProduto.Rows[e.RowIndex].DataBoundItem != null) && (dgvListagemDeProduto.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvListagemDeProduto.Rows[e.RowIndex].DataBoundItem, dgvListagemDeProduto.Columns[e.ColumnIndex].DataPropertyName);
            }
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