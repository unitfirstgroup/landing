using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UnitFirst.Landing.Models
{
    public partial class FooterModel : ObservableObject
    {
        //[ObservableProperty] private ObservableCollection<NavItem> _navItems;

        [ObservableProperty] private string _socialNetworksDescription;

        [ObservableProperty] private string _organizationManifest;
    }
}
