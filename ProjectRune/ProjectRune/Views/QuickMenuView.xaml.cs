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
        public QuickMenuView()
        {
            InitializeComponent();
        }
    }
}