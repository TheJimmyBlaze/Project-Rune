using ProjectRune.Models;
using ProjectRune.Models.ItemModels;
using ProjectRune.Services;
using ProjectRune.Utils;
using ProjectRune.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using static ProjectRune.Services.NavigationService;

namespace ProjectRune.ViewModels
{
    public class InventoryViewModel : ViewModelBase
    {
        public bool DisplayInventoryView { get => navService.ActiveNavigationSheet == NavigationSheet.Inventory; }

        public InventoryService InventoryService { get => DependencyService.Get<InventoryService>(); }

        public InventoryViewModel()
        {
            navService.ActiveNavigationSheetChanged += delegate { OnPropertyChanged(nameof(DisplayInventoryView)); };
        }
    }
}
