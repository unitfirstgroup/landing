using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;
using UnitFirst.Landing.Models.Shared;
using UnitFirst.Landing.Services;

namespace GenerarorRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrange
            var model = new GeneratorModel()
            {
                Name = "Features",
                Description = "Represents key features.",
                Kind = "Page",
                IsCollection = true,
                Tag = new TagModel { TagName = "/features" },
                Category = "Software Development",
            };
            IGeneratorService generatorService = new GeneratorService();

            // Act
            var result = generatorService.Generate(model);

            // Assert
            Console.WriteLine($"Page generation result: {result}");
        }
    }
}
