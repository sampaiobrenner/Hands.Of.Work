using AutoMapper;
using HandsOfWork.Entities;
using HandsOfWork.Repositories.CategoriaDoProdutos.Models;
using HandsOfWork.Repositories.Produtos.Models;

namespace HandsOfWork.Repositories.Produtos.Converters
{
    public class ProdutoModelToProdutoConverter : ITypeConverter<ProdutoModel, Produto>
    {
        public Produto Convert(ProdutoModel source, Produto destination, ResolutionContext context)
        {
            if (source is null) return default;

            if (destination is null)
                destination = new Produto();

            destination.Id = source.Id;
            destination.Descricao = source.Descricao;
            destination.CategoriaDoProduto = context.Mapper.Map<CategoriaDoProdutoModel, CategoriaDoProduto>(source.CategoriaDoProduto);

            return destination;
        }
    }
}