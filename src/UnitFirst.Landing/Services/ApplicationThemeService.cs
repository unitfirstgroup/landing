using System.Collections.ObjectModel;
using Blazored.LocalStorage;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class ApplicationThemeService() : IApplicationThemeService
{
    private const string OrganizationId = "organizationId";
    private const string DarkMode = "darkMode";

    private readonly Dictionary<string, Theme> _themes = new()
    {
        {
            "UnitFirst", new Theme
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

                })
            }
        }
    };

    private Theme _currentTheme;

    public Theme? FindTheme(string organizationId)
    {
        return _themes.TryGetValue(organizationId, out var theme) ? theme : null;
    }

    public Theme Load()
    {
        return _currentTheme;
    }

    public void UseTheme(Theme theme)
    {
        _currentTheme = theme;
    }

    public void DarkModeSwitch(Theme theme)
    {
        theme.Dark = string.IsNullOrWhiteSpace(theme.Dark) ? "dark" : null;

        Console.WriteLine($"Organization theme changed. OrganizationName: {theme.Organization}. DarkMode: {theme.Dark == "dark"}");
    }

    public Task<Theme> Generate()
    {
        //var theme = new Theme
        //{
        //    LogoImg = "images/document-svgrepo-com.svg",

        //    Dashboard = "Pes",
        //    Team = "Kot",
        //    Projects = "Ezik",

        //    CartImg = "images/pie-chart-svgrepo-com.svg",
        //    AvatarImg = "images/cell-phone-svgrepo-com.svg",
        //    ThemeImg = "images/creativity-svgrepo-com.svg",

        //    HeadMessage = "Family",
        //    DetailsMessage = "Forever",
        //    ButtonText = "Join",

        //    MainColor = "bg-[#FBFBFB]"
        //};

        //return theme;

        return Task.FromResult(new Theme());
    }
}