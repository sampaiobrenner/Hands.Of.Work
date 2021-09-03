using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOfWork.Repositories.Clientes
{
    public class ClienteRepository : CrudRepository<Cliente, int>
    {
        public override Task CadastrarAsync(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public override Task EditarAsync(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public override Task ExcluirAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public override Task<IEnumerable<Cliente>> ListarAsync()
        {
            throw new System.NotImplementedException();
        }

        public override Task<Cliente> ObterPorIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
