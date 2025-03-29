using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Laboratories;

public partial class LaboratoryModel : ObservableObject
{
    [ObservableProperty] private string _description;
    [ObservableProperty] private string _image;
    [ObservableProperty] private string _name;
    [ObservableProperty] private string _url;
    [ObservableProperty] private string _urlText;
}