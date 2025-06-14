using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnitFirst.Landing;
using UnitFirst.Landing.Constants;
using UnitFirst.Landing.Extensions;
using UnitFirst.Landing.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});
builder.Services.AddCoreServices(builder.Configuration);
builder.Services.AddViewModels(builder.Configuration);
builder.Services.AddSearchServices(builder.Configuration);
builder.Services.AddDataServices(builder.Configuration);
builder.Services.AddBlazoredLocalStorageAsSingleton(config =>
{
    config.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
    config.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    config.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    config.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
    config.JsonSerializerOptions.WriteIndented = false;
});

var host = builder.Build();

// browser init
var browserService = host.Services.GetRequiredService<IBrowserService>();
await browserService.Initialize();

// culture
var syncLocalStorageService = host.Services.GetRequiredService<ISyncLocalStorageService>();
var appLanguage = syncLocalStorageService.GetItemAsString(LocalStorageConstants.LanguageKey);
if (appLanguage != null)
{
    var cultureInfo = new CultureInfo(appLanguage);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}
else
{
    // eng is default
    var defaultCulture = "en-US";
    var cultureInfo = new CultureInfo(defaultCulture);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    syncLocalStorageService.SetItemAsString(LocalStorageConstants.LanguageKey, defaultCulture);
}

// dark
var dark = syncLocalStorageService.GetItemAsString(LocalStorageConstants.DarkKey);

if (dark == "dark")
{
    await browserService.DarkTheme();
}

await host.RunAsync();
