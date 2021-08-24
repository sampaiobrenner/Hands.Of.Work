using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities
{
    public class CategoriaDoProduto : BaseEntity<int>
    {
        public string Descricao { get; set; }
    }
}