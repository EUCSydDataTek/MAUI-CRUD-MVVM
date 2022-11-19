namespace MVVM_INPC.Models;
public class Person : BaseModel
{
    public string Name { get; set; }


    int age;
    public int Age
    {
        get { return age; }
        set { SetProperty(ref age, value); }
    }
}
