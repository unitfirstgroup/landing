using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Layout
{
    public partial class FooterModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<Layout.FooterItemModel> _categories;

        [ObservableProperty] private string _socialNetworksDescription;

        [ObservableProperty] private string _organizationManifest;

        [ObservableProperty] private string _allRightsReserved;
    }
}
