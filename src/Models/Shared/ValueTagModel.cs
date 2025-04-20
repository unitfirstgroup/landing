using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Shared;

public class ValueTagModel : ObservableObject
{
    public string Value { get; }
    public IEnumerable<TagModel> Tags { get; }
}