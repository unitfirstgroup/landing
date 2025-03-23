using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UnitFirst.Landing.Models
{
    public partial class FooterModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<FooterItemModel> _categories;

        [ObservableProperty] private string _socialNetworksDescription;

        [ObservableProperty] private string _organizationManifest;

        [ObservableProperty] private string _allRightsReserved;
    }
}
