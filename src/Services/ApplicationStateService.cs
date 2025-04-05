using Blazored.LocalStorage;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Services;

public class ApplicationStateService(ILocalStorageService localStorageService) : IApplicationStateService
{
    public ApplicationState State { get; } = new();
    
    public void SubmitRegistrationForm()
    {
        State.UserSubmitForm = true;
    }
    
    public void RegisterMouseOut()
    {
        State.MouseOutCount++;
    }

    public void RegisterMouseOver()
    {
        State.MouseOverCount++;
    }

    public void RegisterMouseMove()
    {
        State.MouseMoveCount++;
    }

    public void RegisterLeftClick()
    {
        State.MouseLeftClickCount++;
    }

    public void RegisterClose()
    {
        State.Close = true;
    }

    public void RegisterAcceptTherms()
    {
        State.UserAcceptTerms = true;
    }

    public void RegisterDeclineTherms()
    {
        State.UserDeclineTerms = true;
    }

    public void RegisterOrganization(string organization)
    {
        State.Organization = organization;
    }
}