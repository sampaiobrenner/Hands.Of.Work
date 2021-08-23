using HandsOfWork.Entities;
using HandsOfWork.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HandsOfWork.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICrudService<CategoriaDoProduto, Guid>, CategoriaDoProdutoService>();
            return services;
        }
    }
}