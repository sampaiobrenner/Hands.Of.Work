using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;
namespace HandsOfWork.Services
{
    public class ClienteService : CrudService<Cliente, int>
    {
        public ClienteService(ICrudRepository<Cliente, int> crudRepository) 
            : base(crudRepository)
        {
        }
    }
}
