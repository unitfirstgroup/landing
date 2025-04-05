using Blazored.LocalStorage;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using UnitFirst.Landing.Constants;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Services;

namespace UnitFirst.Landing.ViewModels;

public partial class IndexViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        ISyncLocalStorageService localStorage,
        BrowserService browserService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    public IndexModel Model { get; set; }
    
    public override Task OnInitializedAsync()
    {
        var theme = applicationThemeService.Theme;
        var accept = localStorage.GetItemAsString(LocalStorageConstants.AcceptThermsKey);
        var dark = localStorage.GetItemAsString(LocalStorageConstants.DarkKey);
        Model = new IndexModel()
        {
            Organization = theme.Organization,
            Hide = accept == "accept" ? "hidden": "",
            Dark = dark == "dark" ? dark : ""
        };
        theme.Dark = dark ?? string.Empty;
        ApplicationStateService.RegisterOrganization(Model.Organization);
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(OnInitializedAsync)}|{applicationStateService.State.Organization}");

        return base.OnInitializedAsync();
    }

    public override Task Loaded()
    {
        // TODO: Load DOM elements to applicationStateService

        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(Loaded)}|{applicationStateService.State.Loaded}");
        return base.Loaded();
    }

    public void LeftClick(PointerEventArgs args)
    {
        // Get Dimensions
        var click = $"{nameof(IndexViewModel)}: {nameof(LeftClick)}\n" +
                    $"{nameof(args.ScreenX)}: {args.ScreenX:N0}\n" +
                    $"{nameof(args.ScreenY)}: {args.ScreenY:N0}\n" +
                    $"{nameof(args.PageX)}: {args.PageX:N0}\n" +
                    $"{nameof(args.PageY)}: {args.PageY:N0}\n" +
                    $"{nameof(args.ClientX)}: {args.ClientX:N0}\n" +
                    $"{nameof(args.ClientY)}: {args.ClientY:N0}\n";

        ApplicationStateService.RegisterLeftClick();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(LeftClick)}|{applicationStateService.State.MouseLeftClickCount}");
    }

    public void MouseOut()
    {
        ApplicationStateService.RegisterMouseOut();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(MouseOut)}|{applicationStateService.State.MouseOutCount}");
    }

    public void MouseOver()
    {
        ApplicationStateService.RegisterMouseOver();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(MouseOver)}|{applicationStateService.State.MouseOverCount}");
    }

    public void MouseMove()
    {
        ApplicationStateService.RegisterMouseMove();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(MouseMove)}|{applicationStateService.State.MouseMoveCount}");
    }

    public void Close()
    {
        ApplicationStateService.RegisterClose();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(Close)}|{applicationStateService.State.Close}");
    }

    [RelayCommand]
    public void Accept()
    {
        Model.Hide = "hidden";
        localStorage.SetItemAsString(LocalStorageConstants.AcceptThermsKey, "accept");
        ApplicationStateService.RegisterAcceptTherms();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(Accept)}|{applicationStateService.State.UserAcceptTerms}");
    }

    [RelayCommand]
    public void Decline()
    {
        Model.Hide = "hidden";
        localStorage.SetItemAsString(LocalStorageConstants.AcceptThermsKey, "decline");
        ApplicationStateService.RegisterDeclineTherms();
        Console.WriteLine($"{DateTime.UtcNow.Ticks}|{nameof(IndexViewModel)}|{nameof(Decline)}|{applicationStateService.State.UserDeclineTerms}");
    }
}