using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Blogs;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels.Blogs;

public partial class BlogsViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private BlogsModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new BlogsModel()
        {
            Tags = new ObservableCollection<string>
                { "All", "AI", "IoT", "Enterprise", "StartUps", "Guides", "Development", "UnitFirst" },
            Blogs = new ObservableCollection<BlogModel>
            {
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "IoT" },
                        new NameDescriptionModel() { Name = "Development" },
                    }),
                    Title = "IoT Solutions for Education: Overview & Best Practices",
                    AuthorImage = "https://randomuser.me/api/portraits/men/54.jpg",
                    Author = "Toni Montana",
                    Estimate = "3 min",
                    Date = "25 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<NameDescriptionModel>(new[]
                    {
                        new NameDescriptionModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
            },
            SearchPlaceholder = "Search blog via input key words...",
            SearchText = ""
        };

        _model.PropertyChanged += ModelOnPropertyChanged;

        return Task.CompletedTask;
    }

    private void ModelOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(Model.SearchText))
        {

        }
    }

    [RelayCommand]
    public void GetDetails()
    {
    }

    private void Search()
    {

    }
}