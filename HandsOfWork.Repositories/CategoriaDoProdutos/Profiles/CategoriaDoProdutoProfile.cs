using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.CategoriaDoProdutos.Converters;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Profiles
{
    public class CategoriaDoProdutoProfile : Profile
    {
        public CategoriaDoProdutoProfile()
        {
            CreateMap<CategoriaDoProduto, CategoriaDoProdutoModel>()
                .ConvertUsing<CategoriaDoProdutoConverter>();
        }
    }
}