using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Blogs;

public partial class BlogsModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<string> _tags;
    [ObservableProperty] private ObservableCollection<BlogModel> _blogs;
    [ObservableProperty] private ObservableCollection<BlogModel> _searchBlogs;
    [ObservableProperty] private string _searchPlaceholder;
    [ObservableProperty] private string _searchText;
}