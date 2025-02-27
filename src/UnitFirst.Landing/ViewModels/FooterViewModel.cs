using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using UnitFirst.Landing.Interfaces;

namespace UnitFirst.Landing.ViewModels;

public partial class FooterViewModel : ViewModelBase
{
    public FooterViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager) : base(
        applicationStateService, applicationThemeService, navigationManager)
    {
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}