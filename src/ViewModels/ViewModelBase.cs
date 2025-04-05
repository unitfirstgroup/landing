using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public abstract partial class ViewModelBase : ObservableObject, IViewModelBase
{
    protected readonly IApplicationStateService ApplicationStateService;
    protected readonly IApplicationThemeService ApplicationThemeService;
    protected readonly IStringLocalizer<App> Localizer;
    protected readonly NavigationManager NavigationManager;

    [ObservableProperty] private Theme _theme;
    
    protected ViewModelBase(IApplicationStateService applicationStateService, IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    {
        ApplicationStateService = applicationStateService;
        ApplicationThemeService = applicationThemeService;
        NavigationManager = navigationManager;
        Localizer = localizer;

        Theme = applicationThemeService.Theme ?? throw new Exception("ViewModelBase load theme exception.");
        Theme.PropertyChanged += Theme_PropertyChanged;
    }

    private void Theme_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        NotifyStateChanged();
    }

    protected virtual void NotifyStateChanged() => OnPropertyChanged((string?)null);

    public virtual async Task OnInitializedAsync()
    {
        await Loaded().ConfigureAwait(true);
    }

    [RelayCommand]
    public virtual async Task Loaded()
    {
        await Task.CompletedTask.ConfigureAwait(false);
    }
}