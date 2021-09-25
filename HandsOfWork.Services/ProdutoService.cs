using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services
{
    public class ProdutoService : CrudService<Produto, int>
    {
        public ProdutoService(ICrudRepository<Produto, int> crudRepository)
            : base(crudRepository)
        {
        }
    }
}