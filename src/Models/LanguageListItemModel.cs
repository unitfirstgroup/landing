using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models
{
    public partial class LanguageListItemModel : ObservableObject
    {
        [ObservableProperty] private string _language;
        [ObservableProperty] private string _imageSource;
    }
}
