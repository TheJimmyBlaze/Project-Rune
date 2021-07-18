using System;
using static ProjectRune.Services.NavigationService;

namespace ProjectRune.Services.Events
{
    public class NavigationSheetChangedEventArgs : EventArgs
    {
        public NavigationSheet PreviousSheet { get; set; }
        public NavigationSheet ActiveSheet { get; set; }
    }
}
