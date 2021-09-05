using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Clientes
{
    public partial class FormCadastroCliente : Form
    {
        public int? Id { get; set; }


        private readonly ICrudService<Cliente, int> _clienteService;

        public FormCadastroCliente(ICrudService<Cliente, int> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("O campo nome deve ser informado.");
                txbNome.Focus();
                return;
            }

            var cliente = new Cliente { Nome = txbNome.Text };

            if (Id != null)
            {
                cliente.Id = Id.Value;
                await _clienteService.EditarAsync(cliente);
                MessageBox.Show("Cliente editado com sucesso!");
            }
            else
            {
                await _clienteService.CadastrarAsync(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }

            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            if (Id is null)
            {
                txbNome.Text = null;
                return;
            }

            var cliente = await _clienteService.ObterPorIdAsync(Id.Value);
            txbNome.Text = cliente.Nome;
        }
    }
}
