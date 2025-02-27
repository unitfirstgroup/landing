using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Services;

namespace UnitFirst.Landing.ViewModels;

public class IndexViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        BrowserService browserService, NavigationManager navigationManager)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    public BrowserService BrowserService { get; } = browserService;
    public ElementReference MyTarget { get; set; }
    public string Organization { get; set; }

    public override Task OnInitializedAsync()
    {
        var theme = applicationThemeService.Load();
        Organization = theme.Organization;
        
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
        var click = ($"{nameof(IndexViewModel)}: {nameof(LeftClick)}\n" +
                                 $"{nameof(args.ScreenX)}: {args.ScreenX:F0}\n" +
                                 $"{nameof(args.ScreenY)}: {args.ScreenY:F0}\n" +
                                 $"{nameof(args.PageX)}: {args.PageX:F0}\n" +
                                 $"{nameof(args.PageY)}: {args.PageY:F0}\n" +
                                 $"{nameof(args.ClientX)}: {args.ClientX:F0}\n" +
                                 $"{nameof(args.ClientY)}: {args.ClientY:F0}\n");

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
}