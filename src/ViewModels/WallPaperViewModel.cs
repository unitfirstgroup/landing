using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public partial class WallPaperViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager)
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
                    Main = "UnitFirst is a leading IT company providing innovative solutions for businesses and individuals.",
                    Description = "Our team of experienced professionals with a passion for technology and innovation. We are committed to delivering high-quality solutions that meet our clients' needs and exceed their expectations.",
                    ButtonText = "Get Started",
                    ButtonClick = GetStartedClicked
                },
                new()
                {
                    Main = "Our Services",
                    Description = "We offer a range of services including software development, IT consulting, cybersecurity, and more.",
                    ButtonText = "Get more info",
                    ButtonClick = GetMoreInfoClicked
                }
            }
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