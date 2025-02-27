using Blazored.LocalStorage;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class ApplicationStateService() : IApplicationStateService
{
    public ApplicationState State { get; } = new();

    public async Task ChangeTheme(string theme)
    {
        if (string.IsNullOrWhiteSpace(theme))
            throw new ArgumentNullException(nameof(theme));

        //await localStorageService.SetItemAsStringAsync("theme", theme);
        Console.WriteLine($"Theme changed to {theme}");
    }

    public async Task<string> LoadOrganizationId(string clientId)
    {
        //var theme = await localStorageService.GetItemAsStringAsync("theme");
        //return theme ?? "EAS";
        return "EAS";
    }

    public void SubmitRegistrationForm()
    {
        State.UserSubmitForm = true;
    }
}