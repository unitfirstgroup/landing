using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models
{
    public partial class WallPaperModel : ObservableObject
    {
        [ObservableProperty] private string _startUsingText;
        [ObservableProperty] private string _subscribeText;
        [ObservableProperty] private string _joinText;
    }
}
