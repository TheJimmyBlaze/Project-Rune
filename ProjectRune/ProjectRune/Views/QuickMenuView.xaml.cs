using ProjectRune.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static ProjectRune.ViewModels.QuickMenuViewModel;

namespace ProjectRune.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickMenuView : ContentView, INotifyPropertyChanged
    {
        public static BindableProperty ActiveMenuButtonProperty =
            BindableProperty.Create("ActiveMenuButton",
                                    typeof(QuickMenuButtons),
                                    typeof(QuickMenuView));

        public QuickMenuButtons ActiveMenuButton
        {
            get
            {
                if(BindingContext is QuickMenuViewModel model)
                    return model.ActiveMenuButton;
                return QuickMenuButtons.Nothing;
            }
        }

        public QuickMenuView()
        {
            InitializeComponent();

            if (BindingContext is QuickMenuViewModel model)
                model.ActiveMenuButtonChanged += delegate { OnPropertyChanged(nameof(ActiveMenuButton)); };
        }
    }
}