using Xamarin.Forms;
using XamVault.Views;

[assembly: ExportFont("Comfortaa.ttf", Alias = "Comfortaa")]
[assembly: ExportFont("Comfortaa-Bold.ttf", Alias = "ComfortaaBold")]
[assembly: ExportFont("Icofont.ttf", Alias = "IcoFont")]

namespace XamVault
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
