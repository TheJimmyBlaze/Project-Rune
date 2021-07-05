using ProjectRune.Services;
using Xamarin.Forms;

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
            DependencyService.Register<InventoryService>();

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
