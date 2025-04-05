using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Cases;

namespace UnitFirst.Landing.ViewModels.Cases;

public partial class CasesViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private CasesModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new CasesModel()
        {
            Cases = new ObservableCollection<CaseModel>
            {
                new()
                {
                    Name = "E-Learning Platform for Corporate Training",
                    Description = "Develop a scalable, cloud-based e-learning platform for corporate training, allowing companies to create and manage customized courses, track employee progress, and measure ROI.",
                    Image = "images/healthcare-lab.svg",
                    UrlText = "E-Learning Platform for Corporate Training",
                    Url = "#"
                },
                new()
                {
                    Name = "Artificial Intelligence for Healthcare Support",
                    Description = "Apply AI-powered chatbots and predictive analytics to healthcare systems, enabling faster patient diagnosis, improved treatment outcomes, and enhanced administrative efficiency.",
                    Image = "images/media-lab.svg",
                    UrlText = "Artificial Intelligence for Healthcare Support",
                    Url = "#"
                },
                new()
                {
                    Name = "Cloud-Based Cybersecurity Solution for SMEs",
                    Description = "Create a subscription-based, cloud-based cybersecurity solution tailored to small and medium-sized enterprises, offering real-time threat detection, incident response, and compliance reporting.",
                    Image = "images/logistics-lab.svg",
                    UrlText = "Cloud-Based Cybersecurity Solution for SMEs",
                    Url = "#"
                },
                new()
                {
                    Name = "Intelligent Task Automation for Finance and Accounting",
                    Description = "Develop an AI-driven task automation platform for finance and accounting departments, streamlining routine tasks, reducing manual errors, and freeing up staff for high-value tasks.",
                    Image = "images/finances-lab.svg",
                    UrlText = "Intelligent Task Automation for Finance and Accounting",
                    Url = "#"
                },
                new()
                {
                    Name = "Education",
                    Description = "We bring innovation and engagement to the whole education process with custom EdTech solutions. From student information portals to online course management systems  – we develop user-friendly and easy-to-use e-learning portals.",
                    Image = "images/education-lab.svg",
                    UrlText = "Education",
                    Url = "#"
                },
                new()
                {
                    Name = "Real Estate",
                    Description = "Manage customers, monitor deal progress, and optimize offerings with custom real estate solutions. Our expertise includes property management software, virtual tour applications, real-time listing platforms, and more.",
                    Image = "images/real-estate-lab.svg",
                    UrlText = "Real Estate",
                    Url = "#"
                },
                new()
                {
                    Name = "Retail Store Operations Optimization Software",
                    Description = "Design and implement a mobile-based software solution for retail store operations, enabling staff to manage inventory, track sales, and optimize store performance in real-time.",
                    Image = "images/ecommerce-lab.svg",
                    UrlText = "Retail Store Operations Optimization Software",
                    Url = "#"
                },
                new()
                {
                    Name = "Blockchain-Based Supply Chain Management",
                    Description = "Create a blockchain-based platform for supply chain management, providing end-to-end visibility, improved tracking, and enhanced collaboration between suppliers, manufacturers, and customers.",
                    Image = "images/marketing-lab.svg",
                    UrlText = "Blockchain-Based Supply Chain Management",
                    Url = "#"
                },
                new()
                {
                    Name = "Blockchain-Based Supply Chain Management",
                    Description = "Create a blockchain-based platform for supply chain management, providing end-to-end visibility, improved tracking, and enhanced collaboration between suppliers, manufacturers, and customers.",
                    Image = "images/marketing-lab.svg",
                    UrlText = "Blockchain-Based Supply Chain Management",
                    Url = "#"
                },
                new()
                {
                    Name = "Digital Marketing Analytics and Optimization Platform",
                    Description = "Develop a cloud-based platform for digital marketers, offering real-time analytics, data visualization, and AI-powered optimization recommendations to improve campaign ROI.",
                    Image = "images/marketing-lab.svg",
                    UrlText = "Digital Marketing Analytics and Optimization Platform",
                    Url = "#"
                },
                new()
                {
                    Name = "Student Information System for Higher Education",
                    Description = "Design and implement a comprehensive student information system for higher education institutions, providing a single platform for student registration, course enrollment, and academic tracking.",
                    Image = "images/marketing-lab.svg",
                    UrlText = "Student Information System for Higher Education",
                    Url = "#"
                },
                new()
                {
                    Name = "Predictive Maintenance for Industrial Equipment",
                    Description = "Develop an IoT-powered predictive maintenance platform for industrial equipment, enabling manufacturers to detect potential failures, schedule maintenance, and minimize downtime.",
                    Image = "images/marketing-lab.svg",
                    UrlText = "Predictive Maintenance for Industrial Equipment",
                    Url = "#"
                },
                new()
                {
                    Name = "Customizable HR Management Software for Small Businesses",
                    Description = "Create a cloud-based HR management software solution for small businesses, offering customizable workflows, employee self-service, and compliance reporting to streamline HR operations.",
                    Image = "images/marketing-lab.svg",
                    UrlText = "Customizable HR Management Software for Small Businesses",
                    Url = "#"
                }
            },
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void GetDetails()
    {
    }
}