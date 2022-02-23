using System.Windows.Input;
using Prism.Commands;
using XamarinFormsShell.Navigation;

namespace XamarinFormsShell.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _password;

        private string _username;

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login);
        }

        public ICommand LoginCommand { get; }

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

        private void Login()
        {
            Navigation.NavigateToAsync(NavigationRoutes.LoginOptionsPage,
                options: new NavigationOptions(animated: false));
        }
    }
}