using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;
using HandsOfWork.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public override async Task CadastrarAsync(CategoriaDoProduto entity)
        {
            var model = _mapper.Map<CategoriaDoProduto, CategoriaDoProdutoModel>(entity);
            await _context.CategoriaDoProduto.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public override async Task EditarAsync(CategoriaDoProduto entity)
        {
            var model = _mapper.Map<CategoriaDoProduto, CategoriaDoProdutoModel>(entity);
            _context.CategoriaDoProduto.Update(model);
            await _context.SaveChangesAsync();
        }

        public override async Task ExcluirAsync(int id)
        {
            _context.CategoriaDoProduto.Remove(new CategoriaDoProdutoModel { Id = id });
            await _context.SaveChangesAsync();
        }

        public override async Task<IEnumerable<CategoriaDoProduto>> ListarAsync()
        {
            var models = await _context.CategoriaDoProduto.ToListAsync();
            var categorias = _mapper.Map<IEnumerable<CategoriaDoProdutoModel>, IEnumerable<CategoriaDoProduto>>(models);
            return categorias;
        }

        public override async Task<CategoriaDoProduto> ObterPorIdAsync(int id)
        {
            var model = await _context.CategoriaDoProduto.FirstOrDefaultAsync(x => x.Id == id);
            var categoria = _mapper.Map<CategoriaDoProdutoModel, CategoriaDoProduto>(model);
            return categoria;
        }
    }
}