using MVVM_INPC.Models;
using System.Windows.Input;

namespace MVVM_INPC.ViewModels;

[QueryProperty(nameof(Person), "MyPerson")]
public class DetailPageViewModel : BaseViewModel
{
    Person person;
    public Person Person
    {
        get => person;
        set => SetProperty(ref person, value);
    }

    private Command makeOlderCommand;
    public ICommand MakeOlderCommand => makeOlderCommand ??= new Command(
        execute: () =>
        {
            Person.Age++;
            OnPropertyChanged(nameof(Person));  // Refresh the binding to Person-object
        });
}
