using HandsOfWork.Entities.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOfWork.Repositories.Abstractions
{
    public interface ICrudRepository<TEntity, in TEntityKey>
        where TEntityKey : struct
        where TEntity : BaseEntity<TEntityKey>
    {
        Task CadastrarAsync(TEntity entity);

        Task EditarAsync(TEntity entity);

        Task ExcluirAsync(TEntityKey id);

        Task<IEnumerable<TEntity>> ListarAsync();

        Task<TEntity> ObterPorIdAsync(TEntityKey id);
    }
}