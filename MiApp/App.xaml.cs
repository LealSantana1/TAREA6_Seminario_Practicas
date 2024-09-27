using MiApp.Controllers;
using MiApp.Services;
using SQLite;
using MiApp.Views;

namespace MiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
