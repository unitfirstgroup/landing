using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Services;

public abstract class DataService<TItem> : IDataService<TItem> where TItem : BaseModel
{
    public abstract List<TItem> LoadData();

    public abstract List<TagModel> LoadTags();
}