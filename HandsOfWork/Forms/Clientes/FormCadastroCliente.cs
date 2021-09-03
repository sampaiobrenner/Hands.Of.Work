using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Clientes
{
    public partial class FormCadastroCliente : Form
    {
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
            await _clienteService.CadastrarAsync(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso!");
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
