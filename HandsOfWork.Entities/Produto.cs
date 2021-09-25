using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities
{
    public class Produto : BaseEntity<int>
    {
        public int CategoriaDoProdutoId { get; set; }
        public string Descricao { get; set; }
    }
}