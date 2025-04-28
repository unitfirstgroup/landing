using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Laboratories;

public partial class LaboratoryModel : BaseModel
{
    [ObservableProperty] private string _image;
    [ObservableProperty] private string _url;
    [ObservableProperty] private string _urlText;
}