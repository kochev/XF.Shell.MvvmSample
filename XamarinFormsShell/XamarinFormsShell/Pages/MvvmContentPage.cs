using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFormsShell.ViewModels;

namespace XamarinFormsShell.Pages
{
    public abstract class MvvmContentPage : ContentPage, IView
    {
        public MvvmContentPage()
        {
            //как раз ресолвим вм для вью по роуту
            ViewModel = App.IoC.Resolve<IViewModel>(NavigationRoute);
            BindingContext = ViewModel;
        }

        public Dictionary<string, string> NavigationArgs { get; set; }

        protected abstract string NavigationRoute { get; }

        public IViewModel ViewModel { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.InitializeAsync(NavigationArgs);
        }
    }
}