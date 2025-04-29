using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Feedback;

namespace UnitFirst.Landing.Models.Cases;

public partial class CasesModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<CaseModel> _cases;
    [ObservableProperty] private FeedbackComponentModel _feedback;
}