using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Cases;

public partial class CasesModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<CaseModel> _cases;
}