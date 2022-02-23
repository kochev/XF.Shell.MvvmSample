using Xamarin.Forms.Xaml;
using XamarinFormsShell.Navigation;

namespace XamarinFormsShell.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : MvvmContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        protected override string NavigationRoute => NavigationRoutes.AboutPage;
    }
}