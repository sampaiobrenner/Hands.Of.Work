using HandsOfWork.Forms.CategoriaDeProdutos;
using HandsOfWork.Forms.Clientes;
using HandsOfWork.Forms.Produtos;
using Microsoft.Extensions.DependencyInjection;

namespace HandsOfWork.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddForms(this IServiceCollection services)
        {
            services.AddScoped<FormMenu>();
            services.AddScoped<FormListagemDeClientes>();
            services.AddScoped<FormCadastroCliente>();
            services.AddScoped<FormListagemDeCategoriaDeProduto>();
            services.AddScoped<FormCadastroCategoriaDeProduto>();
            services.AddScoped<FormListagemDeProduto>();
            services.AddScoped<FormCadastroProduto>();
            return services;
        }
    }
}