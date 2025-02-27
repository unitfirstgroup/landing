using System.ComponentModel;

namespace UnitFirst.Landing.Interfaces;

public interface IViewModelBase : INotifyPropertyChanged
{
    Task OnInitializedAsync();
    Task Loaded();
}