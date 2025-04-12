using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IApplicationThemeService
{
    Theme LoadTheme();
    
    void DarkModeSwitch(Theme theme);
}