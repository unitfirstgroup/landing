using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.About;

public partial class AboutModel : ObservableObject
{
    [ObservableProperty] private string _socialNetworksDescription;
}