using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUD_MVVM.Models;
using CRUD_MVVM.Services;
using CRUD_MVVM.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CRUD_MVVM.ViewModels;
public partial class ListPageViewModel(IDataService service) : BaseViewModel
{
    public ObservableCollection<Person> Persons { get; } = new();

    [RelayCommand]
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

    [RelayCommand]
    public async Task GoToDetails(Person person)
    {
        if (person == null)
            return;

        await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
        {
            {"MyPerson", person }
        });
    }

    [RelayCommand]
    public async Task GoToAddEdit()
    {
        await Shell.Current.GoToAsync(nameof(AddEditPage), true, new Dictionary<string, object>
        {
            {"MyPerson", new Person() }
        });
    }
}