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
                    new StatisticModel()
                    {
                        Name = Localizer.GetString("ABOUT_SATISFACTION_RATE").Value, Value = "97%",
                        Icon = "images/satisfaction-rate.svg"
                    },
                    new StatisticModel()
                    {
                        Name = Localizer.GetString("ABOUT_SUCCESSFUL_PROJECTS").Value, Value = "23+",
                        Icon = "images/satisfaction-rate.svg"
                    },
                    new StatisticModel()
                    {
                        Name = Localizer.GetString("ABOUT_COUNTRIES").Value, Value = "7",
                        Icon = "images/satisfaction-rate.svg"
                    },
                    new StatisticModel()
                    {
                        Name = Localizer.GetString("ABOUT_SENIOR_SPECIALISTS").Value, Value = "70%",
                        Icon = "images/satisfaction-rate.svg"
                    },
                    new StatisticModel()
                    {
                        Name = Localizer.GetString("ABOUT_CLIENT_ENGAGEMENT").Value, Value = "3+",
                        Icon = "images/satisfaction-rate.svg"
                    },
                    new StatisticModel()
                    {
                        Name = Localizer.GetString("ABOUT_YEARS_ON_MARKET").Value, Value = "15+",
                        Icon = "images/satisfaction-rate.svg"
                    },
                })
            },
            GetInTouch = new GetInTouchModel()
            {
                Title = Localizer.GetString("GET_IN_TOUCH_TITLE").Value,
                Greeting = Localizer.GetString("GET_IN_TOUCH_GREETING").Value,
                Email = Localizer.GetString("GET_IN_TOUCH_EMAIL").Value,
            }
        };
        return base.OnInitializedAsync();
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}