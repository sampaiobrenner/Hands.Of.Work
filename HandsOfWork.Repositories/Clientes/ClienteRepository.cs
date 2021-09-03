using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.Clientes.Models;
using HandsOfWork.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOfWork.Repositories.Clientes
{
    public class ClienteRepository : CrudRepository<Cliente, int>
    {
        private readonly HandsOfWorkContext _context;
        private readonly IMapper _mapper;

        public ClienteRepository(HandsOfWorkContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task CadastrarAsync(Cliente entity)
        {
            var model = _mapper.Map<Cliente, ClienteModel>(entity);
            await _context.Cliente.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public override async Task EditarAsync(Cliente entity)
        {
            var model = _mapper.Map<Cliente, ClienteModel>(entity);
            _context.Cliente.Update(model);
            await _context.SaveChangesAsync();
        }

        public override async Task ExcluirAsync(int id)
        {
            var model = await _context.Cliente.FirstOrDefaultAsync(x => x.Id == id);
            _context.Cliente.Remove(model);
            await _context.SaveChangesAsync();
        }

        public override async Task<IEnumerable<Cliente>> ListarAsync()
        {
            var models = await _context.Cliente.ToListAsync();
            var categorias = _mapper.Map<IEnumerable<ClienteModel>, IEnumerable<Cliente>>(models);
            return categorias;
        }

        public override async Task<Cliente> ObterPorIdAsync(int id)
        {
            var model = await _context.Cliente.FirstOrDefaultAsync(x => x.Id == id);
            var categoria = _mapper.Map<ClienteModel, Cliente>(model);
            return categoria;
        }
    }
}
