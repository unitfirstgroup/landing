using System.Collections.ObjectModel;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class ApplicationThemeService : IApplicationThemeService
{
    private const string OrganizationId = "organizationId";
    private const string DarkMode = "darkMode";
    private readonly IStringLocalizer<App> _localizer;


    public ApplicationThemeService(IStringLocalizer<App> localizer)
    {
        _localizer = localizer ?? throw new ArgumentNullException();
        Theme = new Theme
        {
            Organization = "UnitFirst",
            Logo = "images/simple-logo.svg",
            Dark = "dark",
            NavItems = new ObservableCollection<NavItem>(new[]
            {
                new NavItem { Name = _localizer["SERVICES"].Value, Link = "./" },
                new NavItem { Name = _localizer["LABORATORIES"].Value, Link = "./" },
                new NavItem { Name = _localizer["CASES"].Value, Link = "./" },
                new NavItem { Name = _localizer["BLOG"].Value, Link = "./" },
                new NavItem { Name = _localizer["ABOUT"].Value, Link = "./" },
                new NavItem { Name = _localizer["CONTACTS"].Value, Link = "./" }
            }),
            Background = new Dictionary<string, string>(new[]
            {
                new KeyValuePair<string, string>("white", "bg-blue-400"),
                new KeyValuePair<string, string>("dark", "bg-green-500")
            }),
            Languages = new ObservableCollection<LanguageListItemModel>(new[]
            {
                new LanguageListItemModel { Language = "en-US", ImageSource = "images/us.svg" },
                new LanguageListItemModel { Language = "ru-RU", ImageSource = "images/ru.svg" },
                new LanguageListItemModel { Language = "sp-SP", ImageSource = "images/sp.svg" }
            })
        };
    }

    public void DarkModeSwitch(Theme theme)
    {
        theme.Dark = string.IsNullOrWhiteSpace(theme.Dark) ? "dark" : null;

        Console.WriteLine(
            $"Organization theme changed. OrganizationName: {theme.Organization}. DarkMode: {theme.Dark == "dark"}");
    }

    public Theme Theme { get; }
}