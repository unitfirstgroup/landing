using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Laboratories;

public partial class LaboratoriesModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<LaboratoryModel> _laboratories;
}