using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Layout;

public partial class FooterCategoryItem : ObservableObject
{
    [ObservableProperty] private string _name;
}