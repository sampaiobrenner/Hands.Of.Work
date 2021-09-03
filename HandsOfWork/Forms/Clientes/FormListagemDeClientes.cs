using System;
using System.Windows.Forms;

namespace HandsOfWork.Forms.Clientes
{
    public partial class FormListagemDeClientes : Form
    {
        private readonly FormCadastroCliente _formCadastroCliente;

        public FormListagemDeClientes(FormCadastroCliente formCadastroCliente)
        {
            _formCadastroCliente = formCadastroCliente;
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _formCadastroCliente.ShowDialog();
        }
    }
}
