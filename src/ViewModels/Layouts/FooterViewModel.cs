using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Layout;

namespace UnitFirst.Landing.ViewModels.Layouts;

public partial class FooterViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService, NavigationManager navigationManager,
        IStringLocalizer<App> localizer)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
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
                },
                new FooterItemModel()
                {
                    Category = localizer["FOOTER_DOCUMENTS"].Value,
                    CategoryItems = new ObservableCollection<FooterCategoryItem>()
                    {
                        new(){Name = localizer["FOOTER_DOCUMENT_0"].Value},
                        new(){Name = localizer["FOOTER_DOCUMENT_1"].Value},
                        new(){Name = localizer["FOOTER_DOCUMENT_2"].Value},
                        new(){Name = localizer["FOOTER_DOCUMENT_3"].Value}
                    }
                }
            }),
            AllRightsReserved = localizer["FOOTER_RIGHTS"].Value
        };

        return base.OnInitializedAsync();
    }

    [RelayCommand]
    public void GetStarted()
    {
    }
}