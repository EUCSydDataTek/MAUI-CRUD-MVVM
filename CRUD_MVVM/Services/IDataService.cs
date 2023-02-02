using CRUD_MVVM.Models;

namespace CRUD_MVVM.Services;
public interface IDataService
{
    List<Person> GetPersons();
    void SavePerson(Person person);

    void DeletePerson(Person person);
}
