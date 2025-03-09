using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IApplicationThemeService
{
    Theme Theme { get; }
    
    void DarkModeSwitch(Theme theme);
}