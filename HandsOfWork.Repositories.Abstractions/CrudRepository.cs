using HandsOfWork.Entities.Abstractions;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.Abstractions
{
    public abstract class CrudRepository<TEntity, TEntityKey> : ICrudRepository<TEntity, TEntityKey>
        where TEntityKey : struct
        where TEntity : BaseEntity<TEntityKey>
    {
        public abstract void Cadastrar(TEntity entity);

        public abstract void Editar(TEntity entity);

        public abstract void Excluir(TEntityKey id);

        public abstract IEnumerable<TEntity> Listar();

        public abstract TEntity ObterPorId(TEntityKey id);
    }
}