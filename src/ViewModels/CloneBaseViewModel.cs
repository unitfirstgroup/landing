using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels;

public partial class BaseCloneViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<BaseModel> searchService,
        IDataService<BaseModel> dataService)
    : MultipleItemsViewModelBase<BaseModel>(applicationStateService, applicationThemeService, navigationManager,
        localizer, searchService, dataService)
{
    [ObservableProperty] private MultipleItemsModelBase<BaseModel> _model;

    public override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _model = new MultipleItemsModelBase<BaseModel>
        {
            Filter = new FilterModel
            {
                Dark = Theme.Dark,
                Tags = new ObservableCollection<TagModel>(_tags),
                SearchModel = new SearchModel
                {
                    RaiseSearchCommand = SearchCommand,
                    Placeholder = "Search digital laboratory for your requirements..."
                }
            },
            Filtered = new ObservableCollection<BaseModel>(_items)
        };
    }

    [RelayCommand]
    public void GetDetails()
    {
        Console.WriteLine("Get Details");
    }

    [RelayCommand]
    public void Search()
    {
        var filtered = searchService.Search(_items, Model.Filter);

        UpdateDataGrid(filtered);
    }

    public void UpdateDataGrid(IEnumerable<BaseModel> filtered)
    {
        Model.Filtered.Clear();
        foreach (var item in filtered) Model.Filtered.Add(item);
        NotifyStateChanged();
    }
}