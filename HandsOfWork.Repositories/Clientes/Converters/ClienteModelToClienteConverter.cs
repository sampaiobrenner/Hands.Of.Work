using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Clientes.Models;
using System;

namespace HandsOfWork.Repositories.Clientes.Converters
{
    public class ClienteModelToClienteConverter : ITypeConverter<ClienteModel, Cliente>
    {
        public Cliente Convert(ClienteModel source, Cliente destination, ResolutionContext context)
        {
            if (source is null) return default;

            if (destination is null)
                destination = new Cliente();

            destination.Id = source.Id;
            destination.Nome = source.Nome;

            return destination;
        }
    }
}
