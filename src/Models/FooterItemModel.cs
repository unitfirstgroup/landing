using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UnitFirst.Landing.Models
{
    public partial class FooterItemModel : ObservableObject
    {
        [ObservableProperty] private string _category;

        [ObservableProperty] private ObservableCollection<FooterCategoryItem> _categoryItems;
    }
}
