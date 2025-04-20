using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.Interfaces
{
    public interface IDataService<TItem> where TItem : BaseModel
    {
        List<TItem> LoadData();

        List<TagModel> LoadTags();
    }
}
