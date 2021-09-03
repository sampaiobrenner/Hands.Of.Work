using AutoMapper;
using HandsOfWork.Extensions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Profiles;
using HandsOfWork.Repositories.Clientes.Profiles;
using HandsOfWork.Repositories.Extensions;
using HandsOfWork.Services.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace HandsOfWork
{
    public static class Program
    {
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

            var form1 = serviceProvider.GetRequiredService<FormMenu>();
            Application.Run(form1);
        }

        private static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ClienteProfile());
                mc.AddProfile(new CategoriaDoProdutoProfile());
            });
            return services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}