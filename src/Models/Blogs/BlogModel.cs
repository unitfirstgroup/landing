using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Blogs;

public partial class BlogModel : ObservableObject
{
    [ObservableProperty] private string _author;
    [ObservableProperty] private string _authorImage;
    [ObservableProperty] private string _date;
    [ObservableProperty] private string _estimate;
    [ObservableProperty] private string _image;
    [ObservableProperty] private ObservableCollection<BlogFilterItemModel> _tags;
    [ObservableProperty] private string _title;
}