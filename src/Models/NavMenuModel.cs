using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Components;

namespace UnitFirst.Landing.Models
{
    public partial class NavMenuModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<NavItem> _navItems;

        [ObservableProperty] private string _getStarted;

        [ObservableProperty] private ObservableCollection<LanguageListItemModel> _languages;

        [ObservableProperty] private string _selectedLanguage;

        public NavMenuModel(Theme theme)
        {
            _navItems = theme.NavItems;
            _languages = theme.Languages;
        }
    }
}
