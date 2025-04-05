namespace UnitFirst.Landing.Models;

public class ApplicationState
{
    public string Organization { get; set; }

    public bool UserAcceptTerms { get; set; }
    public bool UserDeclineTerms { get; set; }

    public string Theme { get; set; }

    public bool UserSubmitForm { get; set; }
    public long MouseMoveCount { get; set; }
    public long MouseOutCount { get; set; }
    public long MouseOverCount { get; set; }
    public long MouseLeftClickCount { get; set; }

    public bool Close { get; set; }
    public bool Loaded { get; set; }
}