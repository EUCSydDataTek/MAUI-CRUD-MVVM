using MVVM_INPC.Models;
using MVVM_INPC.Views;
using System.Windows.Input;

namespace MVVM_INPC.ViewModels;
public class MainPageViewModel : BaseViewModel
{
    public Person ThePerson { get; set; }
    public MainPageViewModel()
    {
        ThePerson = new Person { Name = "Katja", Age = 28 };
    }

    private Command goToEditCommand;
    public ICommand GoToEditCommand => goToEditCommand ??= new Command(async () =>
        {
            if (ThePerson == null)
                return;

            await Shell.Current.GoToAsync(nameof(DetailPage), true, new Dictionary<string, object>
            {
                {"MyPerson", ThePerson }
            });
        });
}
