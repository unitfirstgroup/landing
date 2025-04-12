using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared;

public partial class FilterModel : UnitFirstModel
{
    [ObservableProperty] private SearchModel _searchModel;

    [ObservableProperty] private ObservableCollection<TagModel> _tags;
}