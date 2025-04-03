using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Blogs;

public partial class BlogsModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<BlogFilterItemModel> _filterItems;
    [ObservableProperty] private ObservableCollection<BlogModel> _blogs;
}