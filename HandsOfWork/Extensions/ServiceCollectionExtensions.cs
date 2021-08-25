﻿using HandsOfWork.Forms.CategoriaDeProdutos;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddForms(this IServiceCollection services)
        {
            services.AddScoped<FormMenu>();
            services.AddScoped<FormListagemDeCategoriaDeProduto>();
            services.AddScoped<FormCadastroCategoriaDeProduto>();
            return services;
        }
    }
}