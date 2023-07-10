using Invest4me.ViewModels;
using Invest4me.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Invest4me
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
