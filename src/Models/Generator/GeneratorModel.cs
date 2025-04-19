using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Models.Generator;

public partial class GeneratorModel : ObservableObject
{
    /// <summary>
    /// Name of Entity
    /// </summary>
    /// <remarks>[noun,verb]</remarks>
    [ObservableProperty] private string _name;

    /// <summary>
    /// Kind of UI element.
    /// </summary>
    /// <remarks>Page, Component, etc.</remarks>
    [ObservableProperty] private string _kind;

    /// <summary>
    /// Is collection of entities
    /// </summary>
    [ObservableProperty] private bool _isCollection;

    /// <summary>
    /// <remarks></remarks>
    /// </summary>
    [ObservableProperty] private string _description;

    /// <summary>
    /// <remarks>health,mathematics,cars, etc.</remarks>
    /// </summary>
    [ObservableProperty] private string _category;

    /// <summary>
    /// Key words that contains in Entity
    /// </summary>
    [ObservableProperty] private ObservableCollection<string> _keyWords;

    /// <summary>
    /// Contains specific kind parameter
    /// </summary>
    [ObservableProperty] private TagModel _tag;
}