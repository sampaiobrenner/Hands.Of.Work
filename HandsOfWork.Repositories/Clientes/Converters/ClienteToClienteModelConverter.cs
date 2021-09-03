using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Clientes.Models;

namespace HandsOfWork.Repositories.Clientes.Converters
{
    public class ClienteToClienteModelConverter : ITypeConverter<Cliente, ClienteModel>
    {
        public ClienteModel Convert(Cliente source, ClienteModel destination, ResolutionContext context)
        {
            if (source is null) return default;

            if (destination is null)
                destination = new ClienteModel();

            destination.Id= source.Id;
            destination.Nome= source.Nome;

            return destination;
        }
    }
}
