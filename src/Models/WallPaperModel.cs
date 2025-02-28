using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models
{
    public partial class WallPaperModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<ThesisModel> _thesisCollection;
    }
}
