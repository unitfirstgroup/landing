using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Layout;

namespace UnitFirst.Landing.ViewModels.Layouts;

public partial class NavMenuViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        IBrowserService browserService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty]
    private NavMenuModel _model;

    public override Task OnInitializedAsync()
    {
        Model = new NavMenuModel(Theme);
        Model.GetStarted = localizer["GET_STARTED"].Value;
        return base.OnInitializedAsync();
    }


    [RelayCommand]
    public void GetStarted()
    {
        browserService.ShowAlert("WBHOO");
        // navigationManager.NavigateTo("./registration");
    }

    [RelayCommand]
    public void Logout()
    {
    }

    [RelayCommand]
    public void Login()
    {
    }

    [RelayCommand]
    public void Profile()
    {
    }

    [RelayCommand]
    public void SelectLanguage(string language)
    {
    }

    public void DarkModeSwitch()
    {
        browserService.UpdateTheme();
        ApplicationThemeService.DarkModeSwitch(Theme);
    }
}