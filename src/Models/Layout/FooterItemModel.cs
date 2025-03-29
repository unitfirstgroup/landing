using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Layout
{
    public partial class FooterItemModel : ObservableObject
    {
        [ObservableProperty] private string _category;

        [ObservableProperty] private ObservableCollection<Layout.FooterCategoryItem> _categoryItems;
    }
}
