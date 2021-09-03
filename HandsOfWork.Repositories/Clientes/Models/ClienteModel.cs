using HandsOfWork.Entities.Abstractions;

namespace HandsOfWork.Repositories.Clientes.Models
{
    public class ClienteModel : BaseEntity<int>
    {
        public string Nome { get; set; }
    }
}
