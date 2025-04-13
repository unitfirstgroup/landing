using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared
{
    public partial class TagModel : ObservableObject
    {
        public TagModel()
        {
            Select = new SelectModel();
        }
        
        [ObservableProperty] private string _tagName;

        [ObservableProperty] private SelectModel _select;
    }
}
