using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Prism.Commands;
using XamarinFormsShell.Models;
using XamarinFormsShell.Navigation;

namespace XamarinFormsShell.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private string _title;

        public HomeViewModel()
        {
            NavigateToItemPageCommand = new DelegateCommand(NavigateToItemPage);
            NavigateToLoginCommand = new DelegateCommand(NavigateToLoginPage);
            Title = "Home Page";

            People = new ObservableCollection<Person>
            {
                new Person {Name = "Person 1"},
                new Person {Name = "Person 2"}
            };
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }


        public ObservableCollection<Person> People { get; }

        public ICommand NavigateToItemPageCommand { get; }
        public ICommand NavigateToLoginCommand { get; }

        private void NavigateToItemPage()
        {
            var id = "123";
            var args = new Dictionary<string, string>
            {
                {NavigationParameters.Id, id}
            };

            Navigation.NavigateToAsync(NavigationRoutes.ItemPage, args);
        }

        private void NavigateToLoginPage()
        {
            Navigation.NavigateToAsync(NavigationRoutes.LoginPage, options: new NavigationOptions(true));
        }
    }
}