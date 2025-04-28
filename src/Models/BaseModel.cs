using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Models
{
    public abstract partial class BaseModel : ObservableObject, IValueTagsSearchService
    {
        [ObservableProperty] private string _name;

        [ObservableProperty] private string _description;

        [ObservableProperty] private ObservableCollection<TagModel> _tags;
        public virtual string SearchValue => Name;
    }
}
