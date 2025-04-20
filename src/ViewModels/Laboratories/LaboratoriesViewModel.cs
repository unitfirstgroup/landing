using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Laboratories;

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
    [RelayCommand]
    public void GetDetails()
    {
        Console.WriteLine("Get Details");
    }
}