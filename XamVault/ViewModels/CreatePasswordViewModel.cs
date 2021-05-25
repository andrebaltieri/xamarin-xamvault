using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamVault.ViewModels
{
    public class CreatePasswordViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public Command SavePasswordCommand { get; set; }

        public CreatePasswordViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SavePasswordCommand = new Command(async () => await SavePassword());
        }

        async Task SavePassword()
        {
            IsBusy = true;
            await Task.Delay(3000);
            await Navigation.PopAsync();
        }
    }
}

