using ProjectRune.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static ProjectRune.Services.NavigationService;

namespace ProjectRune.ViewModels
{
    public class QuickMenuViewModel : ViewModelBase
    {
        public NavigationSheet ActiveNavigationSheet { get => navService.ActiveNavigationSheet; }
        public ICommand SetActiveNavigationSheet => new Command<NavigationSheet>(active => navService.ActiveNavigationSheet = active);

        public QuickMenuViewModel()
        {
            navService.ActiveNavigationSheetChanged += delegate { OnPropertyChanged(nameof(ActiveNavigationSheet)); };
        }
    }
}
