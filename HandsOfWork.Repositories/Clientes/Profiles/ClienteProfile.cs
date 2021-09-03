using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Clientes.Converters;
using HandsOfWork.Repositories.Clientes.Models;

namespace HandsOfWork.Repositories.Clientes.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteModel>()
                .ConvertUsing<ClienteToClienteModelConverter>();

            CreateMap<ClienteModel, Cliente>()
                .ConvertUsing<ClienteModelToClienteConverter>();
        }
    }
}
