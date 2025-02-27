using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using UnitFirst.Landing.Interfaces;

namespace UnitFirst.Landing.ViewModels;

public partial class NavMenuViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    [RelayCommand]
    public void GetStarted()
    {
        navigationManager.NavigateTo("./registration");
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
}