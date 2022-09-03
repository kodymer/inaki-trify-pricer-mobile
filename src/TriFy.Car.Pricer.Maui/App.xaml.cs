using TriFy.Car.Pricer.Views;

namespace TriFy.Car.Pricer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}