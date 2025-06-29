using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public partial class RegistrationViewModel : ViewModelBase
{
    private readonly IBrowserService _browserService;

    [ObservableProperty]
    private RegistrationModel _model;
    
    public RegistrationViewModel(
        IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        IBrowserService browserService) 
        : 
        base(
        applicationStateService, applicationThemeService, navigationManager, localizer)
    {
        _browserService = browserService;
        Model = new RegistrationModel();
    }

    public override Task OnInitializedAsync()
    {
        Console.WriteLine($"{nameof(RegistrationViewModel)}.{nameof(OnInitializedAsync)} at {DateTime.Now}");

        Model.FirstName = "Toni";
        Model.LastName = "Montana";
        Model.Organization = "Toni Montana Inc";
        Model.Phone = "1235521";
        Model.Site = "www.toni.inc";
        Model.Visitors = 100;
        Model.Email = "toni@toni.inc";
        Model.Domains = new ObservableCollection<string>
        {
            "Finance",
            "Cars",
            "IT",
            "Other"
        };
        Model.SelectedDomain = _model.Domains.Last();
        Model.Idea = "Sell high quality products and services with minimal price.";
        Model.Password = "123456";
        Model.ConfirmPassword = "123456";
        Model.IsAgreeTerms = true;

        return base.OnInitializedAsync();
    }

    public override Task Loaded()
    {
        Console.WriteLine($"{nameof(RegistrationViewModel)}.{nameof(Loaded)} at {DateTime.Now}");
        return base.Loaded();
    }
    
    [RelayCommand]
    public void Submit()
    {
        Console.WriteLine($"{_model.Site}");

        Model.Validate();

        _browserService.ShowAlert("Thank you for registration.");
        NavigationManager.NavigateTo("./");
    }
}