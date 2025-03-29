using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Layout;

public partial class NavItem : ObservableObject
{
    [ObservableProperty] private string _name;
    [ObservableProperty] private string _link;
    [ObservableProperty] private string _icon;
    [ObservableProperty] private string _notification;
}