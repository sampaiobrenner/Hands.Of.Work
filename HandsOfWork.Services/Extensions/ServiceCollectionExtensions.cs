using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICrudService<CategoriaDoProduto, int>, CategoriaDoProdutoService>();
            services.AddScoped<ICrudService<Cliente, int>, ClienteService>();
            services.AddScoped<ICrudService<Produto, int>, ProdutoService>();
            return services;
        }
    }
}