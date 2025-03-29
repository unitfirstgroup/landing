using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnitFirst.Landing.Models.Wallpaper;

namespace UnitFirst.Landing.Models
{
    public partial class WallPaperModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<ThesisModel> _thesisCollection;

        [ObservableProperty] private string _newsLetter;

        [ObservableProperty] private string _newsLetterDesc;

        [ObservableProperty] private string _subscribeAction;
    }
}
