using HandsOfWork.Entities.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOfWork.Repositories.Abstractions
{
    public abstract class CrudRepository<TEntity, TEntityKey> : ICrudRepository<TEntity, TEntityKey>
        where TEntityKey : struct
        where TEntity : BaseEntity<TEntityKey>
    {
        public abstract Task CadastrarAsync(TEntity entity);

        public abstract Task EditarAsync(TEntity entity);

        public abstract Task ExcluirAsync(TEntityKey id);

        public abstract Task<IEnumerable<TEntity>> ListarAsync();

        public abstract Task<TEntity> ObterPorIdAsync(TEntityKey id);
    }
}