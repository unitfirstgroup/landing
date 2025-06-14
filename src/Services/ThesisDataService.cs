using Microsoft.Extensions.Localization;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Models.Shared;
using UnitFirst.Landing.Models.Wallpaper;

namespace UnitFirst.Landing.Services
{
    public class ThesisDataService(IStringLocalizer<App> localizer) : DataService<ThesisModel>
    {
        public override List<ThesisModel> LoadData()
        {
            return new List<ThesisModel>
            {
                new()
                {
                    Main = localizer["THESIS_0"].Value,
                    Description = localizer["THESIS_0_DESC"].Value,
                    ButtonText = localizer["THESIS_0_ACTION"].Value,
                    Image = "images/thesis_0.jpg"
                },
                new()
                {
                    Main = localizer["THESIS_1"].Value,
                    Description = localizer["THESIS_1_DESC"].Value,
                    ButtonText = localizer["THESIS_1_ACTION"].Value,
                    Image = "images/thesis_1.jpg"
                }
            };
        }

        public override List<TagModel> LoadTags()
        {
            throw new NotImplementedException();
        }
    }
}
