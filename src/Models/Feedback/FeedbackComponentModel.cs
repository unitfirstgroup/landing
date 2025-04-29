using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Feedback;

public partial class FeedbackComponentModel : BaseModel
{
    [ObservableProperty] private string _title;
    [ObservableProperty] private ObservableCollection<FeedbackModel> _feedbackItems;
    [ObservableProperty] private FeedbackModel _currentFeedback;
    [ObservableProperty] private string _dark;
}