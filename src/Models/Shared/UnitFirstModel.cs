using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared
{
    public partial class UnitFirstModel : ObservableObject
    {
        [ObservableProperty] private bool _hide;
        [ObservableProperty] private bool _focus;
        [ObservableProperty] private bool _selected;
    }
}
