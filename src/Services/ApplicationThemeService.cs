using System.Collections.ObjectModel;
using Blazored.LocalStorage;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Constants;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Layout;

namespace UnitFirst.Landing.Services;

public class ApplicationThemeService : IApplicationThemeService
{
    private readonly Theme _theme;

    private readonly Dictionary<string, string> _navItems = new()
    {
        { "NAV_SERVICES", "./services" },
        { "NAV_LABORATORIES", "./laboratories" },
        { "NAV_CASES", "./cases" },
        { "NAV_BLOG", "./blog" },
        { "NAV_ABOUT", "./about" },
    };

    private readonly Dictionary<string, string> _languages = new()
    {
        { "en-US", "images/us.svg" },
        { "ru-RU", "images/ru.svg" },
        { "es-ES", "images/es.svg" },
    };

    public ApplicationThemeService(IStringLocalizer<App> localizer, ISyncLocalStorageService localStorage)
    {
        var language = localStorage.GetItemAsString(LocalStorageConstants.LanguageKey);
        if (string.IsNullOrEmpty(language))
        {
            language = "en-US";
        }

        var dark = localStorage.GetItemAsString(LocalStorageConstants.DarkKey) ?? string.Empty;
        var hideTherms = "accept" == localStorage.GetItemAsString(LocalStorageConstants.AcceptThermsKey)
            ? "hidden"
            : string.Empty;

        _theme = new Theme
        {
            Organization = localizer["ORGANIZATION"].Value,
            Logo = "images/simple-logo.svg",
            Dark = dark,
            NavItems = new ObservableCollection<NavItem>(_navItems.Select(x => new NavItem()
            {
                Name = localizer[x.Key],
                Link = x.Value
            })),
            Languages = new ObservableCollection<LanguageListItemModel>(_languages.Select(x =>
                new LanguageListItemModel()
                {
                    Language = localizer[x.Key],
                    ImageSource = x.Value
                })),
            SelectedLanguage = language,
            HideTherms = hideTherms
        };
    }

    public Theme LoadTheme()
    {
        return _theme;
    }

    public void DarkModeSwitch(string theme)
    {
        _theme.Dark = theme;
    }
}