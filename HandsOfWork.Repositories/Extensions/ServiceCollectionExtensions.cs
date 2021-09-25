using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.CategoriaDoProdutos;
using HandsOfWork.Repositories.Clientes;
using HandsOfWork.Repositories.Contexts;
using HandsOfWork.Repositories.Produtos;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Repositories.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<HandsOfWorkContext>();
            services.AddScoped<ICrudRepository<Cliente, int>, ClienteRepository>();
            services.AddScoped<ICrudRepository<CategoriaDoProduto, int>, CategoriaDoProdutoRepository>();
            services.AddScoped<ICrudRepository<Produto, int>, ProdutoRepository>();
            return services;
        }
    }
}