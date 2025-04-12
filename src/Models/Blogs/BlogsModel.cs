using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Models.Blogs;

public partial class BlogsModel : ObservableObject
{
    [ObservableProperty] private FilterModel _filter;
    //[ObservableProperty] private ObservableCollection<TagModel> _tags;
    [ObservableProperty] private ObservableCollection<BlogModel> _blogs;
    [ObservableProperty] private ObservableCollection<BlogModel> _searchBlogs;
    //[ObservableProperty] private string _searchPlaceholder;
    //[ObservableProperty] private string _searchText;
}