using Microsoft.Extensions.Localization;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Models.Laboratories;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class LaboratoryDataService(IStringLocalizer<App> localizer) : DataService<LaboratoryModel>
{
    public override List<LaboratoryModel> LoadData()
    {
        return new List<LaboratoryModel>
        {
            new()
            {
                Name = localizer["LABORATORIES_HEALTHCARE"].Value,
                Description = localizer["LABORATORIES_HEALTHCARE_DESC"].Value,
                Image = localizer["LABORATORIES_HEALTHCARE_IMG"].Value,
                UrlText = localizer["LABORATORIES_HEALTHCARE_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Healthcare" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_MEDIA"].Value,
                Description = localizer["LABORATORIES_MEDIA_DESC"].Value,
                Image = localizer["LABORATORIES_MEDIA_IMG"].Value,
                UrlText = localizer["LABORATORIES_MEDIA_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Media" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_LOGISTICS"].Value,
                Description = localizer["LABORATORIES_LOGISTICS_DESC"].Value,
                Image = localizer["LABORATORIES_LOGISTICS_IMG"].Value,
                UrlText = localizer["LABORATORIES_LOGISTICS_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Transport" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_FINANCES"].Value,
                Description = localizer["LABORATORIES_FINANCES_DESC"].Value,
                Image = localizer["LABORATORIES_FINANCES_IMG"].Value,
                UrlText = localizer["LABORATORIES_FINANCES_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Business" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_EDUCATION"].Value,
                Description = localizer["LABORATORIES_EDUCATION_DESC"].Value,
                Image = localizer["LABORATORIES_EDUCATION_IMG"].Value,
                UrlText = localizer["LABORATORIES_EDUCATION_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Education" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_ESTATE"].Value,
                Description = localizer["LABORATORIES_ESTATE_DESC"].Value,
                Image = localizer["LABORATORIES_ESTATE_IMG"].Value,
                UrlText = localizer["LABORATORIES_ESTATE_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Business" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_COMMERCE"].Value,
                Description = localizer["LABORATORIES_COMMERCE_DESC"].Value,
                Image = localizer["LABORATORIES_COMMERCE_IMG"].Value,
                UrlText = localizer["LABORATORIES_COMMERCE_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Business" }
                })
            },
            new()
            {
                Name = localizer["LABORATORIES_MARKETING"].Value,
                Description = localizer["LABORATORIES_MARKETING_DESC"].Value,
                Image = localizer["LABORATORIES_MARKETING_IMG"].Value,
                UrlText = localizer["LABORATORIES_MARKETING_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "Business" }
                })
            }
        };
    }

    public override List<TagModel> LoadTags()
    {
        return new List<TagModel>(new[]
        {
            new TagModel { TagName = "Healthcare", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Education", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Transport", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Business", Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = "Media", Select = new SelectModel { IsSelected = false } }
        });
    }
}