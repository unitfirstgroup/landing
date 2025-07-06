using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Collections.ObjectModel;
using UnitFirst.Landing.Interfaces;
using UnitFirst.Landing.Models.Cases;
using UnitFirst.Landing.Models.Feedback;

namespace UnitFirst.Landing.ViewModels.Cases;

public partial class CasesViewModel(IApplicationStateService applicationStateService,
        IApplicationThemeService applicationThemeService,
        NavigationManager navigationManager,
        IStringLocalizer<App> localizer,
        IDataService<CaseModel> caseDataService,
        IDataService<FeedbackModel> feedbackDataService)
    : ViewModelBase(applicationStateService, applicationThemeService, navigationManager, localizer)
{
    [ObservableProperty] private CasesModel _model;

    public override Task OnInitializedAsync()
    {
        _model = new CasesModel
        {
            Cases = new ObservableCollection<CaseModel>(caseDataService.LoadData()),
            Feedback = new FeedbackComponentModel
            {
                Title = localizer["CASES_FEEDBACK_TITLE"].Value,
                FeedbackItems = new ObservableCollection<FeedbackModel>(feedbackDataService.LoadData()),
            }
        };
        return Task.CompletedTask;
    }

    [RelayCommand]
    public void GetDetails()
    {
        navigationManager.NavigateTo("./registration");
    }
}