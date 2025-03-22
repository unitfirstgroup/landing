using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace UnitFirst.Landing.Models;

public partial class IndexModel : ObservableObject
{
    [ObservableProperty] private string _hide;

    [ObservableProperty] private string _dark;

    [ObservableProperty] private ElementReference? _myTarget;

    [ObservableProperty] private string _organization;
}