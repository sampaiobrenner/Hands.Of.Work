using AutoMapper;
using HandsOfWork.Extensions;
using HandsOfWork.Repositories.CategoriaDoProdutos.Profiles;
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
                .AddServices();

            // Auto Mapper
            var mapperConfig = new MapperConfiguration(mc => { mc.AddProfile(new CategoriaDoProdutoProfile()); });
            services.AddSingleton(mapperConfig.CreateMapper());

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form1 = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}