using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities
{
    public class Produto : BaseEntity<int>
    {
        public string Descricao { get; set; }
    }
}
