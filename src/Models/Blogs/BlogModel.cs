using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Blogs;

public partial class BlogModel : BaseModel
{
    [ObservableProperty] private string _author;
    [ObservableProperty] private string _authorImage;
    [ObservableProperty] private string _date;
    [ObservableProperty] private string _estimate;
    [ObservableProperty] private string _image;
    [ObservableProperty] private string _title;
    public override string SearchValue => _title;
}