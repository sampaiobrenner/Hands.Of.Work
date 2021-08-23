using HandsOfWork.Forms.CategoriaDeProdutos;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public partial class Form1 : Form
    {
        private readonly FormCadastroCategoriaDeProduto _formCadastroCategoriaDeProduto;

        public Form1(FormCadastroCategoriaDeProduto formCadastroCategoriaDeProduto)
        {
            InitializeComponent();
            _formCadastroCategoriaDeProduto = formCadastroCategoriaDeProduto;
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            _formCadastroCategoriaDeProduto.ShowDialog();
        }
    }
}