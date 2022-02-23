using System.Windows.Input;
using Prism.Commands;

namespace XamarinFormsShell.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {
        public AboutViewModel()
        {
            CloseCommand = new DelegateCommand(Close);
        }

        public ICommand CloseCommand { get; }

        private void Close()
        {
            Navigation.GoBackAsync(true);
        }
    }
}