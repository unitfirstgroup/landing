using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.About
{
    public partial class GetInTouchModel : BaseModel
    {
        [ObservableProperty] private string _title;

        [ObservableProperty] private string _greeting;

        [ObservableProperty] private string _email;
    }
}
