using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.CategoriaDoProdutos
{
    public class CategoriaDoProdutoRepository : CrudRepository<CategoriaDoProduto, Guid>
    {
        private readonly IMapper _mapper;

        public CategoriaDoProdutoRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public override void Cadastrar(CategoriaDoProduto entity)
        {
            var model = _mapper.Map<CategoriaDoProduto, CategoriaDoProdutoModel>(entity);
        }

        public override void Editar(CategoriaDoProduto entity)
        {
        }

        public override void Excluir(Guid id)
        {
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