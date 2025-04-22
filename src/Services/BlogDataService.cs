using System.Collections.ObjectModel;
using UnitFirst.Landing.Models.Blogs;
using UnitFirst.Landing.Models.Laboratories;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class BlogDataService : DataService<BlogModel>
{
    public override List<BlogModel> LoadData()
    {
        return new List<BlogModel>
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
    }

    public override List<TagModel> LoadTags()
    {
        return new List<TagModel>(new[]
        {
            new TagModel { TagName = "AI", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "IoT", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Enterprise", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "StartUps", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Guides", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Development", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "UI/UX", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "UnitFirst", Select = new SelectModel { IsSelected = false } }
        });
    }
}