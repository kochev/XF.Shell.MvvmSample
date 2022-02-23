using System.Windows.Input;
using Prism.Commands;
using XamarinFormsShell.Navigation;
using XamarinFormsShell.ViewModels;

namespace XamarinFormsShell
{
    public class AppShellViewModel : ViewModelBase
    {
        private int _currentTabIndex;

        public AppShellViewModel()
        {
            NavigateToAboutPageCommand = new DelegateCommand(NavigateToAboutPage);
        }

        public ICommand NavigateToAboutPageCommand { get; }

        public string HomeIconName => "home.svg";

        public string SearchIconName => "search.svg";

        public int CurrentTabIndex
        {
            get => _currentTabIndex;
            set => SetProperty(ref _currentTabIndex, value);
        }

        private void NavigateToAboutPage()
        {
            Navigation.NavigateToAsync(NavigationRoutes.AboutPage, options: new NavigationOptions(true));
        }
    }
}