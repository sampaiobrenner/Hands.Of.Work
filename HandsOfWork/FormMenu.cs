using HandsOfWork.Forms.CategoriaDeProdutos;
using HandsOfWork.Forms.Clientes;
using HandsOfWork.Forms.Produtos;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public partial class FormMenu : Form
    {
        private readonly FormListagemDeCategoriaDeProduto _formListagemDeCategoriaDeProduto;
        private readonly FormListagemDeClientes _formListagemDeClientes;
        private readonly FormListagemDeProduto _formListagemDeProduto;

        public FormMenu(FormListagemDeCategoriaDeProduto formListagemDeCategoriaDeProduto, FormListagemDeClientes formListagemDeClientes, FormListagemDeProduto formListagemDeProduto)
        {
            _formListagemDeCategoriaDeProduto = formListagemDeCategoriaDeProduto;
            _formListagemDeClientes = formListagemDeClientes;
            _formListagemDeProduto = formListagemDeProduto;
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

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            _formListagemDeProduto.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não implementado!");
        }
    }
}