using Microsoft.JSInterop;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class BrowserService(IJSRuntime jsRuntime) : IBrowserService
{
    private IJSObjectReference _mainModule;
    private IJSObjectReference _windowModule;

    public async Task Initialize()
    {
        _mainModule = await jsRuntime.InvokeAsync<IJSObjectReference>("import", new[] { "./js/index.js" });
        _windowModule = await jsRuntime.InvokeAsync<IJSObjectReference>("import", new[] { "./js/window.js" });
    }

    public async Task<BrowserDimension> GetDimensions()
    {
        var dimension = await _windowModule.InvokeAsync<BrowserDimension>("getDimensions");
        return dimension;
    }
    
    public async Task ShowDimensions(BrowserDimension dimension)
    {
        await _mainModule.InvokeVoidAsync("showAlert", $"Width: {dimension.Width}. Height: {dimension.Height}");
    }

    public async Task ShowAlert(string alertText)
    {
        await _mainModule.InvokeVoidAsync("showAlert", alertText);
    }

    public async Task GetAllElements()
    {
        var elements = await _windowModule.InvokeAsync<object>("getAllElements");

        Console.WriteLine(elements != null);
    }

    public async Task UpdateTheme(string theme)
    {
        if (theme == "dark")
        {
        }

        await _mainModule.InvokeVoidAsync("updateTheme", theme);
    }
}