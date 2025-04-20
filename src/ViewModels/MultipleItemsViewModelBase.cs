using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Collections.ObjectModel;
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

    [ObservableProperty] private MultipleItemsModelBase<TItem> _model;

    public override Task OnInitializedAsync()
    {
        _items = dataService.LoadData();
        _tags = dataService.LoadTags();

        _model = new MultipleItemsModelBase<TItem>()
        {
            Filter = new FilterModel()
            {
                Dark = Theme.Dark,
                Tags = new ObservableCollection<TagModel>(_tags),
                SearchModel = new SearchModel() { RaiseSearchCommand = SearchCommand }
            },
            Filtered = new ObservableCollection<TItem>(_items)
        };

        return base.OnInitializedAsync();
    }

    public void UpdateDataGrid(IEnumerable<TItem> filtered)
    {
        Model.Filtered.Clear();
        foreach (var laboratoryModel in filtered) Model.Filtered.Add(laboratoryModel);
        NotifyStateChanged();
    }

    [RelayCommand]
    public void Search()
    {
        var filtered = searchService.Search(_items, Model.Filter);

        UpdateDataGrid(filtered);
    }
}