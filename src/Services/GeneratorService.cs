using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;

namespace UnitFirst.Landing.Services;

public class GeneratorService : IGeneratorService
{
    public const string ROOT = "C:\\Work\\unitfirst\\landing\\src";
    public const string DESTINATION = "C:\\Work\\unitfirst\\landing\\src";

    public bool Generate(GeneratorModel model)
    {
        // page
        // viewmodel
        // model
        // dependency injection
        // resources
        // translations

        WriteDataService(model);
        WriteImport(model);
        WriteDI(model);
        WriteModel(model);
        WriteViewModel(model);
        WriteComponent(model);
        WritePage(model);

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
        var fileName = "Program.cs";
        var fullPath = Path.Combine(ROOT, fileName);
        Console.WriteLine($"{nameof(WriteDI)}: {fullPath}");
        try
        {
            var queue = new Queue<string>();
            var lines = File.ReadAllLines(fullPath);
            foreach (var line in lines)
            {
                queue.Enqueue(line);
                if (line == "@using UnitFirst.Landing.Models;")
                {
                    queue.Enqueue($"@using UnitFirst.Landing.Models.{model.Name};");
                }

                if (line == "@using UnitFirst.Landing.ViewModels;")
                {
                    queue.Enqueue($"@using UnitFirst.Landing.ViewModels.{model.Name};");
                }

                if (line == "builder.Services.AddTransient<FooterViewModel>();")
                {
                    queue.Enqueue(Environment.NewLine);
                    queue.Enqueue($"builder.Services.AddTransient<{model.Name}ViewModel>();");
                    queue.Enqueue($"builder.Services.AddTransient<ISearchService<{model.Name}Model>, SearchService<{model.Name}Model>>();");
                    queue.Enqueue($"builder.Services.AddTransient<IDataService<{model.Name}Model>, {model.Name}DataService>();");
                }
            }

            File.WriteAllLines(fullPath, queue);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void WriteImport(GeneratorModel model)
    {
        var fileName = "_Imports.razor";
        var fullPath = Path.Combine(ROOT, fileName);
        Console.WriteLine($"{nameof(WriteImport)}: {fullPath}");
        try
        {
            var queue = new Queue<string>();
            var lines = File.ReadAllLines(fullPath);
            foreach (var line in lines)
            {
                queue.Enqueue(line);
                if (line == "@using UnitFirst.Landing.Models.Shared")
                {
                    queue.Enqueue($"@using UnitFirst.Landing.Models.{model.Name}");
                }

                if (line == "@using UnitFirst.Landing.ViewModels")
                {
                    queue.Enqueue($"@using UnitFirst.Landing.ViewModels.{model.Name}");
                }
            }

            File.WriteAllLines(fullPath, queue);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void WriteDataService(GeneratorModel model)
    {
        var fileName = $"{model.Name}DataService.cs";

        var path = $"{DESTINATION}\\Services";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteDataService)}: {fullPath}");
        var cloneServicePath = $"{ROOT}\\Services\\CloneBaseDataService.cs";
        try
        {
            var clone = File.ReadAllText(cloneServicePath);
            var updated = clone
                .Replace("using UnitFirst.Landing.Models;", $"using UnitFirst.Landing.Models.{model.Name};")
                .Replace("CloneBaseDataService", $"{model.Name}DataService")
                .Replace("BaseModel", $"{model.Name}Model");
            File.WriteAllText(fullPath, updated);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void WriteModel(GeneratorModel model)
    {
        var fileName = $"{model.Name}Model.cs";

        var path = $"{DESTINATION}\\Models\\{model.Name}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteViewModel)}: {fullPath}");
        var cloneModelPath = $"{ROOT}\\Models\\CloneBaseModel.cs";
        try
        {
            var clone = File.ReadAllText(cloneModelPath);
            var updated = clone
                .Replace("CloneBaseModel", $"{model.Name}Model")
                .Replace("namespace UnitFirst.Landing.Models;", $"namespace UnitFirst.Landing.Models.{model.Name};");
            File.WriteAllText(fullPath, updated);
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

        var path = $"{DESTINATION}\\ViewModels\\{model.Name}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteViewModel)}: {fullPath}");
        var cloneViewModelPath = $"{ROOT}\\ViewModels\\CloneBaseViewModel.cs";
        try
        {
            //
            var clone = File.ReadAllText(cloneViewModelPath);
            var updated = clone
                .Replace("BaseCloneViewModel", $"{model.Name}ViewModel")
                .Replace("BaseModel", $"{model.Name}Model")
                .Replace("using UnitFirst.Landing.Models;", $"using UnitFirst.Landing.Models;{Environment.NewLine}using UnitFirst.Landing.Models.{model.Name};")
                .Replace("namespace UnitFirst.Landing.ViewModels;", $"namespace UnitFirst.Landing.ViewModels.{model.Name};");
            File.WriteAllText(fullPath, updated);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void WriteComponent(GeneratorModel model)
    {
        var path = $"{DESTINATION}\\Components";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, $"{model.Name}.razor");
       
        Console.WriteLine($"{nameof(WriteComponent)}: {fullPath}");

        var cloneComponentPath = $"{ROOT}\\Components\\CloneBase.razor";
        try
        {
            var clone = File.ReadAllText(cloneComponentPath);
            var updated = clone
                .Replace("BaseModel", $"{model.Name}Model");
            File.WriteAllText(fullPath, updated);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    private void WritePage(GeneratorModel model)
    {
        var path = $"{DESTINATION}\\Pages";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, $"{model.Name}Page.razor");

        Console.WriteLine($"{nameof(WritePage)}: {fullPath}");

        var cloneViewModelPath = $"{ROOT}\\Pages\\CloneBasePage.razor";
        try
        {
            var clone = File.ReadAllText(cloneViewModelPath);
            var updated = clone
                .Replace("@page \"/base\"", $"@page \"{model.Tag.TagName}\"")
                .Replace("@inherits MvvmComponentBase<BaseCloneViewModel>", $"@inherits MvvmComponentBase<{model.Name}ViewModel>")
                .Replace("TItem=\"BaseModel\"", $"TItem=\"{model.Name}Model\"")
                .Replace("<Card",$"<{model.Name}")
                .Replace("</Card>", $"</{model.Name}>");
            File.WriteAllText(fullPath, updated);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}