using HandsOfWork.Entities;
using HandsOfWork.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HandsOfWork.Repositories.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICrudRepository<CategoriaDoProduto, Guid>, CategoriaDoProdutoRepository>();
            return services;
        }
    }
}