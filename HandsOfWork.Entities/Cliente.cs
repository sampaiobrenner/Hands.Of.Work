using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public string Nome { get; set; }
    }
}
