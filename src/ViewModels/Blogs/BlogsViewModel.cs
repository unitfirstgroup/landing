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
        Model.Blogs.Clear();

        var selectedTags = Model.Filter.Tags
            .Where(x => x.Select is { IsSelected: true }).Distinct();

        var isTagSelected = selectedTags.Any();
        var isSearchEmpty = string.IsNullOrEmpty(Model.Filter.SearchModel.Value);

        if (isSearchEmpty && isTagSelected == false)
        {
            foreach (var blogModel in _blogs)
            {
                Model.Blogs.Add(blogModel);
            }
        }
        else
        {
            foreach (var blogModel in _blogs)
            {
                if (!isSearchEmpty)
                {
                    if (blogModel.Title.Contains(Model.Filter.SearchModel.Value))
                        Model.Blogs.Add(blogModel);
                    else
                        continue;
                }

                foreach (var enabledTag in selectedTags)
                {
                    if (blogModel.Tags.Any(x => x.TagName == enabledTag.TagName))
                    {
                        Model.Blogs.Add(blogModel);
                        break;
                    }
                }
            }
        }

        NotifyStateChanged();
        Console.WriteLine($"Filter start. Search: {Model.Filter.SearchModel.Value}. Tags: {string.Join(',', selectedTags.Select(x => x.TagName))}");
    }
}