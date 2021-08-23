using HandsOfWork.Entities.Abstractions;
using HandsOfWork.Repositories.Abstractions;
using System.Collections.Generic;

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

        public void Cadastrar(TEntity entity) => _crudRepository.Cadastrar(entity);

        public void Editar(TEntity entity) => _crudRepository.Editar(entity);

        public void Excluir(TEntityKey id) => _crudRepository.Excluir(id);

        public List<TEntity> Listar() => _crudRepository.Listar();

        public TEntity ObterPorId(TEntityKey id) => _crudRepository.ObterPorId(id);
    }
}