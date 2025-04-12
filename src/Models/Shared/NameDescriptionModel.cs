using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared;

public partial class NameDescriptionModel : ObservableObject
{
    [ObservableProperty] private string _description;
    [ObservableProperty] private string _name;
}