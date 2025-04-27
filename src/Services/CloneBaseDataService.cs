using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public class CloneBaseDataService : DataService<BaseModel>
{
    private readonly List<BaseModel> _items = new(new[]
    {
        new CloneBaseModel()
    });

    private readonly List<TagModel> _tags = new(new[]
    {
        new TagModel()
    });

    public override List<BaseModel> LoadData()
    {
        return _items;
    }

    public override List<TagModel> LoadTags()
    {
        return _tags;
    }
}