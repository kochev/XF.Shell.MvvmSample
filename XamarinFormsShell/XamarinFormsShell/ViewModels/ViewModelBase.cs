using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Mvvm;
using XamarinFormsShell.Navigation;

namespace XamarinFormsShell.ViewModels
{
    public class ViewModelBase : BindableBase, IViewModel
    {
        protected INavigationService Navigation => App.Navigation;

        public virtual Task InitializeAsync(Dictionary<string, string> args)
        {
            return Task.CompletedTask;
        }
    }
}