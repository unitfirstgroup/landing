using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Feedback;

public partial class FeedbackModel : BaseModel
{
    [ObservableProperty] private string _author;
    [ObservableProperty] private string _main;
    [ObservableProperty] private string _details;
}