using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.About;

namespace UnitFirst.Landing.ViewModels.About;

public partial class AboutViewModel : ViewModelBase
{
    [ObservableProperty] private AboutModel _model;

    public AboutViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager) : base(
        applicationStateService, applicationThemeService, navigationManager)
    {
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}