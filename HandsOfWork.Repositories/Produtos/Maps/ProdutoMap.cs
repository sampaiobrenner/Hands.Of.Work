using HandsOfWork.Repositories.Produtos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HandsOfWork.Repositories.Produtos.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.ToTable("produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao).IsRequired();

            builder.HasOne(x => x.CategoriaDoProduto)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.CategoriaDoProdutoId);
        }
    }
}