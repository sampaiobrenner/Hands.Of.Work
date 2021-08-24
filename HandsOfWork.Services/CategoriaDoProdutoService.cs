using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;

namespace HandsOfWork.Services
{
    public class CategoriaDoProdutoService : CrudService<CategoriaDoProduto, int>
    {
        public CategoriaDoProdutoService(ICrudRepository<CategoriaDoProduto, int> crudRepository)
            : base(crudRepository)
        {
        }
    }
}