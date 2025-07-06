using Microsoft.Extensions.Localization;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Models.Cases;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class CaseDataService(IStringLocalizer<App> localizer) : DataService<CaseModel>
{
    public override List<CaseModel> LoadData()
    {
        return new List<CaseModel>
        {
            new()
            {
                Name = localizer["CASES_LEARNING"].Value,
                Description = localizer["CASES_LEARNING_DESC"].Value,
                Image = localizer["CASES_LEARNING_IMG"].Value,
                UrlText = localizer["CASES_LEARNING_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_AI_HEALTH"].Value,
                Description = localizer["CASES_AI_HEALTH_DESC"].Value,
                Image = localizer["CASES_AI_HEALTH_IMG"].Value,
                UrlText = localizer["CASES_AI_HEALTH_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_SME"].Value,
                Description = localizer["CASES_SME_DESC"].Value,
                Image = localizer["CASES_SME_IMG"].Value,
                UrlText = localizer["CASES_SME_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_FINANCES"].Value,
                Description = localizer["CASES_FINANCES_DESC"].Value,
                Image = localizer["CASES_FINANCES_IMG"].Value,
                UrlText = localizer["CASES_FINANCES_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_EDUCATION"].Value,
                Description = localizer["CASES_EDUCATION_DESC"].Value,
                Image = localizer["CASES_EDUCATION_IMG"].Value,
                UrlText = localizer["CASES_EDUCATION_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_ESTATE"].Value,
                Description = localizer["CASES_ESTATE_DESC"].Value,
                Image = localizer["CASES_ESTATE_IMG"].Value,
                UrlText = localizer["CASES_ESTATE_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_RETAIL"].Value,
                Description = localizer["CASES_RETAIL_DESC"].Value,
                Image = localizer["CASES_RETAIL_IMG"].Value,
                UrlText = localizer["CASES_RETAIL_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_BLOCK_CHAIN"].Value,
                Description = localizer["CASES_BLOCK_CHAIN_DESC"].Value,
                Image = localizer["CASES_BLOCK_CHAIN_IMG"].Value,
                UrlText = localizer["CASES_BLOCK_CHAIN_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_MARKETING"].Value,
                Description = localizer["CASES_MARKETING_DESC"].Value,
                Image = localizer["CASES_MARKETING_IMG"].Value,
                UrlText = localizer["CASES_MARKETING_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_STUDENT"].Value,
                Description = localizer["CASES_STUDENT_DESC"].Value,
                Image = localizer["CASES_STUDENT_IMG"].Value,
                UrlText = localizer["CASES_STUDENT_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_PREDICTIVE"].Value,
                Description = localizer["CASES_PREDICTIVE_DESC"].Value,
                Image = localizer["CASES_PREDICTIVE_IMG"].Value,
                UrlText = localizer["CASES_PREDICTIVE_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            },
            new()
            {
                Name = localizer["CASES_HR"].Value,
                Description = localizer["CASES_HR_DESC"].Value,
                Image = localizer["CASES_HR_IMG"].Value,
                UrlText = localizer["CASES_HR_URL"].Value,
                Url = "#",
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = localizer["TAG_BUSINESS"].Value }
                })
            }
        };
    }

    public override List<TagModel> LoadTags()
    {
        return new List<TagModel>(new[]
        {
            new TagModel { TagName = localizer["TAG_LEARNING"].Value, Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = localizer["TAG_EDUCATION"].Value, Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = localizer["TAG_TRANSPORT"].Value, Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = localizer["TAG_BUSINESS"].Value, Select = new SelectModel { IsSelected = false } },
            new TagModel { TagName = localizer["TAG_AI_HEALTH"].Value, Select = new SelectModel { IsSelected = false } }
        });
    }
}