using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class SearchService<T> : ISearchService<T> where T : IValueTagsSearchService
{
    public List<T> Search(List<T> items, FilterModel filter)
    {
        var list = new List<T>();
        var selectedTags = filter.Tags
            .Where(x => x.Select is { IsSelected: true }).Distinct();

        var isTagSelected = selectedTags.Any();
        var isSearchEmpty = string.IsNullOrEmpty(filter.SearchModel.Value);

        if (isSearchEmpty && isTagSelected == false)
            list.AddRange(items);
        else
            foreach (var blogModel in items)
                if (!isSearchEmpty)
                {
                    if (!blogModel.Value.Contains(filter.SearchModel.Value))
                        continue;

                    if (selectedTags.Any())
                    {
                        if (selectedTags.Any(enabledTag => blogModel.TagModels.Any(x => x.TagName == enabledTag.TagName)))
                            list.Add(blogModel);
                    }
                    else
                    {
                        list.Add(blogModel);
                    }
                }
                else
                {
                    if (selectedTags.Any(enabledTag => blogModel.TagModels.Any(x => x.TagName == enabledTag.TagName)))
                        list.Add(blogModel);
                }

        return list;
    }
}