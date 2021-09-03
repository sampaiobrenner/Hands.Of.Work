using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Clientes
{
    public partial class FormListagemDeClientes : Form
    {
        private readonly ICrudService<Cliente, int> _clienteService;
        private readonly FormCadastroCliente _formCadastroCliente;

        public FormListagemDeClientes(FormCadastroCliente formCadastroCliente, ICrudService<Cliente, int> clienteService)
        {
            _formCadastroCliente = formCadastroCliente;
            _clienteService = clienteService;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            _formCadastroCliente.ShowDialog();
            await ListarClientes();
        }

        private async void FormListagemDeClientes_Load(object sender, EventArgs e)
        {
            await ListarClientes();
        }

        private async Task ListarClientes()
        {
            dgvListagemClientes.DataSource = await _clienteService.ListarAsync();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvListagemClientes.CurrentRow is null) return;

            var dialogResult = MessageBox.Show("Você realmente deseja excluir o cliente selecionada?", "Confirmação de exclusão", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;

            var id = int.Parse(dgvListagemClientes.CurrentRow.Cells["Id"].Value.ToString());
            await _clienteService.ExcluirAsync(id);
            MessageBox.Show("Cliente excluido com sucesso!");

            await ListarClientes();
        }
    }
}
