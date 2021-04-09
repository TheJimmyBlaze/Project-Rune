using ProjectRune.Pages;
using ProjectRune.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("runescape_uf.ttf", Alias = "Runescape")]
namespace project_rune
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            DependencyService.Register<NavigationService>();

            DependencyService.Get<NavigationService>().Initialize();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
