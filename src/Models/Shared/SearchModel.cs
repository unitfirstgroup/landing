using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace UnitFirst.Landing.Models.Shared;

public partial class SearchModel : ObservableObject
{
    [ObservableProperty] private string _placeholder;

    [ObservableProperty] private string _value;

    [ObservableProperty] private IRelayCommand _raiseSearchCommand;
}