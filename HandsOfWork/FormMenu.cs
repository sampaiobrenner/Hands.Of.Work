using HandsOfWork.Forms.CategoriaDeProdutos;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public partial class FormMenu : Form
    {
        private readonly FormListagemDeCategoriaDeProduto _formListagemDeCategoriaDeProduto;

        public FormMenu(FormListagemDeCategoriaDeProduto formListagemDeCategoriaDeProduto)
        {
            _formListagemDeCategoriaDeProduto = formListagemDeCategoriaDeProduto;
            InitializeComponent();
        }

        private void btnCategoriaDeProduto_Click(object sender, EventArgs e)
        {
            _formListagemDeCategoriaDeProduto.ShowDialog();
        }
    }
}