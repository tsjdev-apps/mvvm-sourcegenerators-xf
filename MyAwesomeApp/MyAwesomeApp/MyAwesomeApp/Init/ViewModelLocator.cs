using Microsoft.Extensions.DependencyInjection;
using MyAwesomeApp.ViewModels;

namespace MyAwesomeApp.Init
{
    internal class ViewModelLocator
    {
        public MainPageViewModel MainPageViewModel
           => Bootstrapper.ServiceProvider.GetService<MainPageViewModel>();
    }
}
