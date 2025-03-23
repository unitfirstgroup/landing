using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models;

public partial class FooterCategoryItem : ObservableObject
{
    [ObservableProperty] private string _name;
}