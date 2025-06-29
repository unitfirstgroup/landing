using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Wallpaper;

namespace UnitFirst.Landing.ViewModels.Wallpaper;

public partial class WallPaperViewModel(
        IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, 
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        IDataService<ThesisModel> dataService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private WallPaperModel _model;

    public override Task OnInitializedAsync()
    {
        var theses = dataService.LoadData();
        _model = new WallPaperModel()
        {
            ThesisCollection = new ObservableCollection<ThesisModel>(theses),
            NewsLetter = localizer["NEWSLETTER"].Value,
            NewsLetterDesc = localizer["NEWSLETTER_DESC"].Value,
            SubscribeAction = localizer["NEWSLETTER_SUBSCRIBE"].Value,
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void StartUsing()
    {
        navigationManager.NavigateTo("registration");
    }
    

    [RelayCommand]
    public void Subscribe()
    {
        Console.WriteLine("Subscribed");
    }

    public void ThesisClickHandler(ThesisModel thesis)
    {
        Console.WriteLine($"ThesisClickHandler raised. {thesis.ButtonText}");
        navigationManager.NavigateTo("./registration");
    }
}