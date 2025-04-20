using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Models
{
    public partial class MultipleItemsModelBase<TItem> : ObservableObject where TItem : BaseModel
    {
        [ObservableProperty] private ObservableCollection<TItem> _filtered;
        [ObservableProperty] private FilterModel _filter;
    }
}
