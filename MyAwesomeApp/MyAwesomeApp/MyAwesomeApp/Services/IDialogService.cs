using System.Threading.Tasks;

namespace MyAwesomeApp.Services
{
    internal interface IDialogService
    {
        Task DisplayDialogAsync(string title, string message, string cancel);
    }
}