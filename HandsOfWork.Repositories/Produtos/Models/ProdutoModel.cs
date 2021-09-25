using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;

namespace HandsOfWork.Repositories.Produtos.Models
{
    public class ProdutoModel : BaseEntity<int>
    {
        public CategoriaDoProdutoModel CategoriaDoProduto { get; set; }
        public int CategoriaDoProdutoId { get; set; }
        public string Descricao { get; set; }
    }
}