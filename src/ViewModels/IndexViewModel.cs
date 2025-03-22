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
        BrowserService browserService, NavigationManager navigationManager, ISyncLocalStorageService localStorage)
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
        theme.Dark = Model.Dark;

        browserService.GetDimensions().ContinueWith(task => Console.WriteLine($"[{task.Result.Width:N0} x {task.Result.Height:N0}]"));
        Console.WriteLine($"{nameof(IndexViewModel)}. {nameof(OnInitializedAsync)} at {DateTime.UtcNow.Ticks}\n");
        
        return base.OnInitializedAsync();
    }

    public override Task Loaded()
    {
        Console.WriteLine($"{nameof(IndexViewModel)}. {nameof(Loaded)}\n" +
                          $"{nameof(Theme.Organization)}: {Theme.Organization}");

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

        Console.WriteLine($"Left click: {click}");
    }

    public void MouseOut()
    {
        //Console.WriteLine($"{nameof(IndexViewModel)}. MouseOut");
    }

    public void MouseOver()
    {
        //Console.WriteLine($"{nameof(IndexViewModel)}. MouseOver");
    }

    [RelayCommand]
    public void Accept()
    {
        Model.Hide = "hidden";
        localStorage.SetItemAsString(LocalStorageConstants.AcceptThermsKey, "accept");
        Console.WriteLine("Accept");
    }

    [RelayCommand]
    public void Decline()
    {
        Model.Hide = "hidden";
        localStorage.SetItemAsString(LocalStorageConstants.AcceptThermsKey, "decline");
        Console.WriteLine("Decline");
    }
}