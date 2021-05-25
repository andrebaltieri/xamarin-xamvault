using System.Threading.Tasks;
using Xamarin.Forms;
using XamVault.Views;

namespace XamVault.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public Command GoogleLoginCommand { get; set; }

        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
            GoogleLoginCommand = new Command(async () => await GoogleLoginAsync());
        }

        async Task GoogleLoginAsync()
        {
            IsBusy = true;
            await Task.Delay(3000);
            await Navigation.PushAsync(new MyVaultPage());
        }
    }
}