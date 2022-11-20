using MVVM_INPC.Views;

namespace MVVM_INPC;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        Routing.RegisterRoute(nameof(AddEditPage), typeof(AddEditPage));
    }
}
