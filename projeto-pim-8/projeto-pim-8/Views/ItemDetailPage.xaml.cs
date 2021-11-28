using projeto_pim_8.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace projeto_pim_8.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}