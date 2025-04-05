using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Blogs;

namespace UnitFirst.Landing.ViewModels.Blogs;

public partial class BlogsViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    [ObservableProperty] private BlogsModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new BlogsModel()
        {
            FilterItems = new ObservableCollection<BlogFilterItemModel>
            {
                new()
                {
                    Name = "All",
                    Description = ""
                },
                new()
                {
                    Name = "AI",
                    Description = ""
                },
                new()
                {
                    Name = "IoT",
                    Description = ""
                },
                new()
                {
                    Name = "Enterprise",
                    Description = ""
                },
                new()
                {
                    Name = "StartUps",
                    Description = ""
                },
                new()
                {
                    Name = "Guides",
                    Description = ""
                },
                new()
                {
                    Name = "Development",
                    Description = ""
                },
                new()
                {
                    Name = "UnitFirst",
                    Description = ""
                },
            },
            Blogs = new ObservableCollection<BlogModel>
            {
                new()
                {
                    Image = "images/it-solution.png",
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "IoT" },
                        new BlogFilterItemModel() { Name = "Development" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
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
                    Tags = new ObservableCollection<BlogFilterItemModel>(new[]
                    {
                        new BlogFilterItemModel() { Name = "AI" },
                    }),
                    Title = "Integrating AI into Business: A Complete Guide For 2025",
                    AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                    Author = "Poni Koni",
                    Estimate = "12 min",
                    Date = "27 March 2025"
                },
            },
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void GetDetails()
    {
    }
}