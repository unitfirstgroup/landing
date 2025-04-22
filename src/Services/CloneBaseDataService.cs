using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class CloneBaseDataService : DataService<BaseModel>
{
    public override List<BaseModel> LoadData()
    {
        return new List<BaseModel>();
    }

    public override List<TagModel> LoadTags()
    {
        return new List<TagModel>();
    }
}