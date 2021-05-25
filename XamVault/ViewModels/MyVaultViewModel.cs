using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamVault.Models;
using XamVault.Views;

namespace XamVault.ViewModels
{
    public class MyVaultViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public ObservableCollection<VaultItem> Items { get; set; }
        public Command LoadVaultCommand { get; set; }
        public Command NavigateToCreatePasswordPageCommand { get; set; }

        public MyVaultViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Items = new ObservableCollection<VaultItem>();
            LoadVaultCommand = new Command(async () => await LoadVaultAsync());
            NavigateToCreatePasswordPageCommand = new Command(async () => await NavigateToCreatePasswordPage());
        }

        async Task LoadVaultAsync()
        {
            IsBusy = true;
            Items.Clear();

            Items.Add(new VaultItem("Facebook"));
            await Task.Delay(100);
            Items.Add(new VaultItem("Twitter"));
            await Task.Delay(280);
            Items.Add(new VaultItem("Twitch"));
            await Task.Delay(320);
            Items.Add(new VaultItem("Discord"));
            await Task.Delay(70);
            Items.Add(new VaultItem("Instagram"));
            await Task.Delay(575);
            Items.Add(new VaultItem("LinkedIn"));
            await Task.Delay(298);
            IsBusy = false;
        }

        async Task NavigateToCreatePasswordPage()
        {
            IsBusy = true;
            await Navigation.PushAsync(new CreatePasswordPage());
        }
    }
}
