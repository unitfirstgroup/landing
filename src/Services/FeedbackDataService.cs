using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Models.Feedback;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class FeedbackDataService(IStringLocalizer<App> localizer) : DataService<FeedbackModel>
{
    public override List<FeedbackModel> LoadData()
    {
        return new List<FeedbackModel>
        {
            new()
            {
                Author = localizer["FEEDBACK_ITEM_0_AUTHOR"].Value,
                Main = localizer["FEEDBACK_ITEM_0_MAIN"].Value,
                Details =localizer["FEEDBACK_ITEM_0_DETAILS"].Value
            },
            new()
            {
                Author = localizer["FEEDBACK_ITEM_1_AUTHOR"].Value,
                Main = localizer["FEEDBACK_ITEM_1_MAIN"].Value,
                Details =localizer["FEEDBACK_ITEM_1_DETAILS"].Value
            },
            new()
            {
                Author = localizer["FEEDBACK_ITEM_2_AUTHOR"].Value,
                Main = localizer["FEEDBACK_ITEM_2_MAIN"].Value,
                Details =localizer["FEEDBACK_ITEM_2_DETAILS"].Value
            },
            new()
            {
                Author = localizer["FEEDBACK_ITEM_3_AUTHOR"].Value,
                Main = localizer["FEEDBACK_ITEM_3_MAIN"].Value,
                Details =localizer["FEEDBACK_ITEM_3_DETAILS"].Value
            },
        };
    }

    public override List<TagModel> LoadTags()
    {
        return new List<TagModel>();
    }
}