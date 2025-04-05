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
using UnitFirst.Landing.ViewModels.About;
using UnitFirst.Landing.ViewModels.Blogs;
using UnitFirst.Landing.ViewModels.Cases;
using UnitFirst.Landing.ViewModels.Laboratories;
using UnitFirst.Landing.ViewModels.Layouts;
using UnitFirst.Landing.ViewModels.Services;
using UnitFirst.Landing.ViewModels.Wallpaper;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.AddTransient<NavMenuViewModel>();
builder.Services.AddTransient<FooterViewModel>();
builder.Services.AddTransient<WallPaperViewModel>();
builder.Services.AddTransient<ServicesViewModel>();
builder.Services.AddTransient<LaboratoriesViewModel>();
builder.Services.AddTransient<CasesViewModel>();
builder.Services.AddTransient<AboutViewModel>();
builder.Services.AddTransient<BlogsViewModel>();

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
builder.Services.AddSingleton<IBrowserService, BrowserService>();

var jsInterop = builder.Build().Services.GetRequiredService<IJSRuntime>();
var appLanguage = await jsInterop.InvokeAsync<string>("appCulture.get");
if (appLanguage != null)
{
    CultureInfo cultureInfo = new CultureInfo(appLanguage);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}

await builder.Build().RunAsync();
