using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using UnitFirst.Landing;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Services;
using UnitFirst.Landing.ViewModels;
using UnitFirst.Landing.ViewModels.Laboratories;
using UnitFirst.Landing.ViewModels.Services;
using FooterViewModel = UnitFirst.Landing.ViewModels.Layouts.FooterViewModel;
using NavMenuViewModel = UnitFirst.Landing.ViewModels.Layouts.NavMenuViewModel;
using WallPaperViewModel = UnitFirst.Landing.ViewModels.Wallpaper.WallPaperViewModel;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.AddTransient<NavMenuViewModel>();
builder.Services.AddTransient<FooterViewModel>();
builder.Services.AddTransient<IndexViewModel>();
builder.Services.AddTransient<WallPaperViewModel>();
builder.Services.AddTransient<ServicesViewModel>();
builder.Services.AddTransient<LaboratoriesViewModel>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
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
builder.Services.AddSingleton<IApplicationThemeService, ApplicationThemeService>();
builder.Services.AddSingleton<IApplicationStateService, ApplicationStateService>();
builder.Services.AddSingleton<BrowserService>();
builder.Services.AddSingleton<MouseService>()
    .AddSingleton<IMouseService>(sp => sp.GetRequiredService<MouseService>());

var jsInterop = builder.Build().Services.GetRequiredService<IJSRuntime>();

var appLanguage = await jsInterop.InvokeAsync<string>("appCulture.get");
if (appLanguage != null)
{
    CultureInfo cultureInfo = new CultureInfo(appLanguage);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}

await builder.Build().RunAsync();
