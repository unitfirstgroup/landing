using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels;

public abstract partial class MultipleItemsViewModelBase<TItem>(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<TItem> searchService,
        IDataService<TItem> dataService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager,
        localizer) where TItem : BaseModel
{
    protected List<TItem> _items;
    protected List<TagModel> _tags;

    public override Task OnInitializedAsync()
    {
        _items = dataService.LoadData();
        _tags = dataService.LoadTags();

        return base.OnInitializedAsync();
    }
}