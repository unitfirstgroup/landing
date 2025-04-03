using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Blogs;

public partial class BlogFilterItemModel : ObservableObject
{
    [ObservableProperty] private string _description;
    [ObservableProperty] private string _name;
}