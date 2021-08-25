using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Converters
{
    public class CategoriaDoProdutoModelToCategoriaDoProdutoConverter : ITypeConverter<CategoriaDoProdutoModel, CategoriaDoProduto>
    {
        public CategoriaDoProduto Convert(CategoriaDoProdutoModel source, CategoriaDoProduto destination, ResolutionContext context)
        {
            if (source is null) return default;

            if (destination is null)
                destination = new CategoriaDoProduto();

            destination.Id = source.Id;
            destination.Descricao = source.Descricao;

            return destination;
        }
    }
}