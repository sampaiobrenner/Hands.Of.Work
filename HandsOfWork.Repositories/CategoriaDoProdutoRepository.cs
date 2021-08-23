using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Repositories
{
    public class CategoriaDoProdutoRepository : CrudRepository<CategoriaDoProduto, Guid>
    {
        public override void Cadastrar(CategoriaDoProduto entity)
        {
            throw new NotImplementedException();
        }

        public override void Editar(CategoriaDoProduto entity)
        {
            throw new NotImplementedException();
        }

        public override void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<CategoriaDoProduto> Listar()
        {
            throw new NotImplementedException();
        }

        public override CategoriaDoProduto ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}