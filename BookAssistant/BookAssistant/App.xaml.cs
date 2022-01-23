using BookAssistant.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookAssistant
{
    public partial class App : Application
    {
        public static string User = "Rendy";
        public App()
        {
            InitializeComponent();

            MainPage = new ChatPage();
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
