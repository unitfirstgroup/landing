using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using UnitFirst.Landing;
using UnitFirst.Landing.Extensions;

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

var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
var appLanguage = await jsInterop.InvokeAsync<string?>("appCulture.get");
if (appLanguage != null)
{
    CultureInfo cultureInfo = new CultureInfo(appLanguage);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}
else
{
    // eng is default
    CultureInfo cultureInfo = new CultureInfo("en-US");
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}

await host.RunAsync();
