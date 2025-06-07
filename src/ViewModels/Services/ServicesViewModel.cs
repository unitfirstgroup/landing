using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Services;

namespace UnitFirst.Landing.ViewModels.Services;

public partial class ServicesViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private ServicesModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new ServicesModel()
        {
            Services = new ObservableCollection<ServiceModel>
            {
                new()
                {
                    Name = localizer["SERVICES_CUSTOM_DEVELOPMENT"].Value,
                    Description = localizer["SERVICES_CUSTOM_DEVELOPMENT_DESC"].Value,
                    Image = localizer["SERVICES_CUSTOM_DEVELOPMENT_IMG"].Value,
                    UrlText = localizer["SERVICES_CUSTOM_DEVELOPMENT_URL"].Value,
                    Url = "#"
                },
                new()
                {
                    Name = localizer["SERVICES_IOT"].Value,
                    Description = localizer["SERVICES_IOT_DESC"].Value,
                    Image = localizer["SERVICES_IOT_IMG"].Value,
                    UrlText = localizer["SERVICES_IOT_URL"].Value,
                    Url = "#"
                },
                new()
                {
                    Name = localizer["SERVICES_WEB"].Value,
                    Description = localizer["SERVICES_WEB_DESC"].Value,
                    Image = localizer["SERVICES_WEB_IMG"].Value,
                    UrlText = localizer["SERVICES_WEB_URL"].Value,
                    Url = "#"
                },
                new()
                {
                    Name = localizer["SERVICES_MOBILE"].Value,
                    Description = localizer["SERVICES_MOBILE_DESC"].Value,
                    Image = localizer["SERVICES_MOBILE_IMG"].Value,
                    UrlText = localizer["SERVICES_MOBILE_URL"].Value,
                    Url = "#"
                },
                new()
                {
                    Name = localizer["SERVICES_AI"].Value,
                    Description = localizer["SERVICES_AI_DESC"].Value,
                    Image = localizer["SERVICES_AI_IMG"].Value,
                    UrlText = localizer["SERVICES_AI_URL"].Value,
                    Url = "#"
                },
                new()
                {
                    Name = localizer["SERVICES_GPT"].Value,
                    Description = localizer["SERVICES_GPT_DESC"].Value,
                    Image = localizer["SERVICES_GPT_IMG"].Value,
                    UrlText = localizer["SERVICES_GPT_URL"].Value,
                    Url = "#"
                }
            },
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void GetInTouch()
    {
    }

    [RelayCommand]
    public void BookConsultation()
    {
    }
}