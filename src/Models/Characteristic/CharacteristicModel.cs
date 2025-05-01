using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Characteristic;

public partial class CharacteristicModel : BaseModel
{
    [ObservableProperty] private string _header;
    [ObservableProperty] private string _details;
    [ObservableProperty] private string _value;
    [ObservableProperty] private string _benefit;
}