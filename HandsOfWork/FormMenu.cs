using HandsOfWork.Forms.CategoriaDeProdutos;
using HandsOfWork.Forms.Clientes;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public partial class FormMenu : Form
    {
        private readonly FormListagemDeCategoriaDeProduto _formListagemDeCategoriaDeProduto;
        private readonly FormListagemDeClientes _formListagemDeClientes;

        public FormMenu(FormListagemDeCategoriaDeProduto formListagemDeCategoriaDeProduto, FormListagemDeClientes formListagemDeClientes)
        {
            _formListagemDeCategoriaDeProduto = formListagemDeCategoriaDeProduto;
            _formListagemDeClientes = formListagemDeClientes;
            InitializeComponent();
        }

        private void btnCategoriaDeProduto_Click(object sender, EventArgs e)
        {
            _formListagemDeCategoriaDeProduto.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            _formListagemDeClientes.ShowDialog();
        }
    }
}