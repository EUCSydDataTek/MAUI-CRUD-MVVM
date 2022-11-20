using MVVM_INPC.Models;

namespace MVVM_INPC.Services;
public class DataService : IDataService
{
    List<Person> Persons;
    public DataService()
    {
        Persons = new List<Person>
        {
            new Person { Id = 1, Name = "Anna", Age = 27 },
            new Person { Id = 2, Name = "Christian", Age = 32 },
            new Person { Id = 3, Name = "Helle", Age = 54 }
        };
    }
    public List<Person> GetPersons()
    {
        return Persons;
    }

    public void SavePerson(Person person)
    {
        if (person.Id == 0)
        {
            int maxNumber = Persons.Max(x => x.Id);
            person.Id =++maxNumber;
            Persons.Add(person);
        }
        else 
        {
            Person existing =  Persons.FirstOrDefault(x => x.Id == person.Id);
            int existingIndex = Persons.IndexOf(existing);
            Persons[existingIndex] = person;
        }      
    }
}
