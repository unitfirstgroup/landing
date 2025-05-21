using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Blogs;
using UnitFirst.Landing.Models.Laboratories;
using UnitFirst.Landing.Services;
using UnitFirst.Landing.ViewModels.About;
using UnitFirst.Landing.ViewModels.Blogs;
using UnitFirst.Landing.ViewModels.Cases;
using UnitFirst.Landing.ViewModels.Laboratories;
using UnitFirst.Landing.ViewModels.Layouts;
using UnitFirst.Landing.ViewModels.Services;
using UnitFirst.Landing.ViewModels.Wallpaper;

namespace UnitFirst.Landing.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddViewModels(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<NavMenuViewModel>();
        services.AddTransient<FooterViewModel>();
        services.AddTransient<LaboratoriesViewModel>();
        services.AddTransient<BlogsViewModel>();
        services.AddTransient<WallPaperViewModel>();
        services.AddTransient<ServicesViewModel>();
        services.AddTransient<CasesViewModel>();
        services.AddTransient<AboutViewModel>();

        return services;
    }

    public static IServiceCollection AddSearchServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<ISearchService<LaboratoryModel>, SearchService<LaboratoryModel>>();
        services.AddTransient<ISearchService<BlogModel>, SearchService<BlogModel>>();
        
        return services;
    }

    public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IDataService<LaboratoryModel>, LaboratoryDataService>();
        services.AddTransient<IDataService<BlogModel>, BlogDataService>();

        return services;
    }

    public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IApplicationThemeService, ApplicationThemeService>();
        services.AddSingleton<IApplicationStateService, ApplicationStateService>();
        services.AddSingleton<IBrowserService, BrowserService>();

        return services;
    }
}