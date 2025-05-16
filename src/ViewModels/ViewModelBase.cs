using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels;

public abstract partial class ViewModelBase : ObservableObject, IViewModelBase
{
    protected readonly IApplicationStateService ApplicationStateService;
    protected readonly IApplicationThemeService ApplicationThemeService;
    protected readonly NavigationManager NavigationManager;

    public readonly IStringLocalizer<App> Localizer;

    [ObservableProperty] private Theme _theme;

    [ObservableProperty] private UIElementModel _uiElementModel;

    protected ViewModelBase(IApplicationStateService applicationStateService, IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    {
        ApplicationStateService = applicationStateService;
        ApplicationThemeService = applicationThemeService;
        NavigationManager = navigationManager;
        Localizer = localizer;

        Theme = applicationThemeService.LoadTheme() ?? throw new Exception("ViewModelBase load theme exception.");

        UiElementModel = new UIElementModel
        {
            IsHide = false,
            OnFocus = false,
            IsSelected = false
        };
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