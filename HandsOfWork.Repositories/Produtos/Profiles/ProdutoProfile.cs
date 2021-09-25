using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Produtos.Converters;
using HandsOfWork.Repositories.Produtos.Models;

namespace HandsOfWork.Repositories.Produtos.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoModel>()
                .ConvertUsing<ProdutoToProdutoModelConverter>();

            CreateMap<ProdutoModel, Produto>()
               .ConvertUsing<ProdutoModelToProdutoConverter>();
        }
    }
}