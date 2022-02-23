using System.Windows.Input;
using Prism.Commands;

namespace XamarinFormsShell.ViewModels
{
    public class LoginOptionsViewModel : ViewModelBase
    {
        private string _password;

        private string _username;

        public LoginOptionsViewModel()
        {
            SelectOptionCommand = new DelegateCommand(SelectOption);
            BackToLoginCommand = new DelegateCommand(GoBackToLogin);
        }


        public ICommand SelectOptionCommand { get; }

        public ICommand BackToLoginCommand { get; }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private void SelectOption()
        {
            Navigation.GoBackAsync(true);
        }

        private void GoBackToLogin()
        {
            Navigation.GoBackAsync();
        }
    }
}