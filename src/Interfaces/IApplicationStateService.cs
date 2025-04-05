using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IApplicationStateService
{
    public ApplicationState State { get; }
    
    void SubmitRegistrationForm();

    Task ChangeTheme(string theme);
    
    void RegisterMouseOut()
    {
        State.MouseOutCount++;
    }

    void RegisterMouseOver()
    {
        State.MouseOverCount++;
    }

    void RegisterMouseMove()
    {
        State.MouseMoveCount++;
    }

    void RegisterLeftClick()
    {
        State.MouseLeftClickCount++;
    }

    void RegisterClose()
    {
        State.Close = true;
    }

    void RegisterAcceptTherms()
    {
        State.UserAcceptTerms = true;
    }

    void RegisterDeclineTherms()
    {
        State.UserDeclineTerms = true;
    }

    void RegisterOrganization(string organization)
    {
        State.Organization = organization;
    }
}