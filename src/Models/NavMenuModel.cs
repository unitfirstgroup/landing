using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UnitFirst.Landing.Models
{
    public partial class NavMenuModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<NavItem> _navItems;

        [ObservableProperty] private string _getStarted;

        [ObservableProperty] private ObservableCollection<LanguageListItemModel> _languages;

        [ObservableProperty] private LanguageListItemModel _selectedLanguage;

        public NavMenuModel(Theme theme)
        {
            _navItems = theme.NavItems;
            _languages = theme.Languages;
            _selectedLanguage = theme.Languages.FirstOrDefault(x => x.Language == theme.SelectedLanguage) ??
                                new LanguageListItemModel()
                                {
                                    Language = "en-US",
                                    ImageSource = "images/us.svg"
                                };
        }
    }
}
