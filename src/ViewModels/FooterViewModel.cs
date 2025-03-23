using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public partial class FooterViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager,
        IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    [ObservableProperty]
    private FooterModel _model;

    public override Task OnInitializedAsync()
    {
        Model = new FooterModel
        {
            SocialNetworksDescription = localizer["SOCIAL_NETWORKS_DESC"].Value,
            OrganizationManifest = localizer["ORGANIZATION_MANIFEST"].Value
        };

        return base.OnInitializedAsync();
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}