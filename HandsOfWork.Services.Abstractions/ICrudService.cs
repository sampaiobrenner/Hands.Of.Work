﻿using HandsOfWork.Entities.Abstractions;
using System.Collections.Generic;

namespace HandsOfWork.Services.Abstractions
{
    public interface ICrudService<TEntity, TEntityKey>
        where TEntityKey : struct
        where TEntity : BaseEntity<TEntityKey>
    {
        void Cadastrar(TEntity entity);

        void Editar(TEntity entity);

        void Excluir(TEntityKey id);

        IEnumerable<TEntity> Listar();

        TEntity ObterPorId(TEntityKey id);
    }
}