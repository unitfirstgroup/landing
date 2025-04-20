using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Interfaces;

public interface ISearchService<T> where T : IValueTagsSearchService
{
    List<T> Search(List<T> items, FilterModel filter);
}