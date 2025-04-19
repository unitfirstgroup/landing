using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;

namespace UnitFirst.Landing.Services;

public class GeneratorService : IGeneratorService
{
    public const string ROOT = "C:\\Work\\unitfirst\\landing\\src";
    public const string TEMPLATE_MANY = "Laboratories";
    public const string TEMPLATE_SINGLE = "Laboratory";

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
        WriteImport(model);
        WriteDI(model);
        WriteResources(model);
        WriteTranslations(model);

        return true;
    }

    private void WriteImport(GeneratorModel model)
    {
        //throw new NotImplementedException();
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
        var fileName = $"{model.Name}Model.cs";

        var path = $"{ROOT}\\Models\\{model.Name}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteModel)}: {fullPath}");
        try
        {
            File.WriteAllText(fullPath, "model cs file");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void WriteViewModel(GeneratorModel model)
    {
        var fileName = $"{model.Name}ViewModel.cs";

        var path = $"{ROOT}\\ViewModels\\{model.Name}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteViewModel)}: {fullPath}");
        try
        {
            File.WriteAllText(fullPath, "viewmodel cs file");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void WritePage(GeneratorModel model)
    {
        var fileName = $"{model.Name}.razor";

        var path = $"{ROOT}\\Pages";
        var fullPath = Path.Combine(path, fileName);
        var viewModel = $"{model.Name}ViewModel";
        Console.WriteLine($"{nameof(WritePage)}: {fullPath}");

        var lines = new[] {
            $"@page \"/{model.Tag.TagName}\"",
            $"@inherits MvvmComponentBase<{viewModel}>",
            "<div class=\"mx-auto w-full bg-white @ViewModel.Theme.Dark px-2 text-black dark:bg-gray-900 dark:text-white lg:px-10\"></div>"
        };
        try
        {
            File.WriteAllLines(fullPath, lines);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}