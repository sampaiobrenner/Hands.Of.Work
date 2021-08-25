using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Repositories.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOfWork.Services.Abstractions
{
    public abstract class CrudService<TEntity, TEntityKey> : ICrudService<TEntity, TEntityKey>
        where TEntityKey : struct
        where TEntity : BaseEntity<TEntityKey>
    {
        private readonly ICrudRepository<TEntity, TEntityKey> _crudRepository;

        protected CrudService(ICrudRepository<TEntity, TEntityKey> crudRepository)
        {
            _crudRepository = crudRepository;
        }

        public async Task CadastrarAsync(TEntity entity)
            => await _crudRepository.CadastrarAsync(entity);

        public async Task EditarAsync(TEntity entity)
            => await _crudRepository.EditarAsync(entity);

        public async Task ExcluirAsync(TEntityKey id)
            => await _crudRepository.ExcluirAsync(id);

        public async Task<IEnumerable<TEntity>> ListarAsync()
            => await _crudRepository.ListarAsync();

        public async Task<TEntity> ObterPorIdAsync(TEntityKey id)
            => await _crudRepository.ObterPorIdAsync(id);
    }
}