using MVVM_INPC.Models;
using MVVM_INPC.Views;
using System.Windows.Input;

namespace MVVM_INPC.ViewModels;

[QueryProperty(nameof(Person), "MyPerson")]
public class DetailsPageViewModel : BaseViewModel
{
    Person person;
    public Person Person
    {
        get => person;
        set => SetProperty(ref person, value);
    }

    private Command goToAddEditCommand;

    public ICommand GoToAddEditCommand => goToAddEditCommand ??= new Command(async () =>
    {
        await Shell.Current.GoToAsync(nameof(AddEditPage), true, new Dictionary<string, object>
        {
            {"MyPerson", Person }
        });
    });
}
