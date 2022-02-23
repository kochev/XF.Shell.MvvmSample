using System;
using Prism.Mvvm;

namespace XamarinFormsShell.Models
{
    public class Person : BindableBase
    {
        private string _id;
        private string _name;

        public Person()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}