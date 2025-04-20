using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Shared;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public abstract partial class MultipleItemsViewModelBase<TItem>(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<TItem> searchService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager,
    localizer) where TItem : BaseModel
{
    [ObservableProperty] private ObservableCollection<TItem> _filtered;
    [ObservableProperty] private FilterModel _filter;

    protected List<TItem> _items;

    protected List<TagModel> _tags;

    public override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    public void UpdateDataGrid(IEnumerable<TItem> filtered)
    {
        Filtered.Clear();
        foreach (var laboratoryModel in filtered)
        {
            Filtered.Add(laboratoryModel);
        }
        NotifyStateChanged();
    }

    [RelayCommand]
    public void Search()
    {
        var filtered = searchService.Search(_items, Filter);

        UpdateDataGrid(filtered);
    }

}