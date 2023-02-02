using CRUD_MVVM.Views;

namespace CRUD_MVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        Routing.RegisterRoute(nameof(AddEditPage), typeof(AddEditPage));
    }
}
