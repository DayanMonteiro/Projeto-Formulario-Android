using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace projeto_pim_8.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Formulário";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}