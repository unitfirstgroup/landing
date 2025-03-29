using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models.Wallpaper
{
    public partial class WallPaperModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<ThesisModel> _thesisCollection;

        [ObservableProperty] private string _newsLetter;

        [ObservableProperty] private string _newsLetterDesc;

        [ObservableProperty] private string _subscribeAction;
    }
}
