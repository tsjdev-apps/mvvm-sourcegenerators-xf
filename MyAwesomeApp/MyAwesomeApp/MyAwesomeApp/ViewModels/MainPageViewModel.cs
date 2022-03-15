using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyAwesomeApp.Services;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MyAwesomeApp.ViewModels
{
    [INotifyPropertyChanged]
    internal partial class MainPageViewModel
    {
        private readonly IDialogService _dialogService;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        [AlsoNotifyCanExecuteFor(nameof(GreetUserCommand))]
        private string _firstName;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(FullName))]
        [AlsoNotifyCanExecuteFor(nameof(GreetUserCommand))]
        private string _lastName;

        public string FullName => $"{FirstName} {LastName}";

        public MainPageViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        private bool CanGreetUser
            => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);


        [ICommand(AllowConcurrentExecutions = false,
                    CanExecute = nameof(CanGreetUser))]
        private async Task GreetUserAsync()
        {
            await _dialogService.DisplayDialogAsync("Welcome",
                $"Welcome, {FullName}!", "OK");
        }
    }
}
