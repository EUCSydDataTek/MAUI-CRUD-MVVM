using CRUD_MVVM.Models;
using CRUD_MVVM.Services;
using CRUD_MVVM.Views;
using System.Windows.Input;

namespace CRUD_MVVM.ViewModels;

[QueryProperty(nameof(Person), "MyPerson")]
public class DetailsPageViewModel : BaseViewModel
{
    Person person;
    public Person Person
    {
        get => person;
        set => SetProperty(ref person, value);
    }

    private readonly IDataService service;
    public DetailsPageViewModel(IDataService service)
    {
        this.service = service;
    }

    private Command goToAddEditCommand;
    public ICommand GoToAddEditCommand => goToAddEditCommand ??= new Command(async () =>
    {
        await Shell.Current.GoToAsync(nameof(AddEditPage), true, new Dictionary<string, object>
        {
            {"MyPerson", Person }
        });
    });

    private Command deleteCommand;
    public ICommand DeleteCommand => deleteCommand ??= new Command(async () =>
    {
        bool answer = await Shell.Current.DisplayAlert("DELETE?", "Are you shure?", "Ok", "Cancel");
        if (answer)
        {
            service.DeletePerson(Person);
        }
        await Shell.Current.GoToAsync("..");
    });
}
