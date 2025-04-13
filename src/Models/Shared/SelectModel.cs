using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared
{
    public partial class SelectModel : ObservableObject
    {
        [ObservableProperty] private bool _isSelected;
    }
}
