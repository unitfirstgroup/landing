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
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<BlogModel> searchService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private BlogsModel _model;

    private readonly List<BlogModel> _blogs = new()
    {
            new()
            {
                Image = "images/it-solution.png",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "IoT" },
                    new TagModel() { TagName = "Development" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
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
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel() { TagName = "AI" },
                }),
                Title = "Integrating AI into Business: A Complete Guide For 2025",
                AuthorImage = "https://randomuser.me/api/portraits/men/23.jpg",
                Author = "Poni Koni",
                Estimate = "12 min",
                Date = "27 March 2025"
            },
        };

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
                    new TagModel { TagName = "AI" },
                    new TagModel { TagName = "IoT" },
                    new TagModel { TagName = "Enterprise" },
                    new TagModel { TagName = "StartUps" },
                    new TagModel { TagName = "Guides" },
                    new TagModel { TagName = "Development" },
                    new TagModel { TagName = "UI/UX" },
                    new TagModel { TagName = "UnitFirst" }
                }),
            },
            Blogs = new ObservableCollection<BlogModel>(_blogs)
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
        var filtered = searchService.Search(_blogs, Model.Filter);
        if (filtered == null)
            return;


        Model.Blogs.Clear();
        foreach (var blogModel in filtered)
        {
            Model.Blogs.Add(blogModel);
        }

        NotifyStateChanged();
        //Console.WriteLine($"Filter start. Search: {Model.Filter.SearchModel.Value}. Tags: {string.Join(',', selectedTags.Select(x => x.TagName))}");
    }
}