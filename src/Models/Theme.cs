using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Layout;

namespace UnitFirst.Landing.Models;

public partial class Theme : ObservableObject
{
    [ObservableProperty] private string _organization;
    [ObservableProperty] private string _logo;
    [ObservableProperty] private ObservableCollection<NavItem> _navItems;
    [ObservableProperty] private string _dark;
    [ObservableProperty] private bool _isLogged;
    [ObservableProperty] private ObservableCollection<LanguageListItemModel> _languages;
    [ObservableProperty] private string _selectedLanguage;
    [ObservableProperty] private string _hideTherms;
}