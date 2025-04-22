using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Blogs;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels.Blogs;

public partial class BlogsViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<BlogModel> searchService,
        IDataService<BlogModel> dataService)
    : MultipleItemsViewModelBase<BlogModel>(applicationStateService, applicationThemeService, navigationManager, localizer, searchService, dataService)
{
    [ObservableProperty] private MultipleItemsModelBase<BlogModel> _model;
    
    public override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _model = new MultipleItemsModelBase<BlogModel>()
        {
            Filter = new FilterModel()
            {
                Dark = Theme.Dark,
                Tags = new ObservableCollection<TagModel>(_tags),
                SearchModel = new SearchModel()
                {
                    Placeholder = "Search blog via input key words...",
                    RaiseSearchCommand = SearchCommand
                }
            },
            Filtered = new ObservableCollection<BlogModel>(_items)
        };
    }


    [RelayCommand]
    public void GetDetails()
    {
    }

    [RelayCommand]
    public void Search()
    {
        var filtered = searchService.Search(_items, Model.Filter);

        UpdateDataGrid(filtered);
    }

    public void UpdateDataGrid(IEnumerable<BlogModel> filtered)
    {
        Model.Filtered.Clear();
        foreach (var item in filtered) Model.Filtered.Add(item);
        NotifyStateChanged();
    }
}