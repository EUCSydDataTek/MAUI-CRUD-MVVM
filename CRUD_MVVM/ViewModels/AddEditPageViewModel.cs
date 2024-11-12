using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUD_MVVM.Models;
using CRUD_MVVM.Services;
using System.Windows.Input;

namespace CRUD_MVVM.ViewModels;

[QueryProperty(nameof(Person), "MyPerson")]
public partial class AddEditPageViewModel(IDataService service) : BaseViewModel
{
    // Title = Person.Id == 0 ? "Add Person" : "Edit Person";
    public string Mode { get; set; }

    [ObservableProperty]
    private Person person;

    [RelayCommand]
    public void MakeOlder() => Person.Age++;

    [RelayCommand]
    public async Task Save()
    {
        service.SavePerson(Person);
        await Shell.Current.GoToAsync("..");
    }
}
