using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Characteristic;

public partial class CharacteristicComponentModel : BaseModel
{
    [ObservableProperty] private string _title;
    [ObservableProperty] private ObservableCollection<CharacteristicModel> _characteristicItems;
    [ObservableProperty] private string _dark;
}