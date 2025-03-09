using System.Collections.ObjectModel;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class ApplicationThemeService : IApplicationThemeService
{
    private const string OrganizationId = "organizationId";
    private const string DarkMode = "darkMode";

    
    public ApplicationThemeService(IStringLocalizer<App> localizer)
    {
        var s = localizer["GET_STARTED"];
    }

    public void DarkModeSwitch(Theme theme)
    {
        theme.Dark = string.IsNullOrWhiteSpace(theme.Dark) ? "dark" : null;

        Console.WriteLine(
            $"Organization theme changed. OrganizationName: {theme.Organization}. DarkMode: {theme.Dark == "dark"}");
    }

    public Theme Theme { get; } = new()
    {
        Organization = "UnitFirst",
        Logo = "images/simple-logo.svg",
        Dark = "dark",
        NavItems = new ObservableCollection<NavItem>(new[]
        {
            new NavItem { Name = "Services", Link = "./" },
            new NavItem { Name = "Laboratories", Link = "./" },
            new NavItem { Name = "Cases", Link = "./" },
            new NavItem { Name = "Blog", Link = "./" },
            new NavItem { Name = "About the company", Link = "./" },
            new NavItem { Name = "Contacts", Link = "./" }
        }),
        Background = new Dictionary<string, string>(new[]
        {
            new KeyValuePair<string, string>("white", "bg-blue-400"),
            new KeyValuePair<string, string>("dark", "bg-green-500")
        })
    };
    
    public void DarkModeSwitch()
    {
        throw new NotImplementedException();
    }
}