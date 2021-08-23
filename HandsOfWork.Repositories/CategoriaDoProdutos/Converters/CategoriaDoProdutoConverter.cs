using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Converters
{
    public class CategoriaDoProdutoConverter : ITypeConverter<CategoriaDoProduto, CategoriaDoProdutoModel>
    {
        public CategoriaDoProdutoModel Convert(CategoriaDoProduto source, CategoriaDoProdutoModel destination, ResolutionContext context)
        {
            if (source is null) return default;

            destination.Id = source.Id;
            destination.Descricao = source.Descricao;

            return destination;
        }
    }
}