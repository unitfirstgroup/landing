using UnitFirst.Landing.Models.Generator;

namespace UnitFirst.Landing.Interfaces;

public interface IGeneratorService
{
    /// <summary>
    ///     Generate page
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    bool Generate(GeneratorModel model);
}