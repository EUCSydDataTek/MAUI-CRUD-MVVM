using CRUD_MVVM.Models;
using CRUD_MVVM.Services;
using CRUD_MVVM.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace CRUD_MVVM.ViewModels;
public class ListPageViewModel : BaseViewModel
{
    public ObservableCollection<Person> Persons { get; } = new();
    public ListPageViewModel(IDataService service)
    {
        this.service = service;
    }

    private Command getPersonsCommand;
    public ICommand GetPersonsCommand => getPersonsCommand ??= new Command(async () => await GetPersonsAsync());

    async Task GetPersonsAsync()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;

            List<Person> persons = service.GetPersons();

            if (Persons.Count != 0)
                Persons.Clear();

            foreach (Person person in persons)
                Persons.Add(person);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get persons: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }

    private Command goToDetailsCommand;
    public ICommand GoToDetailsCommand => goToDetailsCommand ??= new Command<Person>(async (person) =>
    {
        if (person == null)
            return;

        await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
        {
            {"MyPerson", person }
        });
    });

    private Command goToAddEditCommand;
    private readonly IDataService service;

    public ICommand GoToAddEditCommand => goToAddEditCommand ??= new Command(async () =>
    {
        await Shell.Current.GoToAsync(nameof(AddEditPage), true, new Dictionary<string, object>
        {
            {"MyPerson", new Person() }
        });
    });
}