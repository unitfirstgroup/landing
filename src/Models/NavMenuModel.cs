using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UnitFirst.Landing.Models
{
    public partial class NavMenuModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<NavItem> _navItems;

        [ObservableProperty] private string _getStarted;

        public NavMenuModel(Theme theme)
        {
            _navItems = theme.NavItems;
        }
    }
}
