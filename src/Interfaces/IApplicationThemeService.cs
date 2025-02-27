using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IApplicationThemeService
{
    Theme? FindTheme(string organizationId);

    Theme Load();

    void UseTheme(Theme theme);

    void DarkModeSwitch(Theme theme);

    Task<Theme> Generate();
}