using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IBrowserService
{
    public Task Initialize();
    public Task<BrowserDimension> GetDimensions();
    
    /// <summary>
    /// Show alert popup
    /// </summary>
    /// <param name="alertText"></param>
    /// <returns></returns>
    public Task ShowAlert(string alertText);
    
    /// <summary>
    /// Switch dark mode
    /// </summary>
    /// <returns>false - white, true - dark</returns>
    public Task<bool> DarkModeSwitch();
}