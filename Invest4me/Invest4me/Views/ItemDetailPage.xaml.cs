using Invest4me.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Invest4me.Views
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