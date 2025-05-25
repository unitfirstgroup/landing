using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Statistics;

namespace UnitFirst.Landing.Models.About;

public partial class AboutOrganizationModel : BaseModel
{
    [ObservableProperty] private string _main;

    [ObservableProperty] private string _mission;

    [ObservableProperty] private string _missionDetails;

    [ObservableProperty] private string _organization;

    [ObservableProperty] private ObservableCollection<StatisticModel> _statistics;

    [ObservableProperty] private string _title;
}