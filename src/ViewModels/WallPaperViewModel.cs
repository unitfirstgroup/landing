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
            JoinText = "JOIN!!!",
            StartUsingText = "STAddsRT",
            SubscribeText = "SUB"
        };
        return Task.CompletedTask;
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