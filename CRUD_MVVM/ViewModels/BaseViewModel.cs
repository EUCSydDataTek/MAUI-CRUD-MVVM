using CommunityToolkit.Mvvm.ComponentModel;

namespace CRUD_MVVM.ViewModels;
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isBusy = false;

    [ObservableProperty]
    string title = string.Empty;

    [ObservableProperty]
    bool isRefreshing;
}