
using ProjectRune.Services;
using ProjectRune.Services.Events;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectRune.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickActionView : ContentView
    {
        private const int ANIMATION_DURATION = 1000;

        private NavigationService NavService { get => DependencyService.Get<NavigationService>(); }
        private RandomService Random { get => DependencyService.Get<RandomService>(); }

        public QuickActionView()
        {
            InitializeComponent();

            NavService.ActiveNavigationSheetChanged += delegate (object sender, NavigationSheetChangedEventArgs e)
            {
                if (!NavService.ShouldDisplayQuickAction(e.PreviousSheet) &&
                    NavService.ShouldDisplayQuickAction(e.ActiveSheet))
                    HandleAnimation();
            };

            HandleAnimation();
        }

        private async void HandleAnimation()
        {
            while (NavService.DisplayQuickAction)
            {
                Animation animation = new Animation();
                animation.Add(0, 1, Bounce(Chevron));

                if (Random.Next(3) == 0)
                    animation.Add(0, 0.45, Wobble(SkillIcon));
                if (Random.Next(3) == 0)
                    animation.Add(0.5, 0.95, Wobble(SkillIcon));

                animation.Commit(this, "QuickActionChildAnimations", length: ANIMATION_DURATION);

                await Task.Delay(ANIMATION_DURATION);
            }
        }

        private Animation Wobble(VisualElement target)
        {
            return new Animation
            {
                { 0, 0.3, new Animation (x => target.Rotation = x, 0, 15, Easing.CubicOut) },
                { 0.3, 0.6, new Animation (x => target.Rotation = x, 15, -15, Easing.CubicOut) },
                { 0.6, 0.8, new Animation(x => target.Rotation = x, -15, 15) },
                { 0.8, 1, new Animation (x => target.Rotation = x, 15, 0) }
            };
        }

        private Animation Bounce(VisualElement target)
        {
            return new Animation
            {
                { 0, 0.25, new Animation (x => target.TranslationY = x, 0, -2) },
                { 0.25, 0.75, new Animation (x => target.TranslationY = x, -2, 4, Easing.BounceOut) },
                { 0.75, 1, new Animation(x => target.TranslationY = x, 4, 0) }
            };
        }
    }
}