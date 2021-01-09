using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DataWedgeDemo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            MessagingCenter.Subscribe<App, string>(this, "ScanBarcode", (sender, arg) => {
                ScanBarcode(arg);
            });

        }

        private void ScanBarcode(string arg)
        {
            Scans.Add(arg);
        }

        private ObservableCollection<string> _scan = new ObservableCollection<string>();
        public ObservableCollection<string> Scans => _scan;
    }
}
