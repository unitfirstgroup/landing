using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Models.Laboratories;

public partial class LaboratoriesModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<LaboratoryModel> _laboratories;

    [ObservableProperty] private FilterModel _filter;
}