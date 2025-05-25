using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.About;
using UnitFirst.Landing.Models.Statistics;

namespace UnitFirst.Landing.ViewModels.About;

public partial class AboutViewModel : ViewModelBase
{
    [ObservableProperty] private AboutModel _model;

    public AboutViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, 
        IStringLocalizer<App> localizer) : base(
        applicationStateService, applicationThemeService, navigationManager, localizer)
    {
        
    }

    public override Task OnInitializedAsync()
    {
        _model = new AboutModel
        {
            AboutOrganization = new AboutOrganizationModel()
            {
                Title = Localizer.GetString("ABOUT_TITLE").Value,
                Organization = Localizer.GetString("ORGANIZATION").Value,
                Main = Localizer.GetString("ABOUT_ORGANIZATION_MAIN").Value,
                Mission = Localizer.GetString("ABOUT_MISSION").Value,
                MissionDetails = Localizer.GetString("ABOUT_MISSION_DETAILS").Value,
                Statistics = new ObservableCollection<StatisticModel>(new[]
                {
                    new StatisticModel() { Name = "a", Value = "12", Icon = "images/satisfaction-rate.svg" },
                    new StatisticModel() { Name = "a", Value = "12", Icon = "images/satisfaction-rate.svg" },
                    new StatisticModel() { Name = "a", Value = "12", Icon = "images/satisfaction-rate.svg" },
                    new StatisticModel() { Name = "a", Value = "12", Icon = "images/satisfaction-rate.svg" },
                    new StatisticModel() { Name = "a", Value = "12", Icon = "images/satisfaction-rate.svg" },
                    new StatisticModel() { Name = "a", Value = "12", Icon = "images/satisfaction-rate.svg" },
                })
            }
        };
        return base.OnInitializedAsync();
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}