using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.About;

public partial class AboutModel : ObservableObject
{
    [ObservableProperty] private AboutOrganizationModel _aboutOrganization;

    [ObservableProperty] private GetInTouchModel _getInTouch;
}