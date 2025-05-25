using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Statistics
{
    public partial class StatisticModel : BaseModel
    {
        [ObservableProperty] private string _icon;

        [ObservableProperty] private string _value;
    }
}
