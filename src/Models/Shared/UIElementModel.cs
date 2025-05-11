using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared
{
    public partial class UIElementModel : ObservableObject
    {
        [ObservableProperty] private bool _isHide;
        [ObservableProperty] private bool _onFocus;
        [ObservableProperty] private bool _isSelected;
    }
}
