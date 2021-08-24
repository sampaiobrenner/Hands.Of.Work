using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using HandsOfWork.Repositories.CategoriaDoProdutos;
using HandsOfWork.Repositories.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Repositories.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<HandsOfWorkContext>();

            services.AddScoped<ICrudRepository<CategoriaDoProduto, int>, CategoriaDoProdutoRepository>();
            return services;
        }
    }
}