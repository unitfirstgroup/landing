using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Services;

public partial class ServiceModel : ObservableObject
{
    [ObservableProperty] private string _description;
    [ObservableProperty] private string _image;
    [ObservableProperty] private string _name;
    [ObservableProperty] private string _url;
    [ObservableProperty] private string _urlText;
}