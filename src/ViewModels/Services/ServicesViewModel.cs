using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;
using UnitFirst.Landing.Models.Services;

namespace UnitFirst.Landing.ViewModels.Services;

public partial class ServicesViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager, IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    [ObservableProperty] private ServicesModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new ServicesModel()
        {
            Services = new ObservableCollection<ServiceModel>
            {
                new()
                {
                    Name = "Custom software development",
                    Description = "We develop bespoke solutions for specific business needs and requirements. Custom development means full-cycle software development adapted to your case regarding budget, timelines, tech stack, advanced technologies, and other aspects.",
                    Image = "images/custom-development.svg",
                    UrlText = "Custom software development",
                    Url = "#"
                },
                new()
                {
                    Name = "IoT development",
                    Description = "We develop IoT systems of any scale, from fleets of a few devices to hundreds. IoT development is our specialization, so we have enough expertise to provide consulting services along with development services. Our services include calculating ROI, identifying IoT implementation opportunities for specific businesses, visualizing data through informative dashboards, designing effective device management systems, securing vulnerable components, optimizing data transfer and network usage, and much more. We offer over 10 years of experience in delivering successful IoT projects.",
                    Image = "images/iot-platform.svg",
                    UrlText = "IoT development",
                    Url = "#"
                },
                new()
                {
                    Name = "Web development",
                    Description = "We develop scalable, high-performance, and secure web applications. While different web solutions may seem similar at first glance, we approach each one uniquely, leveraging our expertise to ensure the application meets user expectations, drives business growth, delivers value, and remains competitive over time.",
                    Image = "images/web-development.svg",
                    UrlText = "Web development",
                    Url = "#"
                },
                new()
                {
                    Name = "Mobile development",
                    Description = "Our team of skilled mobile developers and creative designers build excellent iOS, Android, and cross-platform applications, crafting simple and intuitive interfaces and shaping excellent user experiences. We know how to engage and retain users, and happy users mean a business will thrive.",
                    Image = "images/mobile-development.svg",
                    UrlText = "Mobile development",
                    Url = "#"
                },
                new()
                {
                    Name = "AI development",
                    Description = "From predictive analytic to AI-powered healthcare diagnostics, our Artificial Intelligence services span every industry. Our expertise lies in custom AI model development, predictive analytic, machine learning implementation, natural language processing, computer vision, and AI tools for predictive maintenance.",
                    Image = "images/ai-development.svg",
                    UrlText = "AI development",
                    Url = "#"
                },
                new()
                {
                    Name = "ChatGPT development",
                    Description = "By incorporating ChatGPT, applications can provide 24/7 availability, efficient customer support, and data-driven insights. We provide consultation, customization, and integration of ChatGPT capabilities into web and mobile applications, enabling dynamic conversations, cost savings, enhanced user retention, and increased user engagement.",
                    Image = "images/gpt-development.svg",
                    UrlText = "ChatGPT development",
                    Url = "#"
                }
            },
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void GetInTouch()
    {
        Console.WriteLine(nameof(GetInTouch));
    }

    [RelayCommand]
    public void BookConsultation()
    {
        Console.WriteLine(nameof(BookConsultation));
    }
}