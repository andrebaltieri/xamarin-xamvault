using Xamarin.Forms;
using XamVault.ViewModels;

namespace XamVault.Views
{
    public partial class CreatePasswordPage : ContentPage
    {
        public CreatePasswordPage()
        {
            InitializeComponent();
            BindingContext = new CreatePasswordViewModel(Navigation);
        }
    }
}
