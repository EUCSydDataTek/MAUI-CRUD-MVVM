using MVVM_INPC.Models;

namespace MVVM_INPC.Services;
public interface IDataService
{
    List<Person> GetPersons();
    void SavePerson(Person person);

    void DeletePerson(Person person);
}
