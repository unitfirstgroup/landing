using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.Interfaces;

public interface IApplicationStateService
{
    public ApplicationState State { get; }
    
    void SubmitRegistrationForm();

    void RegisterMouseOut();

    void RegisterMouseOver();

    void RegisterMouseMove();

    void RegisterLeftClick();

    void RegisterClose();

    void RegisterAcceptTherms();

    void RegisterDeclineTherms();

    void RegisterOrganization(string organization);
}