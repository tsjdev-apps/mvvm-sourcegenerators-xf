using Microsoft.Extensions.DependencyInjection;
using MyAwesomeApp.Services;
using MyAwesomeApp.ViewModels;
using System;

namespace MyAwesomeApp.Init
{
    internal static class Bootstrapper
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Init()
        {
            var serviceCollection = new ServiceCollection();

            ServiceProvider = serviceCollection
                .ConfigureServices()
                .ConfigureViewModels()
                .BuildServiceProvider();
        }

        private static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            // add services
            services.AddSingleton<IDialogService, DialogService>();

            return services;
        }

        private static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            // add viewmodels
            services.AddSingleton<MainPageViewModel>();

            return services;
        }
    }
}
