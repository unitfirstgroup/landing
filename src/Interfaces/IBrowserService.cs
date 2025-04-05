using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IBrowserService
{
    public Task<BrowserDimension> Initialize();
    public Task<BrowserDimension> GetDimensions();
    public Task ShowDimensions(BrowserDimension dimension);
    public Task ShowAlert(string alertText);
}