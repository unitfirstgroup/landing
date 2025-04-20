using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Laboratories;
using UnitFirst.Landing.Models.Shared;

namespace UnitFirst.Landing.ViewModels.Laboratories;

public partial class LaboratoriesViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        ISearchService<LaboratoryModel> searchService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private LaboratoriesModel _model;

    private List<LaboratoryModel> _labs = new()
    {
        new()
        {
            Name = "Healthcare",
            Description =
                "Patient management systems, medicine platforms, IoT-powered applications, AI-powered diagnostics, data analytics and visualization – these are several solution types we are experts at developing. All solutions are HIPPA compliant, GDPR, HITECH, FDA, and other requirements compliant.",
            Image = "images/healthcare-lab.svg",
            UrlText = "Healthcare",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Healthcare", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "Media & Entertainment",
            Description =
                "Streaming platforms, personalized recommendation engines, social media management tools, event systems, and more. We know how to engage users, personalize their experience and develop systems with minimal downtime periods, even during high-traffic times.",
            Image = "images/media-lab.svg",
            UrlText = "Media & Entertainment",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Media", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "Logistics",
            Description =
                "We bring real-time tracking, route optimization, inventory management, process automation, and easy fleet management to any logistics business. We go every mile and then some to keep goods and business moving.",
            Image = "images/logistics-lab.svg",
            UrlText = "Logistics",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Transport", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "Finances",
            Description =
                "Wealth management software, compliance and reporting tools, payment processing solutions, insurance management systems, budgeting and financial planning tools – every software we develop for the finance industry features security, scalability, and compliance with industry regulations.",
            Image = "images/finances-lab.svg",
            UrlText = "Finances",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Business", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "Education",
            Description =
                "We bring innovation and engagement to the whole education process with custom EdTech solutions. From student information portals to online course management systems  – we develop user-friendly and easy-to-use e-learning portals.",
            Image = "images/education-lab.svg",
            UrlText = "Education",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Media", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "Real Estate",
            Description =
                "Manage customers, monitor deal progress, and optimize offerings with custom real estate solutions. Our expertise includes property management software, virtual tour applications, real-time listing platforms, and more.",
            Image = "images/real-estate-lab.svg",
            UrlText = "Real Estate",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Business", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "eCommerce",
            Description =
                "We build stronger connections with customers through web and mobile applications with superior shopping experience and 24/7 availability.",
            Image = "images/ecommerce-lab.svg",
            UrlText = "eCommerce",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Business", Select = new SelectModel()}
            })
        },
        new()
        {
            Name = "Marketing",
            Description =
                "We build marketing automation tools that help optimize marketing strategies, gather insights, and achieve brave goals with customers.",
            Image = "images/marketing-lab.svg",
            UrlText = "Marketing",
            Url = "#",
            Tags = new ObservableCollection<TagModel>(new []
            {
                new TagModel(){TagName = "Business", Select = new SelectModel()}
            })
        }
    };

    public override Task OnInitializedAsync()
    {
        _model = new LaboratoriesModel()
        {
            Filter = new FilterModel()
            {
                SearchModel = new SearchModel()
                {
                    Placeholder = "Choose domain area and take our digital service.",
                    RaiseSearchCommand = SearchLaboratoriesCommand
                },
                Tags = new ObservableCollection<TagModel>(new[]
                {
                    new TagModel { TagName = "All", Select = new SelectModel() { IsSelected = true } },
                    new TagModel { TagName = "Healthcare", Select = new SelectModel() { IsSelected = false } },
                    new TagModel { TagName = "Finances", Select = new SelectModel() { IsSelected = false } },
                    new TagModel { TagName = "Education", Select = new SelectModel() { IsSelected = false } }
                }),
                Dark = Theme.Dark
            },
            Laboratories = new ObservableCollection<LaboratoryModel>(_labs)
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void SearchLaboratories()
    {
        var filtered = searchService.Search(_labs, Model.Filter);
        Model.Laboratories.Clear();
        foreach (var laboratoryModel in filtered)
        {
            Model.Laboratories.Add(laboratoryModel);
        }

        NotifyStateChanged();
    }

    [RelayCommand]
    public void GetDetails()
    {
        Console.WriteLine("Get Details");
    }
}