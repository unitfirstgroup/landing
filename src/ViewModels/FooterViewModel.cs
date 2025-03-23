using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models;

namespace UnitFirst.Landing.ViewModels;

public partial class FooterViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager,
        IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager)
{
    [ObservableProperty] private FooterModel _model;

    public override Task OnInitializedAsync()
    {
        Model = new FooterModel
        {
            SocialNetworksDescription = localizer["SOCIAL_NETWORKS_DESC"].Value,
            OrganizationManifest = localizer["ORGANIZATION_MANIFEST"].Value,
            Categories = new ObservableCollection<FooterItemModel>(new []
            {
                new FooterItemModel()
                {
                    Category = "Products",
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = "Business digital maintainer"},
                        new(){Name = "Market research"},
                        new(){Name = "Operations"},
                        new(){Name = "Sales and Marketing"}
                    }
                },
                new FooterItemModel()
                {
                    Category = "Useful links",
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = "Pricing"},
                        new(){Name = "Settings"},
                        new(){Name = "Orders"},
                        new(){Name = "Help"}
                    }
                },
                new FooterItemModel()
                {
                    Category = "Contact",
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = "New York, NY 10311, US"},
                        new(){Name = "info@projectfabric.com"},
                        new(){Name = "+ 01 234 567 88"},
                        new(){Name = "+ 01 234 567 89"}
                    }
                },new FooterItemModel()
                {
                    Category = "Documents",
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = "Terms"},
                        new(){Name = "Privacy"},
                        new(){Name = "Security"},
                        new(){Name = "Manage cookies"}
                    }
                }
            })
        };

        return base.OnInitializedAsync();
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}