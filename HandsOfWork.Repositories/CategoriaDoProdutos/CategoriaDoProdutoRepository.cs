using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;
using HandsOfWork.Repositories.Contexts;
using System;
using System.Collections.Generic;

namespace HandsOfWork.Repositories.CategoriaDoProdutos
{
    public class CategoriaDoProdutoRepository : CrudRepository<CategoriaDoProduto, int>
    {
        private readonly HandsOfWorkContext _context;
        private readonly IMapper _mapper;

        public CategoriaDoProdutoRepository(HandsOfWorkContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override void Cadastrar(CategoriaDoProduto entity)
        {
            var model = _mapper.Map<CategoriaDoProduto, CategoriaDoProdutoModel>(entity);
            _context.CategoriaDoProduto.Add(model);
            _context.SaveChanges();
        }

        public override void Editar(CategoriaDoProduto entity)
        {
        }

        public override void Excluir(int id)
        {
        }

        public override IEnumerable<CategoriaDoProduto> Listar()
        {
            throw new NotImplementedException();
        }

        public override CategoriaDoProduto ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}