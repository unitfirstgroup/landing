using System.Collections.ObjectModel;
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
            Filter = new FilterModel()
            {
                SearchModel = new SearchModel()
                {
                    Placeholder = "Search blog via input key words...",
                    Value = "",
                    RaiseSearchCommand = RaiseSearchCommand
                },
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "All", Select = new SelectModel { IsSelected = true } },
                    new TagModel { TagName = "AI", Select = new SelectModel() },
                    new TagModel { TagName = "IoT", Select = new SelectModel() },
                    new TagModel { TagName = "Enterprise", Select = new SelectModel() },
                    new TagModel { TagName = "StartUps", Select = new SelectModel() },
                    new TagModel { TagName = "Guides", Select = new SelectModel() },
                    new TagModel { TagName = "Development", Select = new SelectModel() },
                    new TagModel { TagName = "UnitFirst", Select = new SelectModel() },
                }),
            },
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
            SearchBlogs = new ObservableCollection<BlogModel>()
        };

        return Task.CompletedTask;
    }


    [RelayCommand]
    public void GetDetails()
    {
    }

    [RelayCommand]
    public void RaiseSearch()
    {
        var selectedTags = Model.Filter.Tags
            .Where(x => x.Select is { IsSelected: true })
            .Select(x => x.TagName).Distinct();
        Console.WriteLine($"Filter start. Search: {Model.Filter.SearchModel.Value}. Tags: {string.Join('\n', selectedTags)}");
    }
}