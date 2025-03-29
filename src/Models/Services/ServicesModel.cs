using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Services;

public partial class ServicesModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<ServiceModel> _services;

    [ObservableProperty] private string _socialNetworksDescription;
}