using CRUD_MVVM.Models;
using CRUD_MVVM.Services;
using System.Windows.Input;

namespace CRUD_MVVM.ViewModels;

[QueryProperty(nameof(Person), "MyPerson")]
public class AddEditPageViewModel : BaseViewModel
{
    private readonly IDataService service;
    public AddEditPageViewModel(IDataService service)
    {
        this.service = service;
    }
    public string Mode { get; set; }

    private Person person;
    public Person Person
    {
        get => person;
        set
        {
            SetProperty(ref person, value);
            Title = Person.Id == 0 ? "Add Person" : "Edit Person";
        }
    }

    private Command makeOlderCommand;
    public ICommand MakeOlderCommand => makeOlderCommand ??= new Command(
        execute: () =>
        {
            Person.Age++;
        });


    private Command saveCommand;
    public ICommand SaveCommand => saveCommand ??= new Command(async () =>
    {
        service.SavePerson(Person);
        await Shell.Current.GoToAsync("..");
    });
}
