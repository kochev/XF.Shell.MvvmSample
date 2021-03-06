using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsShell.Navigation;

namespace XamarinFormsShell.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginOptionsPage : MvvmContentPage
    {
        public LoginOptionsPage()
        {
            InitializeComponent();
        }

        protected override string NavigationRoute => NavigationRoutes.LoginOptionsPage;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.FadeTo(1);
        }
    }
}