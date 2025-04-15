using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;

namespace UnitFirst.Landing.Services;

public class GeneratorService : IGeneratorService
{
    public const string ROOT = "C:\\Work\\unitfirst\\landing\\src";
    public const string TEMPLATE = "Generator";
    public bool Generate(GeneratorModel model)
    {
        // page
        // viewmodel
        // model
        // dependency injection
        // resources
        // translations

        WritePage(model);
        WriteViewModel(model);
        WriteModel(model);
        WriteDI(model);
        WriteResources(model);
        WriteTranslations(model);

        return true;
    }

    private void WriteTranslations(GeneratorModel model)
    {
        //throw new NotImplementedException();
    }

    private void WriteResources(GeneratorModel model)
    {
        //throw new NotImplementedException();
    }

    private void WriteDI(GeneratorModel model)
    {
        //throw new NotImplementedException();
    }

    private void WriteModel(GeneratorModel model)
    {
        //throw new NotImplementedException();
    }

    private void WriteViewModel(GeneratorModel model)
    {
        //throw new NotImplementedException();
    }

    private void WritePage(GeneratorModel model)
    {
        var path = $"{ROOT}\\Pages\\{model.Name}.razor";
        Console.WriteLine($"{nameof(WritePage)}: {path}");
        try
        {
            File.WriteAllText(path, "razor content");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}