using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAwesomeApp.Services
{
    internal class DialogService : IDialogService
    {
        public async Task DisplayDialogAsync(string title, string message, string cancel)
            => await Application.Current.MainPage.DisplayAlert(title, message, cancel);
    }
}
