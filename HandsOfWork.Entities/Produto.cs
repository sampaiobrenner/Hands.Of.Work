using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities
{
    public class Produto : BaseEntity<int>
    {
        public CategoriaDoProduto CategoriaDoProduto { get; set; }
        public string Descricao { get; set; }
    }
}