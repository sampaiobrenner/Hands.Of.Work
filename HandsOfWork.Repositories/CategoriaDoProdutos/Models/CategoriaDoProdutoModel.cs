using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Models
{
    public class CategoriaDoProdutoModel : BaseEntity<int>
    {
        public string Descricao { get; set; }
    }
}