using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Cases;

public partial class CaseModel : BaseModel
{
    [ObservableProperty] private string _image;
    [ObservableProperty] private string _url;
    [ObservableProperty] private string _urlText;
}