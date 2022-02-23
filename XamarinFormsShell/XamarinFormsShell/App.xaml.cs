using Xamarin.Forms;
using Xamarin.Forms.Svg;
using Xamarin.Forms.Xaml;
using XamarinFormsShell.Core;
using XamarinFormsShell.Navigation;
using XamarinFormsShell.Pages;
using XamarinFormsShell.Services;
using XamarinFormsShell.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamarinFormsShell
{
    public partial class App : Application
    {
        public App()
        {
            var registry = new SplatDependencyRegistry();
            IoC = new SplatDependencyResolver();

            RegisterDependencies(registry);

            InitializeComponent();

            SvgImageSource.RegisterAssembly();

            MainPage = new AppShell();

            Current.RequestedThemeChanged += (s, a) =>
            {
                // Respond to the theme change if setting is system theme
            };
        }

        public static INavigationService Navigation => IoC.Resolve<INavigationService>();

        public static IDependencyResolver IoC { get; private set; }

        private void RegisterDependencies(IDependencyRegistry registry)
        {
            registry.RegisterSingleton<NavigationService, INavigationService>();
            registry.RegisterSingleton<ThemeService, IThemeService>();

            //регистрируем к роутам их страницы (помимо root представлений)
            registry.Register<ItemPage, IView>(NavigationRoutes.ItemPage);
            registry.Register<AboutPage, IView>(NavigationRoutes.AboutPage);
            registry.Register<LoginPage, IView>(NavigationRoutes.LoginPage);
            registry.Register<LoginOptionsPage, IView>(NavigationRoutes.LoginOptionsPage);

            //регистрируем вм для путей (можно переделать на связь вм ко вью)
            registry.Register<HomeViewModel, IViewModel>(NavigationRoutes.HomePage);
            registry.Register<ItemViewModel, IViewModel>(NavigationRoutes.ItemPage);
            registry.Register<AboutViewModel, IViewModel>(NavigationRoutes.AboutPage);
            registry.Register<LoginViewModel, IViewModel>(NavigationRoutes.LoginPage);
            registry.Register<LoginOptionsViewModel, IViewModel>(NavigationRoutes.LoginOptionsPage);
            registry.Register<DiscoverViewModel, IViewModel>(NavigationRoutes.DiscoverPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}