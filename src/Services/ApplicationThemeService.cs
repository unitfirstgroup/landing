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
    private const string OrganizationId = "organizationId";
    private const string DarkMode = "darkMode";
    private readonly IStringLocalizer<App> _localizer;
    private readonly ISyncLocalStorageService _localStorage;


    public ApplicationThemeService(IStringLocalizer<App> localizer, ISyncLocalStorageService localStorage)
    {
        _localizer = localizer ?? throw new ArgumentNullException();
        _localStorage = localStorage;

        var language = localStorage.GetItemAsString(LocalStorageConstants.LanguageKey);
        if (string.IsNullOrEmpty(language))
        {
            language = "en-US";
        }

        Theme = new Theme
        {
            Organization = "UnitFirst",
            Logo = "images/simple-logo.svg",
            Dark = "dark",
            NavItems = new ObservableCollection<NavItem>(new[]
            {
                new NavItem { Name = _localizer["NAV_SERVICES"].Value, Link = "./services" },
                new NavItem { Name = _localizer["NAV_LABORATORIES"].Value, Link = "./laboratories" },
                new NavItem { Name = _localizer["NAV_CASES"].Value, Link = "./cases" },
                new NavItem { Name = _localizer["NAV_BLOG"].Value, Link = "./blog" },
                new NavItem { Name = _localizer["NAV_ABOUT"].Value, Link = "./about" },
                //new NavItem { Name = _localizer["NAV_CONTACTS"].Value, Link = "./" }
            }),
            Background = new Dictionary<string, string>(new[]
            {
                new KeyValuePair<string, string>("white", "bg-white"),
                new KeyValuePair<string, string>("dark", "bg-gray-900")
            }),
            Languages = new ObservableCollection<LanguageListItemModel>(new[]
            {
                new LanguageListItemModel { Language = "en-US", ImageSource = "images/us.svg" },
                new LanguageListItemModel { Language = "ru-RU", ImageSource = "images/ru.svg" },
                new LanguageListItemModel { Language = "es-ES", ImageSource = "images/es.svg" }
            }),
            SelectedLanguage = language
        };
    }

    public void DarkModeSwitch(Theme theme)
    {
        theme.Dark = string.IsNullOrWhiteSpace(theme.Dark) ? "dark" : "";
        _localStorage.SetItemAsString(LocalStorageConstants.DarkKey, theme.Dark);
    }

    public Theme Theme { get; }
}