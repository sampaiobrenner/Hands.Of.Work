using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.Produtos.Models;

namespace HandsOfWork.Repositories.Produtos.Converters
{
    public class ProdutoToProdutoModelConverter : ITypeConverter<Produto, ProdutoModel>
    {
        public ProdutoModel Convert(Produto source, ProdutoModel destination, ResolutionContext context)
        {
            if (source is null) return default;

            if (destination is null)
                destination = new ProdutoModel();

            destination.Id = source.Id;
            destination.Descricao = source.Descricao;
            destination.CategoriaDoProdutoId = source.CategoriaDoProduto.Id;

            return destination;
        }
    }
}