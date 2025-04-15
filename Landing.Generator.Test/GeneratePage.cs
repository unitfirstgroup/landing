using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Generator;
using UnitFirst.Landing.Models.Shared;
using UnitFirst.Landing.Services;

namespace Landing.Generator.Test
{
    public class GeneratePage
    {
        [Fact]
        public void GeneratePageSourcesTest()
        {
            // Arrange
            var model = new GeneratorModel()
            {
                Name = "Features",
                Description = "Represents key features.",
                Kind = "Page",
                Tag = new TagModel { TagName = "/features" },
                Category = "Software Development",
            };
            IGeneratorService generatorService = new GeneratorService();

            // Act
            var result = generatorService.Generate(model);

            // Assert
            Assert.True(result);
        }
    }
}