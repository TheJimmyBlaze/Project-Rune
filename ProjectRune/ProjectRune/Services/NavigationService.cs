using ProjectRune.Pages;
using ProjectRune.Services.Events;
using System;
using Xamarin.Forms;

namespace ProjectRune.Services
{
    public class NavigationService
    {
        public enum NavigationSheet
        {
            Action,
            Skills,
            Inventory,
            Equipment,
            Settings
        }

        private NavigationSheet activeNavigationSheet = NavigationSheet.Skills;
        public NavigationSheet ActiveNavigationSheet
        {
            get => activeNavigationSheet;
            set
            {
                NavigationSheet previousSheet = activeNavigationSheet;
                activeNavigationSheet = value;
                OnActiveNavigationSheetChanged(previousSheet);
            }
        }

        public bool DisplayQuickAction { get => ShouldDisplayQuickAction(activeNavigationSheet); }

        public bool ShouldDisplayQuickAction(NavigationSheet activeSheet)
        {
            return activeSheet == NavigationSheet.Skills ||
                activeSheet == NavigationSheet.Inventory ||
                activeSheet == NavigationSheet.Equipment;
        }

        public EventHandler<NavigationSheetChangedEventArgs> ActiveNavigationSheetChanged;
        private void OnActiveNavigationSheetChanged(NavigationSheet previousSheet)
        {
            NavigationSheetChangedEventArgs args = new NavigationSheetChangedEventArgs
            {
                PreviousSheet = previousSheet,
                ActiveSheet = activeNavigationSheet
            };
            
            ActiveNavigationSheetChanged?.Invoke(this, args);
        }

        public void Initialize()
        {
            if (Application.Current.MainPage == null)
                Application.Current.MainPage = new MainPage();
        }
    }
}
