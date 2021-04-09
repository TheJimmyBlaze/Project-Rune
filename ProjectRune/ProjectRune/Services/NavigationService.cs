using ProjectRune.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjectRune.Services
{
    public class NavigationService
    {
        public enum NavigationSheet
        {
            Skills,
            Inventory,
            Quests,
            ExtendedMenu
        }

        private NavigationSheet activeNavigationSheet = NavigationSheet.Skills;
        public NavigationSheet ActiveNavigationSheet
        {
            get => activeNavigationSheet;
            set
            {
                activeNavigationSheet = value;
                OnActiveNavigationSheetChanged();
            }
        }

        public EventHandler ActiveNavigationSheetChanged;
        private void OnActiveNavigationSheetChanged() => ActiveNavigationSheetChanged?.Invoke(this, null);

        public void Initialize()
        {
            if (Application.Current.MainPage == null)
                Application.Current.MainPage = new MainPage();
        }
    }
}
