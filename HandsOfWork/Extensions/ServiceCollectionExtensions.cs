using HandsOfWork.Forms.CategoriaDeProdutos;
using HandsOfWork.Forms.Clientes;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddForms(this IServiceCollection services)
        {
            services.AddScoped<FormMenu>();
            services.AddScoped<FormListagemDeClientes>();
            services.AddScoped<FormListagemDeCategoriaDeProduto>();
            services.AddScoped<FormCadastroCategoriaDeProduto>();
            return services;
        }
    }
}