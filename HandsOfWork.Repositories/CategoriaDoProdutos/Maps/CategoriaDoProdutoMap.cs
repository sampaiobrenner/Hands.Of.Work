using HandsOfWork.Repositories.CategoriaDoProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Maps
{
    public class CategoriaDoProdutoMap : IEntityTypeConfiguration<CategoriaDoProdutoModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaDoProdutoModel> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao).IsRequired();
        }
    }
}