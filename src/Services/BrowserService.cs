using Microsoft.JSInterop;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class BrowserService
{
    private readonly IJSRuntime _jsRuntime;

    private IJSObjectReference _mainModule;
    private IJSObjectReference _dimensionModule;

    public BrowserService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<BrowserDimension> Initialize()
    {
        _mainModule = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", new[] { "./js/index.js" });
        _dimensionModule = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", new[] { "./js/window.js" });
        var dimensions = await GetDimensions();
        return dimensions;
    }

    public async Task<BrowserDimension> GetDimensions()
    {
        var dimension = await _dimensionModule.InvokeAsync<BrowserDimension>("getDimensions");
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
}