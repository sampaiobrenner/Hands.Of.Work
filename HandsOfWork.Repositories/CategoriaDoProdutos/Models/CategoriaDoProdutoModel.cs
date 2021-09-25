using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Repositories.Produtos.Models;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Models
{
    public class CategoriaDoProdutoModel : BaseEntity<int>
    {
        public string Descricao { get; set; }
        public ICollection<ProdutoModel> Produtos { get; set; }
    }
}