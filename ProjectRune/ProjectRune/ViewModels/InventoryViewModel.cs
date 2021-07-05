using ProjectRune.Models;
using ProjectRune.Services;
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

        public List<ItemStack> Items { get => inventoryService.Contents.Values.ToList(); }

        private readonly InventoryService inventoryService = DependencyService.Get<InventoryService>();

        public ICommand AddTestItem => new Command(delegate() { inventoryService.AddItem(new Item("bronze_ingot")); });

        public InventoryViewModel()
        {
            navService.ActiveNavigationSheetChanged += delegate { OnPropertyChanged(nameof(DisplayInventoryView)); };
            inventoryService.ContentsChanged += delegate { OnPropertyChanged(nameof(Items)); };
        }
    }
}
