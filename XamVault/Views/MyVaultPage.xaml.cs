using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamVault.ViewModels;

namespace XamVault.Views
{
    public partial class MyVaultPage : ContentPage
    {
        public MyVaultPage()
        {
            InitializeComponent();
            BindingContext = new MyVaultViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            var viewModel = ((MyVaultViewModel)BindingContext);
            if (viewModel.LoadVaultCommand.CanExecute(null))
                viewModel.LoadVaultCommand.Execute(null);
        }
    }
}
