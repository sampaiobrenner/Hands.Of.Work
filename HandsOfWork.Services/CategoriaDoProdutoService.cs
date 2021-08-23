using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Services.Abstractions;
using System;

namespace HandsOfWork.Services
{
    public class CategoriaDoProdutoService : CrudService<CategoriaDoProduto, Guid>
    {
        public CategoriaDoProdutoService(ICrudRepository<CategoriaDoProduto, Guid> crudRepository)
            : base(crudRepository)
        {
        }
    }
}