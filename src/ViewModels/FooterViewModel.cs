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
                    Category = localizer["FOOTER_PRODUCTS"].Value,
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = localizer["FOOTER_PRODUCTS_0"].Value},
                        new(){Name = localizer["FOOTER_PRODUCTS_1"].Value},
                        new(){Name = localizer["FOOTER_PRODUCTS_2"].Value},
                        new(){Name = localizer["FOOTER_PRODUCTS_3"].Value}
                    }
                },
                new FooterItemModel()
                {
                    Category = localizer["FOOTER_LINKS"].Value,
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = localizer["FOOTER_LINK_0"].Value},
                        new(){Name = localizer["FOOTER_LINK_1"].Value},
                        new(){Name = localizer["FOOTER_LINK_2"].Value},
                        new(){Name = localizer["FOOTER_LINK_3"].Value}
                    }
                },
                new FooterItemModel()
                {
                    Category = localizer["FOOTER_CONTACTS"].Value,
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = localizer["FOOTER_CONTACT_0"].Value},
                        new(){Name = localizer["FOOTER_CONTACT_1"].Value},
                        new(){Name = localizer["FOOTER_CONTACT_2"].Value},
                        new(){Name = localizer["FOOTER_CONTACT_3"].Value}
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