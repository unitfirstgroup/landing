using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IBrowserService
{
    public Task Initialize();
    public Task<BrowserDimension> GetDimensions();
    public Task ShowDimensions(BrowserDimension dimension);
    public Task ShowAlert(string alertText);

    public Task GetAllElements();

    /// <summary>
    /// Switch dark mode
    /// </summary>
    /// <returns>false - white, true - dark</returns>
    public Task<bool> DarkModeSwitch();
}