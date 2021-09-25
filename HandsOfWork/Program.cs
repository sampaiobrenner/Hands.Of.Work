using AutoMapper;
using HandsOfWork.Extensions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Profiles;
using HandsOfWork.Repositories.Clientes.Profiles;
using HandsOfWork.Repositories.Extensions;
using HandsOfWork.Repositories.Produtos.Profiles;
using HandsOfWork.Services.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public static class Program
    {
        private static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ClienteProfile());
                mc.AddProfile(new CategoriaDoProdutoProfile());
                mc.AddProfile(new ProdutoProfile());
            });
            return services.AddSingleton(mapperConfig.CreateMapper());
        }

        [STAThread]
        private static void Main()
        {
            var services = new ServiceCollection()
                .AddForms()
                .AddRepositories()
                .AddServices()
                .AddAutoMapper();

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formMenu = serviceProvider.GetRequiredService<FormMenu>();
            Application.Run(formMenu);
        }
    }
}