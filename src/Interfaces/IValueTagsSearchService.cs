using System.Collections.ObjectModel;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Interfaces;

public interface IValueTagsSearchService
{
    public string SearchValue { get; }

    public ObservableCollection<TagModel> Tags { get; }
}