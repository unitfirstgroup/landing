using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared
{
    public partial class TagModel : UnitFirstModel
    {
        [ObservableProperty] private string _tagName;
    }
}
