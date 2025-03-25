using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public partial class WallPaperViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    [ObservableProperty] private WallPaperModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new WallPaperModel()
        {
            ThesisCollection = new ObservableCollection<ThesisModel>
            {
                new()
                {
                    Main = localizer["THESIS_0"].Value,
                    Description = localizer["THESIS_0_DESC"].Value,
                    ButtonText = localizer["THESIS_0_ACTION"].Value,
                    ButtonClick = GetStartedClicked,
                    Image = "images/thesis_0.jpg"
                },
                new()
                {
                    Main = localizer["THESIS_1"].Value,
                    Description = localizer["THESIS_1_DESC"].Value,
                    ButtonText = localizer["THESIS_1_ACTION"].Value,
                    ButtonClick = GetMoreInfoClicked,
                    Image = "images/thesis_1.jpg"
                }
            },
            NewsLetter = localizer["NEWSLETTER"].Value,
            NewsLetterDesc = localizer["NEWSLETTER_DESC"].Value,
            SubscribeAction = localizer["NEWSLETTER_SUBSCRIBE"].Value,
        };
        return Task.CompletedTask;
    }

    private void GetStartedClicked()
    {
    }

    private void GetMoreInfoClicked()
    {
    }

    [RelayCommand]
    public void StartUsing()
    {
        navigationManager.NavigateTo("registration");
    }

    [RelayCommand]
    public void Join()
    {
        Console.WriteLine("Joined");
    }

    [RelayCommand]
    public void Subscribe()
    {
        Console.WriteLine("Subscribed");
    }

    [RelayCommand]
    public void Submit(string par)
    {
        Console.WriteLine("Submitted");
    }
}