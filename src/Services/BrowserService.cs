using Microsoft.JSInterop;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class BrowserService(IJSRuntime jsRuntime) : IBrowserService
{
    private IJSObjectReference? _mainModule;
    private IJSObjectReference? _windowModule;

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
    
    public async Task ShowAlert(string alertText)
    {
        await _mainModule.InvokeVoidAsync("showAlert", alertText);
    }

    public async Task<bool> SwitchTheme()
    {
        return await _mainModule.InvokeAsync<bool>("switchTheme");
    }

    public async Task<bool> DarkTheme()
    {
        return await _mainModule.InvokeAsync<bool>("darkTheme");
    }
}