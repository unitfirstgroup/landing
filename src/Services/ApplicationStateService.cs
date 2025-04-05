using Blazored.LocalStorage;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class ApplicationStateService(ILocalStorageService localStorageService) : IApplicationStateService
{
    public ApplicationState State { get; } = new();

    public async Task ChangeTheme(string theme)
    {
        if (string.IsNullOrWhiteSpace(theme))
            throw new ArgumentNullException(nameof(theme));

        await localStorageService.SetItemAsStringAsync("theme", theme);
        State.Theme = theme;
    }

    public void SubmitRegistrationForm()
    {
        State.UserSubmitForm = true;
    }
}