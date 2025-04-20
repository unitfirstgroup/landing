using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Interfaces;

public interface IValueTagsSearchService
{
    public string Value { get; }

    public IEnumerable<TagModel> TagModels { get; }
}