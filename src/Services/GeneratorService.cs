using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;

namespace UnitFirst.Landing.Services;

public class GeneratorService : IGeneratorService
{
    public const string ROOT = "C:\\Work\\unitfirst\\landing\\src";
    //public const string ROOT = "C:\\Users\\DeLL\\Downloads";
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
        WriteComponent(model);
        WriteViewModel(model);
        WriteModel(model);
        WriteDataService(model);
        WriteImport(model);
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

    private void WriteImport(GeneratorModel model)
    {
        //throw new NotImplementedException();
    }

    private void WriteDataService(GeneratorModel model)
    {
        var fileName = $"{model.Name}Model.cs";

        var path = $"{ROOT}\\Services\\{model.Name}";
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

        var path = $"{ROOT}\\Models\\{model.Name}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteViewModel)}: {fullPath}");
        var cloneModelPath = $"{ROOT}\\Models\\LaboratoryModel.cs";
        try
        {
            var clone = File.ReadAllText(cloneModelPath);
            var updated = clone
                .Replace("LaboratoryModel", $"{model.Name}Model")
                .Replace("", "");
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

        var path = $"{ROOT}\\ViewModels\\{model.Name}";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        var fullPath = Path.Combine(path, fileName);
        Console.WriteLine($"{nameof(WriteViewModel)}: {fullPath}");
        var cloneViewModelPath = $"{ROOT}\\ViewModels\\{model.Name}\\{fileName}";
        try
        {
            var clone = File.ReadAllText(cloneViewModelPath);
            var updated = clone
                .Replace("LaboratoryModel", "")
                .Replace("", "");
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
        var path = $"{ROOT}\\Components";
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
        var fileName = $"{model.Name}.razor";

        var path = $"{ROOT}\\Pages";
        var fullPath = Path.Combine(path, fileName);
        var viewModel = $"{model.Name}ViewModel";

        Console.WriteLine($"{nameof(WritePage)}: {fullPath}");

        var cloneViewModelPath = $"{ROOT}\\Pages\\Laboratories.razor";
        try
        {
            var clone = File.ReadAllText(cloneViewModelPath);
            var updated = clone
                .Replace("@page \"/laboratories\"", $"@page \"{model.Tag.TagName}\"")
                .Replace("@inherits MvvmComponentBase<LaboratoriesViewModel>", $"@inherits MvvmComponentBase<{viewModel}>")
                .Replace("TItem=\"LaboratoryModel\"", $"TItem=\"{model.Name}Model\"")
                .Replace("<Card",$"<{model.Name}");
            File.WriteAllText(fullPath, updated);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}