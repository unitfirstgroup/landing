using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models;

public partial class Theme : ObservableObject
{
    [ObservableProperty] private string _organization;
    [ObservableProperty] private string _logo;
    [ObservableProperty] private ObservableCollection<NavItem> _navItems;
    [ObservableProperty] private string _dark;
    [ObservableProperty] private bool _isLogged;
}