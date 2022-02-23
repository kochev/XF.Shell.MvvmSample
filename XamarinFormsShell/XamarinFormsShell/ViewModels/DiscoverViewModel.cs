using Xamarin.Forms;
using XamarinFormsShell.Services;

namespace XamarinFormsShell.ViewModels
{
    public class DiscoverViewModel : ViewModelBase
    {
        private bool _showDarkTheme;

        private bool _showNavBars;

        public DiscoverViewModel()
        {
            _showNavBars = true;
        }

        public bool ShowNavBars
        {
            get => _showNavBars;
            set => SetProperty(ref _showNavBars, value);
        }

        public bool ShowDarkTheme
        {
            get => _showDarkTheme;
            set
            {
                SetProperty(ref _showDarkTheme, value);
                ToggleTheme();
            }
        }

        private void ToggleTheme()
        {
            var themeService = App.IoC.Resolve<IThemeService>();
            var theme = ShowDarkTheme ? OSAppTheme.Dark : OSAppTheme.Light;
            themeService.ApplyTheme(theme);
        }
    }
}