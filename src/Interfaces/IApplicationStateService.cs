using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IApplicationStateService
{
    public ApplicationState State { get; }
    
    void SubmitRegistrationForm();

    Task ChangeTheme(string theme);

    Task<string> LoadOrganizationId(string clientId);
}