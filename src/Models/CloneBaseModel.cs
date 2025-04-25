using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models;

public partial class CloneBaseModel : BaseModel
{
    [ObservableProperty] private string _name;
    public override string SearchValue => Name;
}