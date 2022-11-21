namespace MVVM_INPC.Models;
public class Person : BaseModel
{
    string name;
    public string Name
    {
        get { return name; }
        set { SetProperty(ref name, value); }
    }

    int age;
    public int Age
    {
        get { return age; }
        set { SetProperty(ref age, value); }
    }
}
