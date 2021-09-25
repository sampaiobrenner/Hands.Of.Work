using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.Contexts;
using HandsOfWork.Repositories.Produtos.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOfWork.Repositories.Produtos
{
    public class ProdutoRepository : CrudRepository<Produto, int>
    {
        private readonly HandsOfWorkContext _context;
        private readonly IMapper _mapper;

        public ProdutoRepository(HandsOfWorkContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task CadastrarAsync(Produto entity)
        {
            var model = _mapper.Map<Produto, ProdutoModel>(entity);
            await _context.Produto.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public override async Task EditarAsync(Produto entity)
        {
            var model = await _context.Produto.FirstOrDefaultAsync(x => x.Id == entity.Id);
            _context.Produto.Update(_mapper.Map(entity, model));
            await _context.SaveChangesAsync();
        }

        public override async Task ExcluirAsync(int id)
        {
            var model = await _context.Produto.FirstOrDefaultAsync(x => x.Id == id);
            _context.Produto.Remove(model);
            await _context.SaveChangesAsync();
        }

        public override async Task<IEnumerable<Produto>> ListarAsync()
        {
            var models = await _context.Produto.ToListAsync();
            var categorias = _mapper.Map<IEnumerable<ProdutoModel>, IEnumerable<Produto>>(models);
            return categorias;
        }

        public override async Task<Produto> ObterPorIdAsync(int id)
        {
            var model = await _context.Produto.FirstOrDefaultAsync(x => x.Id == id);
            var categoria = _mapper.Map<ProdutoModel, Produto>(model);
            return categoria;
        }
    }
}