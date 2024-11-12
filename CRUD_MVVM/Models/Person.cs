using CommunityToolkit.Mvvm.ComponentModel;

namespace CRUD_MVVM.Models;
public partial class Person : ObservableObject
{
    [ObservableProperty]
    int id;

    [ObservableProperty]
    string name;

    [ObservableProperty]
    int age;
}
