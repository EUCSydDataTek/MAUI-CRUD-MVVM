using CommunityToolkit.Mvvm.ComponentModel;

namespace CRUD_MVVM.Models;
public partial class Person : ObservableObject
{
    public int Id { get; set; }

    [ObservableProperty]
    string name;

    [ObservableProperty]
    int age;
}
