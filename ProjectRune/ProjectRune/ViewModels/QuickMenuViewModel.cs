using ProjectRune.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectRune.ViewModels
{
    public class QuickMenuViewModel : ViewModelBase
    {
        public enum QuickMenuButtons
        {
            Nothing,
            Skills,
            Inventory,
            Quests,
            Hamburger
        }

        private QuickMenuButtons activeMenuButton = QuickMenuButtons.Skills;
        public QuickMenuButtons ActiveMenuButton
        {
            get { return activeMenuButton; }
            set { SetProperty(ref activeMenuButton, value, onChanged: delegate { OnActiveMenuButtonChanged(); }); }
        }

        public ICommand SetActiveMenuButton => new Command<QuickMenuButtons>(active => ActiveMenuButton = active);
        public EventHandler ActiveMenuButtonChanged;

        private void OnActiveMenuButtonChanged() => ActiveMenuButtonChanged.Invoke(this, null);
    }
}
