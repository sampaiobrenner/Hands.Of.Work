using HandsOfWork.Repositories.CategoriaDoProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace HandsOfWork.Repositories.Contexts
{
    public class HandsOfWorkContext : DbContext
    {
        public DbSet<CategoriaDoProdutoModel> CategoriaDoProduto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=hands-of-work;User Id=sa;Password=HandsOfWork1!@;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}