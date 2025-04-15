using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Extensions;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels.Generator;

public partial class GeneratorViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private GeneratorModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new GeneratorModel()
        {
            Name = "Company Features",
            Description = "Represents key features.",
            Kind = "Page",
            Tag = new TagModel { TagName = "/features" },
            Category = "Software Development",
        };
        return Task.CompletedTask;
    }

    public override Task Loaded()
    {
        Console.WriteLine($"{DateTime.UtcNow.ToDateTimeString()}|{nameof(GeneratorViewModel)}|{nameof(Loaded)}|");
        return base.Loaded();
    }

    [RelayCommand]
    public void Generate()
    {
        // page
        // viewmodel
        // model
        // dependency injection
        // resources
        // translations

        Console.WriteLine("Generate");
    }
}