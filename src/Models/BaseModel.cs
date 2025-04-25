using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Models
{
    public abstract partial class BaseModel : ObservableObject, IValueTagsSearchService
    {
        [ObservableProperty] private ObservableCollection<TagModel> _tags;
        public abstract string SearchValue { get; }
    }
}
