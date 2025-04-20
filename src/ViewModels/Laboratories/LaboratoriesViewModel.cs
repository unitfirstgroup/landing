using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Laboratories;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels.Laboratories;

public partial class LaboratoriesViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<LaboratoryModel> searchService,
        IDataService<LaboratoryModel> dataService)
    : MultipleItemsViewModelBase<LaboratoryModel>(applicationStateService, applicationThemeService, navigationManager,
        localizer, searchService, dataService)
{

    [ObservableProperty] private MultipleItemsModelBase<LaboratoryModel> _model;

    public override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _model = new MultipleItemsModelBase<LaboratoryModel>()
        {
            Filter = new FilterModel()
            {
                Dark = Theme.Dark,
                Tags = new ObservableCollection<TagModel>(_tags),
                SearchModel = new SearchModel()
                {
                    RaiseSearchCommand = SearchCommand,
                    Placeholder = "Search digital laboratory for your requirements..."
                }
            },
            Filtered = new ObservableCollection<LaboratoryModel>(_items)
        };
    }

    [RelayCommand]
    public void GetDetails()
    {
        Console.WriteLine("Get Details");
    }


    public void UpdateDataGrid(IEnumerable<LaboratoryModel> filtered)
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