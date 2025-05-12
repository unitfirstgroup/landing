using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Services;

public partial class ServicesModel : ObservableObject
{
    [ObservableProperty] private string _accentWord;

    [ObservableProperty] private string _categoryAccentWord;

    [ObservableProperty] private string _categoryTitle;

    [ObservableProperty] private string _description;
    
    [ObservableProperty] private string _title;

    [ObservableProperty] private ObservableCollection<ServiceModel> _services;
}